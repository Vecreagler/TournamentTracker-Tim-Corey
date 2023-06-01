﻿using System;
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


        #region ConvertTo

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
        public static List<TeamModel> ConvertToTeamModels(this List<string> lines)
        {
            List<TeamModel> output = new List<TeamModel>();
            List<PersonModel> people = GlobalConfig.PeopleFile.FullFilePath().LoadFile().ConvertToPersonModels();

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
        public static List<TournamentModel> ConvertToTournamentModels(this List<string> lines)
        {

            List<TournamentModel> output = new List<TournamentModel>();
            List<TeamModel> teams = GlobalConfig.TeamFile.FullFilePath().LoadFile().ConvertToTeamModels();
            List<PrizeModel> prizes = GlobalConfig.PrizesFile.FullFilePath().LoadFile().ConvertToPrizeModels();
            List<MatchupModel> matchups = GlobalConfig.MatchupFile.FullFilePath().LoadFile().ConvertToMatchupModels();

            foreach (string line in lines)
            {
                string[] cols = line.Split(',');

                TournamentModel tm = new TournamentModel();
                int i = 0;

                tm.ID = int.Parse(cols[i++]);
                tm.TournamentName = cols[i++];
                tm.EntryFee = decimal.Parse(cols[i++]);

                if (cols[i].Length > 0)
                {
                    string[] teamIds = cols[i++].Split('|');

                    foreach (string id in teamIds)
                    {
                    tm.EnteredTeams.Add(teams.Where(x => x.ID == int.Parse(id)).First());
                    }

                }
                else { i++; }

                if (cols[i].Length > 0)
                {
                    string[] prizeIds = cols[i++].Split('|');
                
                    foreach (string id in prizeIds)
                    {
                        tm.Prizes.Add(prizes.Where(x => x.ID == int.Parse(id)).First());
                    }

                }
                else { i++; }

                if (cols[i].Length>0)
                {
                    string[] rounds = cols[i++].Split('|');

                    foreach (string round in rounds)
                    {
                        string[] msText = round.Split('^');
                        List<MatchupModel> ms = new List<MatchupModel>();

                        foreach (string matchupModelTextId in msText)
                        {
                            ms.Add(matchups.Where(x => x.ID == int.Parse(matchupModelTextId)).First());
                        }
                        tm.Rounds.Add(ms);
                    }
                }
                else { i++; }

                output.Add(tm);
            }
            return output;
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
        private static string ConvertTeamListToString(List<TeamModel> teams)
        {
            string output = "";

            if (teams.Count == 0)
            {
                return "";
            }

            foreach (TeamModel t in teams)
            {
                output += $"{t.ID}|";
            }
            output = output.Substring(0, output.Length - 1);

            return output;
        }
        private static string ConvertPrizeListToString(List<PrizeModel> prizes)
        {
            string output = "";

            if (prizes.Count == 0)
            {
                return "";
            }

            foreach (PrizeModel p in prizes)
            {
                output += $"{p.ID}|";
            }
            output = output.Substring(0, output.Length - 1);

            return output;
        }
        private static string ConvertRoundListToString(List<List<MatchupModel>> rounds)
        {
            string output = "";

            if (rounds.Count == 0)
            {
                return "";
            }

            foreach (List<MatchupModel> r in rounds)
            {
                output += $"{ConvertMatchupListToString(r)}|";
            }
            output = output.Substring(0, output.Length - 1);

            return output;
        }
        private static string ConvertMatchupListToString(List<MatchupModel> matchups)
        {
            string output = "";

            if (matchups.Count == 0)
            {
                return "";
            }

            foreach (MatchupModel m in matchups)
            {
                output += $"{m.ID}^";
            }
            output = output.Substring(0, output.Length - 1);

            return output;
        }
        private static string ConvertMatchupEntryListToString(List<MatchupEntryModel> matchups)
        {
            string output = "";

            if (matchups.Count == 0)
            {
                return "";
            }

            foreach (MatchupEntryModel me in matchups)
            {
                output += $"{me.ID}|";
            }
            output = output.Substring(0, output.Length - 1);

            return output;
        }
        public static List<MatchupModel> ConvertToMatchupModels(this List<string> lines)
        {
            List<MatchupModel> output = new List<MatchupModel>();

            foreach (string line in lines)
            {
                string[] cols = line.Split(',');
                int i = 0;
                MatchupModel p = new MatchupModel();
                p.ID = int.Parse(cols[i++]);
                p.Entries = ConvertStringToMatchupEntryModel(cols[i++]);

                if (cols[i].Length == 0)
                {
                    p.Winner = null;
                    i++;
                }else
                {
                p.Winner = LookupTeamById(int.Parse(cols[i++]));
                }
                p.MatchupRound = int.Parse(cols[i++]);
                output.Add(p);
            }
            return output;
        }
        public static List<MatchupEntryModel> ConvertToMatchupEntryModels(this List<string> lines)
        {
            List<MatchupEntryModel> output = new List<MatchupEntryModel>();

            foreach (string line in lines)
            {
                string[] cols = line.Split(',');

                MatchupEntryModel me = new MatchupEntryModel();
                me.ID = int.Parse(cols[0]);

                // problem started here, Tim used a different way to fix null error
                // and later on added lookupteambyid function.
                // i skipped those parts because mine was "working fine"

                if (cols[1].Length == 0)
                {
                    me.TeamCompeting = null;
                }
                else
                {
                    me.TeamCompeting = LookupTeamById(int.Parse(cols[1]));
                }

                me.Score = double.Parse(cols[2]);

                int parentId = 0;
                if (int.TryParse(cols[3], out parentId))
                {
                   me.ParentMatchup = LookupMatchupById(parentId);
                }
                else
                {
                    me.ParentMatchup = null;
                }

                output.Add(me);
            }
            return output;
        }
        private static List<MatchupEntryModel> ConvertStringToMatchupEntryModel(string input)
        {
            string[] ids = input.Split('|');

            List<MatchupEntryModel> output = new List<MatchupEntryModel>();
            List<string> entries = GlobalConfig.MatchupEntryFile.FullFilePath().LoadFile();
            List<string> matchingEntries = new List<string>();
            foreach (string id in ids)
            {
                foreach (string entry in entries)
                {
                    string[] cols = entry.Split(',');
                    if (cols[0] == id)
                    {
                        matchingEntries.Add(entry);
                    }
                }
            }
            output = matchingEntries.ConvertToMatchupEntryModels();
            return output;
        }
        #endregion

        #region SaveTo

        public static void SaveToPrizeFile(this List<PrizeModel> models)
        {
            List<string> lines = new List<string>();
            
            foreach(PrizeModel p in models)
            {
                lines.Add($"{p.ID},{p.PlaceNumber},"+
                    $"{p.PlaceName},{p.PrizeAmount},"+
                    $"{p.PrizePercentage}");
            }

            File.WriteAllLines(GlobalConfig.PrizesFile.FullFilePath(), lines);
        }
        public static void SaveToPeopleFile(this List<PersonModel> models)
        {
            List<string> lines = new List<string>();

            foreach (PersonModel p in models)
            {
                lines.Add($"{p.ID},{p.FirstName},"+
                    $"{p.Lastname},{p.EmailAddress},"+
                    $"{p.CellPhoneNumber}");
            }

            File.WriteAllLines(GlobalConfig.PeopleFile.FullFilePath(), lines);
        }
        public static void SaveToTeamFile(this List<TeamModel> models)
        {
            List<string> lines = new List<string>();

            foreach (TeamModel t in models)
            {
                lines.Add($"{t.ID},{t.TeamName},{ConvertPeopleListToString(t.TeamMembers)}");
            }

            File.WriteAllLines(GlobalConfig.TeamFile.FullFilePath(), lines);
        }
        public static void SaveToTournamentFile(this List<TournamentModel> models)
        {
            List<string> lines = new List<string>();

            foreach (TournamentModel tm in models)
            {
                lines.Add($"{tm.ID}," +
                    $"{tm.TournamentName}," +
                    $"{tm.EntryFee}," +
                    $"{ConvertTeamListToString(tm.EnteredTeams)}," +
                    $"{ConvertPrizeListToString(tm.Prizes)},"+
                    $"{ConvertRoundListToString(tm.Rounds)}");
            }

            File.WriteAllLines(GlobalConfig.TournamentFile.FullFilePath(), lines);

        }
        public static void SaveRoundsToFile(this TournamentModel model)
        {
            foreach (List<MatchupModel> round in model.Rounds)
            {
                foreach (MatchupModel matchup in round)
                {
                    matchup.SaveMatchupToFile();

                }
            }
        }
        public static void SaveMatchupToFile(this MatchupModel matchup)
        {
            List<MatchupModel> matchups = GlobalConfig.MatchupFile.FullFilePath().LoadFile().ConvertToMatchupModels();

            int currentId = 1;
            if (matchups.Count>0)
            {
                currentId = matchups.OrderByDescending(x => x.ID).First().ID + 1;
            }

            matchup.ID = currentId;
            matchups.Add(matchup);

            foreach (MatchupEntryModel entry in matchup.Entries)
            {
                entry.SaveEntryToFile();
            }
            List<string> lines = new List<string>();

                string winner = "";
            foreach (MatchupModel m in matchups)
            {

                if (m.Winner !=null)
                {
                    winner = m.Winner.ID.ToString();
                }
                lines.Add($"{m.ID},{ConvertMatchupEntryListToString(m.Entries)},{winner},{m.MatchupRound}");
            }

            File.WriteAllLines(GlobalConfig.MatchupFile.FullFilePath(), lines);

        }
        public static void SaveEntryToFile(this MatchupEntryModel entry)
        {
            List<MatchupEntryModel> entries = GlobalConfig.MatchupEntryFile.FullFilePath().LoadFile().ConvertToMatchupEntryModels();

            int currentId = 1;

            if (entries.Count>0)
            {
                currentId = entries.OrderByDescending(x => x.ID).First().ID+1;
            }
            
            entry.ID = currentId;
            entries.Add(entry);

            List<string> lines = new List<string>();
            
                string parent ="";
                string teamCompeting ="";
            foreach (MatchupEntryModel e in entries)
            {

                if (e.ParentMatchup != null)
                {
                    parent = e.ParentMatchup.ID.ToString();
                }

                if (e.TeamCompeting!= null)
                {
                    teamCompeting = e.TeamCompeting.ID.ToString();
                }
                lines.Add($"{e.ID},{teamCompeting},{e.Score},{parent}");
            }

            File.WriteAllLines(GlobalConfig.MatchupEntryFile.FullFilePath(), lines);


        }

        #endregion

      
        public static void UpdateMatchupToFile( this MatchupModel matchup)
        {
            List<MatchupModel> matchups = GlobalConfig.MatchupFile.FullFilePath().LoadFile().ConvertToMatchupModels();

            MatchupModel oldMatchup = new MatchupModel();
            foreach (MatchupModel m in matchups)
            {
                if (m.ID == matchup.ID )
                {
                    oldMatchup = m;
                }
            }

            matchups.Remove(oldMatchup);
            matchups.Add(matchup);

            foreach (MatchupEntryModel entry in matchup.Entries)
            {
                entry.UpdateEntryToFile();
            }
            List<string> lines = new List<string>();

            foreach (MatchupModel m in matchups)
            {
                string winner = "";

                if (m.Winner != null)
                {
                    winner = m.Winner.ID.ToString();
                }
                lines.Add($"{m.ID},{ConvertMatchupEntryListToString(m.Entries)},{winner},{m.MatchupRound}");
            }

            File.WriteAllLines(GlobalConfig.MatchupFile.FullFilePath(), lines);
        }


        public static void UpdateEntryToFile(this MatchupEntryModel entry)
        {
            List<MatchupEntryModel> entries = GlobalConfig.MatchupEntryFile.FullFilePath().LoadFile().ConvertToMatchupEntryModels();

            MatchupEntryModel oldEntry = new MatchupEntryModel();

            foreach (MatchupEntryModel e in entries)
            {
                if (e.ID == entry.ID)
                {
                    oldEntry = e;
                }
            }

            entries.Remove(oldEntry);
            entries.Add(entry);

            List<string> lines = new List<string>();

            foreach (MatchupEntryModel e in entries)
            {

                string parent = "";
                if (e.ParentMatchup != null)
                {
                    parent = e.ParentMatchup.ID.ToString();
                }

                string teamCompeting = "";
                if (e.TeamCompeting != null)
                {
                    teamCompeting = e.TeamCompeting.ID.ToString();
                }
                lines.Add($"{e.ID},{teamCompeting},{e.Score},{parent}");
            }

            File.WriteAllLines(GlobalConfig.MatchupEntryFile.FullFilePath(), lines);


        }


        private static MatchupModel LookupMatchupById(int id)
        {

            List<string> matchups = GlobalConfig.MatchupFile.FullFilePath().LoadFile();

            foreach (string matchup in matchups)
            {
                string[] cols = matchup.Split(',');

                if (cols[0] == id.ToString())
                {
                    List<string> matchingMatchups = new List<string>();
                    matchingMatchups.Add(matchup);
                    return matchingMatchups.ConvertToMatchupModels().First();
                }
            }
            return null;

        }
        private static TeamModel LookupTeamById(int id)
        {
            List<string> teams = GlobalConfig.TeamFile.FullFilePath().LoadFile();

            foreach (string team in teams)
            {
                string[] cols = team.Split(',');

                if (cols[0] == id.ToString())
                {
                    List<string> matchingTeams = new List<string>();
                    matchingTeams.Add(team);
                    return matchingTeams.ConvertToTeamModels().First();
                }
            }
            return null;


        }


    }
}
