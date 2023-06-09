﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using TrackerLibrary.Models;




namespace TrackerLibrary
{
    public static class TournamentLogic
    {
        public static void CreateRounds(TournamentModel model)
        {
            List<TeamModel> randomizedTeams = RandomizeTeamOrder(model.EnteredTeams);
            int rounds = FindNumberOfRounds(randomizedTeams.Count);
            int byes = NumberOfByes(rounds, randomizedTeams.Count);

            model.Rounds.Add(CreateFirstRound(byes, randomizedTeams));

            CreateOtherRounds(model, rounds);

            
        }

        private static void CreateOtherRounds(TournamentModel model, int rounds)
        {
            int round = 2;
            List<MatchupModel> previousRound = model.Rounds[0];
            List<MatchupModel> currRound = new List<MatchupModel>();
            MatchupModel currMatchup = new MatchupModel();
            MatchupModel lastMatchup = new MatchupModel();


            while (round <= rounds)
            {
                foreach (MatchupModel match in previousRound)
                {
                    currMatchup.Entries.Add(new MatchupEntryModel { ParentMatchup = match });

                    if (currMatchup.Entries.Count > 1)
                    {
                        currMatchup.MatchupRound = round;
                        currRound.Add(currMatchup);
                        currMatchup = new MatchupModel();
                    }

                   
                }
                if (previousRound.Count % 2 > 0 && previousRound.Last().Entries.TrueForAll(x => x.TeamCompeting != null))
                {
                    lastMatchup.Entries.Add(new MatchupEntryModel { ParentMatchup = previousRound.LastOrDefault() });
                    currRound.Add(lastMatchup);

                }

                model.Rounds.Add(currRound);
                previousRound = currRound;

                currRound = new List<MatchupModel>();
                round += 1;

            }

            //if (byes>0)
            //{
            //    MatchupModel matchup = new MatchupModel();
                
            //}
        }

        private static List<MatchupModel>CreateFirstRound(int byes, List<TeamModel> teams)
        {
            List<MatchupModel> output = new List<MatchupModel>();
            MatchupModel curr = new MatchupModel();

            foreach (TeamModel team in teams)
            {
                curr.Entries.Add(new MatchupEntryModel { TeamCompeting = team });

                if (byes > 0 || curr.Entries.Count > 1)
                {
                    curr.MatchupRound = 1;
                    output.Add(curr);
                    curr = new MatchupModel();

                    if(byes > 0)
                    {
                        byes -= 1;
                    }
                }
            }
        return output;
        }

        private static int NumberOfByes(int rounds, int numberOfTeams)
        {
            rounds += 1;
            int totalTeams = 2 * rounds;

            return totalTeams - numberOfTeams;

        }

        private static int FindNumberOfRounds(int teamCount)
        {
            int output;
            double log = Math.Log(teamCount, 2);
            output = (int)Math.Ceiling(log);

            return output;

        }

        private static List<TeamModel> RandomizeTeamOrder(List<TeamModel> teams)
        {
            return teams.OrderBy(x => Guid.NewGuid()).ToList();
        }

        public static void UpdateTournamentResults(TournamentModel model)
        {
            int startingRound = model.CheckCurrentRound();
            List<MatchupModel> toScore = new List<MatchupModel>();

            foreach (List<MatchupModel> round in model.Rounds)
            {
                foreach (MatchupModel rm in round)
                {
                    if ( rm.Entries.Any(x => x.Score != 0) || rm.Entries.Count == 1)
                        {
                        toScore.Add(rm);
                    }
                }
            }
            MarkWinnerInMatchups(toScore);

            AdvancedWinners(toScore,model);

            toScore.ForEach(x => GlobalConfig.Connection.UpdateMatchup(x));

            int endingRound = model.CheckCurrentRound();
            if (endingRound > startingRound)
            {
                model.AlertUsersToNewRound();
            }


            //foreach (MatchupModel x in toScore)
            //{
            //    GlobalConfig.Connection.UpdateMatchup(x);
            //}
        }

        public static void AlertUsersToNewRound(this TournamentModel model)
        {
            int currentRoundNumber = model.CheckCurrentRound();
            List<MatchupModel> currentRound = model.Rounds.Where(x => x.First().MatchupRound == currentRoundNumber).First();

            foreach (MatchupModel matchup in currentRound)
            {
                foreach (MatchupEntryModel me in matchup.Entries)
                {
                    foreach (PersonModel p in me.TeamCompeting.TeamMembers)
                    {
                        AlertPlayerToNewRound(p, me.TeamCompeting.TeamName, matchup.Entries.Where(x => x.TeamCompeting == me.TeamCompeting).FirstOrDefault());
                    }
                }
            }
        }

