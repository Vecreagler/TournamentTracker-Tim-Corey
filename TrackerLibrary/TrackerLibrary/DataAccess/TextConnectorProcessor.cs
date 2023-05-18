using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using System.IO;
using System.Linq;
using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess.TextHelpers
{
    public static class TextConnectorProcessor
    {
        public static string FullFilePath( this string fileName)
        {
            // my desktop -> Tournament Tracker -> new file
            return $"{ConfigurationManager.AppSettings["filePath"]}\\{fileName}";
        }

        public static List<string> LoadFile(this string file)
        {
            if (!File.Exists(file))
            {
                return new List<string>();
            }

            return File.ReadAllLines(file).ToList();
        }

        public static List<PrizeModel> ConvertToPrizeModels(this List<string> lines)
        {
            List<PrizeModel> output = new List<PrizeModel>();

            foreach(string line in lines)
            {
                string[] cols = line.Split(',');

                PrizeModel p = new PrizeModel();
                p.ID = int.Parse(cols[0]);
                p.PlaceNumber = int.Parse(cols[1]);
                p.PlaceName = cols[2];
                p.PrizeAmount = decimal.Parse(cols[3]);
                p.PrizePercentage = double.Parse(cols[4]);
                output.Add(p);
            }
            return output;
        }

        public static void SaveToPrizeFile(this List<PrizeModel> models, string fileName)
        {
            List<string> lines = new List<string>();
            
            foreach(PrizeModel p in models)
            {
                lines.Add($"{p.ID},{p.PlaceNumber},"+
                    $"{p.PlaceName},{p.PrizeAmount},"+
                    $"{p.PrizePercentage}");
            }

            File.WriteAllLines(fileName.FullFilePath(), lines);
        }

        public static List<PersonModel> ConvertToPersonModels(this List<string> lines)
        {
            List<PersonModel> output = new List<PersonModel>();
            foreach (string line in lines)
            {
                string[] cols = line.Split(',');

                PersonModel p = new PersonModel();
                int i = 0;
                p.ID = int.Parse(cols[i++]);
                p.FirstName = cols[i++];
                p.Lastname = cols[i++];
                p.EmailAddress = cols[i++];
                p.CellPhoneNumber = cols[i++];
                output.Add(p);
            }
            return output;
        }

        public static void SaveToPeopleFile(this List<PersonModel> models, string fileName)
        {
            List<string> lines = new List<string>();

            foreach (PersonModel p in models)
            {
                lines.Add($"{p.ID},{p.FirstName},"+
                    $"{p.Lastname},{p.EmailAddress},"+
                    $"{p.CellPhoneNumber}");
            }

            File.WriteAllLines(fileName.FullFilePath(), lines);
        }

        public static List<TeamModel> ConvertToTeamModels(this List<string> lines, string peopleFileName)
        {
            List<TeamModel> output = new List<TeamModel>();
            List<PersonModel> people = peopleFileName.FullFilePath().LoadFile().ConvertToPersonModels();

            foreach (string line in lines)
            {
            string[] cols = line.Split(',');
                TeamModel t = new TeamModel();
                int i = 0;
                t.ID = int.Parse(cols[i++]);
                t.TeamName = cols[i++];

                string[] personIds = cols[i++].Split('|');

                foreach(string id in personIds)
                {
                    t.TeamMembers.Add(people.Where(x => x.ID == int.Parse(id)).First());
                }

                output.Add(t);
            }

            return output;

        }

        public static void SaveToTeamFile(this List<TeamModel> models, string fileName)
        {
            List<string> lines = new List<string>();

            foreach (TeamModel t in models)
            {
                lines.Add($"{t.ID},{t.TeamName},{ConvertPeopleListToString(t.TeamMembers)}");
            }

            File.WriteAllLines(fileName.FullFilePath(), lines);
        }

        private static string ConvertPeopleListToString(List<PersonModel> people)
        {
            string output = "";

            if(people.Count == 0)
            {
                return "";
            }

            foreach(PersonModel p in people)
            {
                output += $"{p.ID}|";
            }
            output = output.Substring(0, output.Length - 1);

            return output;
        }

    }
}
