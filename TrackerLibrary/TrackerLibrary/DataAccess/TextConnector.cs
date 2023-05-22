using System;
using System.Collections.Generic;
using System.Text;
using TrackerLibrary.Models;
using TrackerLibrary.DataAccess.TextHelpers;
using System.Linq;

namespace TrackerLibrary.DataAccess
{
    public class TextConnector : IDataConnection
    {
        private const string PrizesFile = "PrizeModels.csv";

        private const string PeopleFile = "PersonModels.csv";

        private const string TeamFile = "TeamModels.csv";


        public PersonModel CreatePerson(PersonModel model)
        {
            List<PersonModel> people = PeopleFile.FullFilePath().LoadFile().ConvertToPersonModels();

            int currentID = 1;
            if (people.Count > 0)
            {
                currentID = people.OrderByDescending(x => x.ID).First().ID + 1;
            }

            model.ID = currentID;

            people.Add(model);
            people.SaveToPeopleFile(PeopleFile);
            return model;
        }

        public PrizeModel CreatePrize(PrizeModel model)
        {

            List<PrizeModel> prizes = PrizesFile.FullFilePath().LoadFile().ConvertToPrizeModels();

            int currentID = 1;
            if(prizes.Count >0)
            { 
                currentID = prizes.OrderByDescending(x => x.ID).First().ID + 1; 
            }
            // int maxId = prizes.Max(p => p.Id) better way to do that 


            model.ID = currentID;
            prizes.Add(model);

            prizes.SaveToPrizeFile(PrizesFile);

            return model;

        }


        public List<PersonModel> GetPerson_All()
        {
            return PeopleFile.FullFilePath().LoadFile().ConvertToPersonModels();
        }
        public TeamModel CreateTeam(TeamModel model)
        {
            List<TeamModel> teams = TeamFile.FullFilePath().LoadFile().ConvertToTeamModels(PeopleFile);
            
            int currentID = 1;
            if (teams.Count > 0)
            {
                currentID = teams.OrderByDescending(x => x.ID).First().ID + 1;
            }
            // int maxId = prizes.Max(p => p.Id) better way to do that 


            model.ID = currentID;
            teams.Add(model);

            teams.SaveToTeamFile(TeamFile);

            return model;
        }

        public List<TeamModel> GetTeam_All()
        {
            throw new NotImplementedException();
        }
    }
}