        public static void AlertPlayerToNewRound(PersonModel p, string teamName, MatchupEntryModel competitor)
        {
            if (p.EmailAddress.Length == 0)
            {
                return;
            }

            string sender = "";
            string to = "";
            string recpient = "";
            string subject = "";
            StringBuilder body = new StringBuilder();
            
            // I'm not going to touch these since emailing doesnt work anyways

            if (competitor != null)
            {
                subject = $"You have a new matchup with { competitor.TeamCompeting.TeamName  } !";

                body.Append("Hello ");
                body.Append(p.FirstName);
                body.AppendLine(", ");
                body.AppendLine();
                body.AppendLine("You have a new matchup !");
                body.Append("Competitor: ");
                body.Append(competitor.TeamCompeting.TeamName);
                body.AppendLine();
                body.AppendLine();
                body.AppendLine("Have a great tournament !");
                body.AppendLine("~Tournament Tracker");
            }
            else
            {
                subject = "You have a bye this round !";

                body.Append("Hello ");
                body.Append(p.FirstName);
                body.AppendLine(", ");
                body.AppendLine();
                body.AppendLine("Enjoy your bye round. ");
                body.AppendLine("~Tournament Tracker");
            }
            sender = GlobalConfig.AppKeyLookup("senderEmail");
            to = p.EmailAddress;


            EmailLogic.SendEmail(sender, to, subject, body.ToString());

            
        }

            private static int CheckCurrentRound(this TournamentModel model) 
        {
            int output = 1;

            foreach (List<MatchupModel> round in model.Rounds)
            {
                if (round.All( x => x.Winner != null) )
                {
                    output += 1;
                }
                else
                {
                    return output;
                }
            }

            CompleteTournament(model);
            return output-1;

        }

        private static void CompleteTournament(TournamentModel model)
        {
            GlobalConfig.Connection.CompleteTournament(model);
            TeamModel winners = model.Rounds.Last().First().Winner;
            TeamModel runnerUp = model.Rounds.Last().First().Entries.Where(x => x.TeamCompeting != winners).First().TeamCompeting;

            decimal winnerPrize = 0;
            decimal runnerUpPrize = 0;

            if (model.Prizes.Count > 0)
            {
                decimal totalIncome = model.EnteredTeams.Count * model.EntryFee;

                PrizeModel firstPlacePrize = model.Prizes.Where(x => x.PlaceNumber == 1).FirstOrDefault();
                PrizeModel secondPlacePrize = model.Prizes.Where(x => x.PlaceNumber == 2).FirstOrDefault();

                if (firstPlacePrize != null)
                {
                    winnerPrize = firstPlacePrize.CalculatePrizePayout(totalIncome);
                }

                if (secondPlacePrize != null)
                {
                    winnerPrize = secondPlacePrize.CalculatePrizePayout(totalIncome);
                }

                model.CompleteTournament();

            }
        }

        private static decimal CalculatePrizePayout(this PrizeModel prize, decimal totalIncome)
        {
            decimal output = 0;

            if (prize.PrizeAmount > 0)
            {
                output = prize.PrizeAmount;
            }
            else
            {
                output = Decimal.Multiply(totalIncome, Convert.ToDecimal(prize.PrizePercentage / 100));
            }

            return output;
        }

        private static void AdvancedWinners(List<MatchupModel> models , TournamentModel tournament)
        {
            foreach (MatchupModel m in models)
            {
                foreach (List<MatchupModel> round in tournament.Rounds)
                {
                    foreach (MatchupModel rm in round)
                    {
                        foreach (MatchupEntryModel me in rm.Entries)
                        {
                            if (me.ParentMatchup != null)
                            {
                                if (me.ParentMatchup.ID == m.ID)
                                {
                                    me.TeamCompeting = m.Winner;
                                    GlobalConfig.Connection.UpdateMatchup(rm);
                                }

                            }
                        }
                    }
                }
            }
        }

        private static void MarkWinnerInMatchups(List<MatchupModel> models)
        {
            string greaterWins = ConfigurationManager.AppSettings["greaterWins"];

            foreach (MatchupModel m in models)
            {
                if (m.Entries.Count == 1)
                {
                    m.Winner = m.Entries[0].TeamCompeting;
                    continue;
                }

                if (greaterWins == "0")
                {
                    if (m.Entries[0].Score < m.Entries[1].Score)
                    {
                        m.Winner = m.Entries[0].TeamCompeting;
                    }
                    else if (m.Entries[1].Score < m.Entries[0].Score)
                    {
                        m.Winner = m.Entries[1].TeamCompeting;
                    }
                    else 
                    {
                        throw new Exception("It's a tie and rematch is needed for these teams.");
                    }
                }
                else
                {
                    if (m.Entries[0].Score > m.Entries[1].Score)
                    {
                        m.Winner = m.Entries[0].TeamCompeting;
                    }
                    else if (m.Entries[1].Score > m.Entries[0].Score)
                    {
                        m.Winner = m.Entries[1].TeamCompeting;
                    }
                    else
                    {
                        throw new Exception("It's a tie and rematch is needed for these teams.");
                    }
                }

            }

        }
    }


}
