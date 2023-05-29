using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TrackerLibrary.Models;
using System.Linq;

namespace TrackerUI
{
    public partial class TournamentViewerForm : Form
    {
        private TournamentModel tournament;
        List<int> rounds = new List<int>();
        List<MatchupModel> selectedMatchups = new List<MatchupModel>();

        // I didn't get the problem Tim encountered. 
        // I'm glad i don't need to rewrite all of these with binding lists
        public TournamentViewerForm(TournamentModel tournamentModel)
        {
            InitializeComponent();

            tournament = tournamentModel;

            LoadFormData();

            LoadRounds();

        }

        private void LoadFormData()
        {
            tournamentName.Text = tournament.TournamentName;
        }

        private void WireUpRoundsLists()
        {
            roundDropdown.DataSource = null;
            roundDropdown.DataSource = rounds;
        }

        private void WireUpMatchupsList()
        {
            matchupListbox.DataSource = null;
            matchupListbox.DataSource = selectedMatchups;
            matchupListbox.DisplayMember = "DisplayName";
        }

        private void LoadRounds()
        {
            rounds = new List<int>();
            
            rounds.Add(1);
            int currRound = 1;

            foreach (List<MatchupModel> matchups in tournament.Rounds) 
            {
                if (matchups.First().MatchupRound > currRound)
                {
                    currRound = matchups.First().MatchupRound;
                    rounds.Add(currRound);
                }

                WireUpRoundsLists();
            }
        }

        private void roundDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadMatchups();
        }

        private void LoadMatchups()
        {
            if (roundDropdown.SelectedItem == null)
            {
                return;
            }
            int round = (int)roundDropdown.SelectedItem;

            foreach (List<MatchupModel> matchups in tournament.Rounds)
            {
                if (matchups.First().MatchupRound == round)
                {
                    selectedMatchups = matchups;
                }
            }
            WireUpMatchupsList();
        }

        private void LoadMatchup() 
        {
            MatchupModel m = (MatchupModel)matchupListbox.SelectedItem;

            for (int i = 0; i < (m?.Entries?.Count?? 0); i++)
            {
                if (i == 0)
                {
                    if (m?.Entries[0].TeamCompeting != null)
                    {
                        teamOneName.Text = m.Entries[0].TeamCompeting.TeamName;
                        team1ScoreValue.Text = m.Entries[0].Score.ToString();

                        teamTwoName.Text = "< bye >";
                        team2ScoreValue.Text = "";
                    }
                    else
                    {
                        teamOneName.Text = "Not Set Yet";
                        team1ScoreValue.Text = "";
                    }
                }

                if (i == 1)
                {
                    if (m.Entries[1].TeamCompeting  != null)
                    {
                        teamTwoName.Text = m.Entries[1].TeamCompeting.TeamName;
                        team2ScoreValue.Text = m.Entries[1].Score.ToString();
                    }
                    else
                    {
                        teamTwoName.Text = "Not Set Yet";
                        team2ScoreValue.Text = "";
                    }
                }
            }

        }

        private void matchupListbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadMatchup();
        }
    }
}
