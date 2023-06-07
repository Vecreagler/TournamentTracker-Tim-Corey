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


        public void CreatePerson(PersonModel model)
        {
            List<PersonModel> people = GlobalConfig.PeopleFile.FullFilePath().LoadFile().ConvertToPersonModels();

            int currentID = 1;
            if (people.Count > 0)
            {
                currentID = people.OrderByDescending(x => x.ID).First().ID + 1;
            }

            model.ID = currentID;

            people.Add(model);
            people.SaveToPeopleFile();
        }
        public void CreatePrize(PrizeModel model)
        {
            List<PrizeModel> prizes = GlobalConfig.PrizesFile.FullFilePath().LoadFile().ConvertToPrizeModels();

            int currentID = 1;
            if(prizes.Count >0)
            { 
                currentID = prizes.OrderByDescending(x => x.ID).First().ID + 1; 
            }
            // int maxId = prizes.Max(p => p.Id) better way to do that 

            model.ID = currentID;
            prizes.Add(model);

            prizes.SaveToPrizeFile();
        }
        public void CreateTeam(TeamModel model)
        {
            List<TeamModel> teams = GlobalConfig.TeamFile.FullFilePath().LoadFile().ConvertToTeamModels();
            
            int currentID = 1;
            if (teams.Count > 0)
            {
                currentID = teams.OrderByDescending(x => x.ID).First().ID + 1;
            }
            // int maxId = prizes.Max(p => p.Id) better way to do that 


            model.ID = currentID;
            teams.Add(model);

            teams.SaveToTeamFile();
        }
        public void CreateTournament(TournamentModel model)
        {
            List<TournamentModel> tournaments = GlobalConfig.TournamentFile
                .FullFilePath()
                .LoadFile()
                .ConvertToTournamentModels();

            int currentID = 1;
            if (tournaments.Count > 0)
            {
                currentID = tournaments.OrderByDescending(x => x.ID).First().ID + 1;
            }

            model.ID = currentID;

            model.SaveRoundsToFile();

            tournaments.Add(model);

            tournaments.SaveToTournamentFile();

            TournamentLogic.UpdateTournamentResults(model);

        }
        public void UpdateMatchup(MatchupModel model)
        {
            model.UpdateMatchupToFile();
        }
        public List<PersonModel> GetPerson_All()
        {
            return GlobalConfig.PeopleFile.FullFilePath().LoadFile().ConvertToPersonModels();
        }
        public List<TeamModel> GetTeam_All()
        {
           return GlobalConfig.TeamFile.FullFilePath().LoadFile().ConvertToTeamModels();
            
        }
        public List<TournamentModel> GetTournament_All()
        {
            return GlobalConfig.TournamentFile
                .FullFilePath().LoadFile()
                .ConvertToTournamentModels();
        }

        public void CompleteTournament(TournamentModel model)
        {
            List<TournamentModel> tournaments = GlobalConfig.TournamentFile
                .FullFilePath()
                .LoadFile()
                .ConvertToTournamentModels();

            tournaments.Remove(model);

            tournaments.SaveToTournamentFile();

            TournamentLogic.UpdateTournamentResults(model);
        }
    }
}
