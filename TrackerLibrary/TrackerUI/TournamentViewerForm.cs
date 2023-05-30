using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TrackerLibrary.Models;
using System.Linq;
using TrackerLibrary;

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
            teamOneName.Text = "<Team One>";
            team1ScoreValue.Text = "";
            teamTwoName.Text = "<Team Two>";
            team2ScoreValue.Text = "";
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
                    selectedMatchups.Clear();
                    foreach (MatchupModel m in matchups)
                    {
                        if ( m.Winner == null || !unplayedOnlyCheckbox.Checked)
                        {   
                            selectedMatchups.Add(m);
                        }
                    }

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

        private void unplayedOnlyCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            teamOneName.Text = "<Team One>";
            team1ScoreValue.Text = "";
            teamTwoName.Text = "<Team Two>";
            team2ScoreValue.Text = "";
            LoadMatchups();
        }

        private void scoreButton_Click(object sender, EventArgs e)
        {
            MatchupModel m = (MatchupModel)matchupListbox.SelectedItem;
            double teamOneScore = 0;
            double teamTwoScore = 0;

            for (int i = 0; i < (m?.Entries?.Count ?? 0); i++)
            {
                if (i == 0)
                {
                    if (m?.Entries[0].TeamCompeting != null)
                    {
                        bool scoreValid = double.TryParse(team1ScoreValue.Text, out teamOneScore);

                        if (scoreValid)
                        {
                            m.Entries[0].Score = teamOneScore;
                        }
                        else
                        {
                            MessageBox.Show("Please enter a valid score for team one.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                    
                }

                if (i == 1)
                {
                    if (m.Entries[1].TeamCompeting != null)
                    {
                        bool scoreValid = double.TryParse(team2ScoreValue.Text, out teamTwoScore);

                        if (scoreValid)
                        {
                            m.Entries[1].Score = teamTwoScore;
                        }
                        else
                        {
                            MessageBox.Show("Please enter a valid score for team two.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                }
            }

            if (teamOneScore > teamTwoScore)
            {
                m.Winner = m.Entries[0].TeamCompeting;
            }
            else if (teamTwoScore > teamOneScore)
            {
                m.Winner = m.Entries[1].TeamCompeting;
            }
            else
            {
                MessageBox.Show("It's a tie and rematch is needed for these teams.");
            }


            foreach (List<MatchupModel> round in tournament.Rounds)
            {
                foreach (MatchupModel rm in round)
                {
                    foreach (MatchupEntryModel me in rm.Entries)
                    {
                        if (me.ParentMatchup?.ID  == m.ID)
                        {
                            me.TeamCompeting = m.Winner;
                            GlobalConfig.Connection.UpdateMatchup(rm);
                        }
                    }
                }
            }

            teamOneName.Text = "<Team One>";
            team1ScoreValue.Text = "";
            teamTwoName.Text = "<Team Two>";
            team2ScoreValue.Text = "";
            LoadMatchups();

            GlobalConfig.Connection.UpdateMatchup(m);

        }
    }
}
