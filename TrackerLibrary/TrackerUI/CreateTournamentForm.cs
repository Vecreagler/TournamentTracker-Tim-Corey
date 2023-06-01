using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.Models;

namespace TrackerUI
{
    public partial class CreateTournamentForm : Form , IPrizeRequester , ITeamRequester
    {
        List<TeamModel> availableTeams = GlobalConfig.Connection.GetTeam_All();
        List<TeamModel> selectedTeams = new List<TeamModel>();
        List<PrizeModel> selectedPrizes = new List<PrizeModel>();
        public CreateTournamentForm()
        {
            InitializeComponent();

            InitializeLists();
        }

        private void InitializeLists()
        {
            selectTeamDropdown.DataSource = null;
            selectTeamDropdown.DataSource = availableTeams;
            selectTeamDropdown.DisplayMember = "TeamName";

            tournamentTeamsListbox.DataSource = null;
            tournamentTeamsListbox.DataSource = selectedTeams;
            tournamentTeamsListbox.DisplayMember = "TeamName";

            prizesListbox.DataSource = null;
            prizesListbox.DataSource = selectedPrizes;
            prizesListbox.DisplayMember = "PlaceName";
        }

        private void addTeamButton_Click(object sender, EventArgs e)
        {
            TeamModel t = (TeamModel)selectTeamDropdown.SelectedItem;

            if(t != null)
            {
                availableTeams.Remove(t);
                selectedTeams.Add(t);

                InitializeLists();
            }
        }

        private void createPrizeButton_Click(object sender, EventArgs e)
        {
            CreatePrizeForm form = new CreatePrizeForm(this);
            form.Show();
        }

        public void PrizeComplete(PrizeModel model)
        {
            selectedPrizes.Add(model);
            InitializeLists();
        }

        public void TeamComplete(TeamModel model)
        {
            availableTeams.Add(model);
            InitializeLists();
        }

        private void createNewTeamLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CreateTeamForm form = new CreateTeamForm(this);
           form.Show();
        }

        private void removeSelectedTeamsButton_Click(object sender, EventArgs e)
        {
            TeamModel t = (TeamModel)tournamentTeamsListbox.SelectedItem;

            if(t != null)
            {
                selectedTeams.Remove(t);
                availableTeams.Add(t);
                InitializeLists();
            }

        }

        private void removeSelectedPrizeButton_Click(object sender, EventArgs e)
        {
            PrizeModel p = (PrizeModel)prizesListbox.SelectedItem;

            if (p != null)
            {
                selectedPrizes.Remove(p);
                InitializeLists();
            }
        }

        private void createTournamentButton_Click(object sender, EventArgs e)
        {
            decimal fee = 0;

            bool feeAcceptable = decimal.TryParse(entryFeeValue.Text, out fee);

            if (!feeAcceptable)
            {
                MessageBox.Show("You need to enter a valid Entry Fee",
                    "Invalid Fee", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            TournamentModel tm = new TournamentModel();

            tm.TournamentName = tournamentNameValue.Text;
            tm.EntryFee = fee;
            
            tm.Prizes = selectedPrizes;
            tm.EnteredTeams = selectedTeams;


            TournamentLogic.CreateRounds(tm);
            
            GlobalConfig.Connection.CreateTournament(tm);

            

            TournamentViewerForm form = new TournamentViewerForm(tm);
            form.Show();
            this.Close();

        }
    }
}
