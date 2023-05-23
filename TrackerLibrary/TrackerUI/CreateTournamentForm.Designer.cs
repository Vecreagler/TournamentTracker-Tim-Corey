
namespace TrackerUI
{
    partial class CreateTournamentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.headerLabel = new System.Windows.Forms.Label();
            this.tournamentNameValue = new System.Windows.Forms.TextBox();
            this.tournamentNameLabel = new System.Windows.Forms.Label();
            this.entryFeeLabel = new System.Windows.Forms.Label();
            this.entryFeeValue = new System.Windows.Forms.TextBox();
            this.selectTeamLabel = new System.Windows.Forms.Label();
            this.selectTeamDropdown = new System.Windows.Forms.ComboBox();
            this.createNewTeamLink = new System.Windows.Forms.LinkLabel();
            this.addTeamButton = new System.Windows.Forms.Button();
            this.createPrizeButton = new System.Windows.Forms.Button();
            this.tournamentTeamsListbox = new System.Windows.Forms.ListBox();
            this.tournamentPlayerListLabel = new System.Windows.Forms.Label();
            this.removeSelectedTeamsButton = new System.Windows.Forms.Button();
            this.removeSelectedPrizeButton = new System.Windows.Forms.Button();
            this.tournamentPrizeListLabel = new System.Windows.Forms.Label();
            this.prizesListbox = new System.Windows.Forms.ListBox();
            this.createTournamentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI Light", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.headerLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.headerLabel.Location = new System.Drawing.Point(14, 19);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(368, 59);
            this.headerLabel.TabIndex = 29;
            this.headerLabel.Text = "Create Tournament";
            // 
            // tournamentNameValue
            // 
            this.tournamentNameValue.Location = new System.Drawing.Point(27, 164);
            this.tournamentNameValue.MinimumSize = new System.Drawing.Size(200, 4);
            this.tournamentNameValue.Name = "tournamentNameValue";
            this.tournamentNameValue.Size = new System.Drawing.Size(364, 43);
            this.tournamentNameValue.TabIndex = 38;
            // 
            // tournamentNameLabel
            // 
            this.tournamentNameLabel.AutoSize = true;
            this.tournamentNameLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tournamentNameLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.tournamentNameLabel.Location = new System.Drawing.Point(27, 110);
            this.tournamentNameLabel.Name = "tournamentNameLabel";
            this.tournamentNameLabel.Size = new System.Drawing.Size(264, 41);
            this.tournamentNameLabel.TabIndex = 37;
            this.tournamentNameLabel.Text = "Tournament Name";
            // 
            // entryFeeLabel
            // 
            this.entryFeeLabel.AutoSize = true;
            this.entryFeeLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.entryFeeLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.entryFeeLabel.Location = new System.Drawing.Point(27, 250);
            this.entryFeeLabel.Name = "entryFeeLabel";
            this.entryFeeLabel.Size = new System.Drawing.Size(140, 41);
            this.entryFeeLabel.TabIndex = 39;
            this.entryFeeLabel.Text = "Entry Fee";
            // 
            // entryFeeValue
            // 
            this.entryFeeValue.Location = new System.Drawing.Point(189, 250);
            this.entryFeeValue.Name = "entryFeeValue";
            this.entryFeeValue.Size = new System.Drawing.Size(139, 43);
            this.entryFeeValue.TabIndex = 40;
            this.entryFeeValue.Text = "0";
            // 
            // selectTeamLabel
            // 
            this.selectTeamLabel.AutoSize = true;
            this.selectTeamLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.selectTeamLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.selectTeamLabel.Location = new System.Drawing.Point(27, 331);
            this.selectTeamLabel.Name = "selectTeamLabel";
            this.selectTeamLabel.Size = new System.Drawing.Size(175, 41);
            this.selectTeamLabel.TabIndex = 41;
            this.selectTeamLabel.Text = "Select Team";
            // 
            // selectTeamDropdown
            // 
            this.selectTeamDropdown.FormattingEnabled = true;
            this.selectTeamDropdown.Location = new System.Drawing.Point(27, 375);
            this.selectTeamDropdown.Name = "selectTeamDropdown";
            this.selectTeamDropdown.Size = new System.Drawing.Size(364, 45);
            this.selectTeamDropdown.TabIndex = 42;
            // 
            // createNewTeamLink
            // 
            this.createNewTeamLink.AutoSize = true;
            this.createNewTeamLink.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.createNewTeamLink.Location = new System.Drawing.Point(229, 341);
            this.createNewTeamLink.Name = "createNewTeamLink";
            this.createNewTeamLink.Size = new System.Drawing.Size(162, 28);
            this.createNewTeamLink.TabIndex = 43;
            this.createNewTeamLink.TabStop = true;
            this.createNewTeamLink.Text = "Create New Team";
            this.createNewTeamLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.createNewTeamLink_LinkClicked);
            // 
            // addTeamButton
            // 
            this.addTeamButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(155)))));
            this.addTeamButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.addTeamButton.FlatAppearance.BorderSize = 2;
            this.addTeamButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(182)))));
            this.addTeamButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.addTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addTeamButton.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addTeamButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.addTeamButton.Location = new System.Drawing.Point(101, 448);
            this.addTeamButton.Name = "addTeamButton";
            this.addTeamButton.Size = new System.Drawing.Size(204, 71);
            this.addTeamButton.TabIndex = 44;
            this.addTeamButton.Text = "Add Team";
            this.addTeamButton.UseVisualStyleBackColor = false;
            this.addTeamButton.Click += new System.EventHandler(this.addTeamButton_Click);
            // 
            // createPrizeButton
            // 
            this.createPrizeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(253)))), ((int)(((byte)(209)))));
            this.createPrizeButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createPrizeButton.FlatAppearance.BorderSize = 2;
            this.createPrizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(182)))));
            this.createPrizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.createPrizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createPrizeButton.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.createPrizeButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.createPrizeButton.Location = new System.Drawing.Point(101, 540);
            this.createPrizeButton.Name = "createPrizeButton";
            this.createPrizeButton.Size = new System.Drawing.Size(204, 71);
            this.createPrizeButton.TabIndex = 45;
            this.createPrizeButton.Text = "Create Prize";
            this.createPrizeButton.UseVisualStyleBackColor = false;
            this.createPrizeButton.Click += new System.EventHandler(this.createPrizeButton_Click);
            // 
            // tournamentTeamsListbox
            // 
            this.tournamentTeamsListbox.FormattingEnabled = true;
            this.tournamentTeamsListbox.ItemHeight = 37;
            this.tournamentTeamsListbox.Location = new System.Drawing.Point(570, 154);
            this.tournamentTeamsListbox.Name = "tournamentTeamsListbox";
            this.tournamentTeamsListbox.Size = new System.Drawing.Size(436, 189);
            this.tournamentTeamsListbox.TabIndex = 46;
            // 
            // tournamentPlayerListLabel
            // 
            this.tournamentPlayerListLabel.AutoSize = true;
            this.tournamentPlayerListLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tournamentPlayerListLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.tournamentPlayerListLabel.Location = new System.Drawing.Point(570, 110);
            this.tournamentPlayerListLabel.Name = "tournamentPlayerListLabel";
            this.tournamentPlayerListLabel.Size = new System.Drawing.Size(222, 41);
            this.tournamentPlayerListLabel.TabIndex = 47;
            this.tournamentPlayerListLabel.Text = "Teams / Players";
            // 
            // removeSelectedTeamsButton
            // 
            this.removeSelectedTeamsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.removeSelectedTeamsButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.removeSelectedTeamsButton.FlatAppearance.BorderSize = 2;
            this.removeSelectedTeamsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(182)))));
            this.removeSelectedTeamsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.removeSelectedTeamsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeSelectedTeamsButton.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.removeSelectedTeamsButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.removeSelectedTeamsButton.Location = new System.Drawing.Point(1032, 201);
            this.removeSelectedTeamsButton.Name = "removeSelectedTeamsButton";
            this.removeSelectedTeamsButton.Size = new System.Drawing.Size(170, 95);
            this.removeSelectedTeamsButton.TabIndex = 48;
            this.removeSelectedTeamsButton.Text = "Remove Selected";
            this.removeSelectedTeamsButton.UseVisualStyleBackColor = false;
            this.removeSelectedTeamsButton.Click += new System.EventHandler(this.removeSelectedTeamsButton_Click);
            // 
            // removeSelectedPrizeButton
            // 
            this.removeSelectedPrizeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.removeSelectedPrizeButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.removeSelectedPrizeButton.FlatAppearance.BorderSize = 2;
            this.removeSelectedPrizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(182)))));
            this.removeSelectedPrizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.removeSelectedPrizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeSelectedPrizeButton.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.removeSelectedPrizeButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.removeSelectedPrizeButton.Location = new System.Drawing.Point(1032, 447);
            this.removeSelectedPrizeButton.Name = "removeSelectedPrizeButton";
            this.removeSelectedPrizeButton.Size = new System.Drawing.Size(170, 95);
            this.removeSelectedPrizeButton.TabIndex = 51;
            this.removeSelectedPrizeButton.Text = "Remove Selected";
            this.removeSelectedPrizeButton.UseVisualStyleBackColor = false;
            this.removeSelectedPrizeButton.Click += new System.EventHandler(this.removeSelectedPrizeButton_Click);
            // 
            // tournamentPrizeListLabel
            // 
            this.tournamentPrizeListLabel.AutoSize = true;
            this.tournamentPrizeListLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tournamentPrizeListLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.tournamentPrizeListLabel.Location = new System.Drawing.Point(570, 356);
            this.tournamentPrizeListLabel.Name = "tournamentPrizeListLabel";
            this.tournamentPrizeListLabel.Size = new System.Drawing.Size(95, 41);
            this.tournamentPrizeListLabel.TabIndex = 50;
            this.tournamentPrizeListLabel.Text = "Prizes";
            // 
            // prizesListbox
            // 
            this.prizesListbox.FormattingEnabled = true;
            this.prizesListbox.ItemHeight = 37;
            this.prizesListbox.Location = new System.Drawing.Point(570, 400);
            this.prizesListbox.Name = "prizesListbox";
            this.prizesListbox.Size = new System.Drawing.Size(436, 189);
            this.prizesListbox.TabIndex = 49;
            // 
            // createTournamentButton
            // 
            this.createTournamentButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(253)))), ((int)(((byte)(207)))));
            this.createTournamentButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createTournamentButton.FlatAppearance.BorderSize = 2;
            this.createTournamentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(182)))));
            this.createTournamentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.createTournamentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createTournamentButton.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.createTournamentButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.createTournamentButton.Location = new System.Drawing.Point(189, 653);
            this.createTournamentButton.Name = "createTournamentButton";
            this.createTournamentButton.Size = new System.Drawing.Size(817, 71);
            this.createTournamentButton.TabIndex = 52;
            this.createTournamentButton.Text = "Create Tournament";
            this.createTournamentButton.UseVisualStyleBackColor = false;
            this.createTournamentButton.Click += new System.EventHandler(this.createTournamentButton_Click);
            // 
            // CreateTournamentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1223, 764);
            this.Controls.Add(this.createTournamentButton);
            this.Controls.Add(this.removeSelectedPrizeButton);
            this.Controls.Add(this.tournamentPrizeListLabel);
            this.Controls.Add(this.prizesListbox);
            this.Controls.Add(this.removeSelectedTeamsButton);
            this.Controls.Add(this.tournamentPlayerListLabel);
            this.Controls.Add(this.tournamentTeamsListbox);
            this.Controls.Add(this.createPrizeButton);
            this.Controls.Add(this.addTeamButton);
            this.Controls.Add(this.createNewTeamLink);
            this.Controls.Add(this.selectTeamDropdown);
            this.Controls.Add(this.selectTeamLabel);
            this.Controls.Add(this.entryFeeValue);
            this.Controls.Add(this.entryFeeLabel);
            this.Controls.Add(this.tournamentNameValue);
            this.Controls.Add(this.tournamentNameLabel);
            this.Controls.Add(this.headerLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "CreateTournamentForm";
            this.Text = "Create Tournament";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.TextBox tournamentNameValue;
        private System.Windows.Forms.Label tournamentNameLabel;
        private System.Windows.Forms.Label entryFeeLabel;
        private System.Windows.Forms.TextBox entryFeeValue;
        private System.Windows.Forms.Label selectTeamLabel;
        private System.Windows.Forms.ComboBox selectTeamDropdown;
        private System.Windows.Forms.LinkLabel createNewTeamLink;
        private System.Windows.Forms.Button addTeamButton;
        private System.Windows.Forms.Button createPrizeButton;
        private System.Windows.Forms.ListBox tournamentTeamsListbox;
        private System.Windows.Forms.Label tournamentPlayerListLabel;
        private System.Windows.Forms.Button removeSelectedTeamsButton;
        private System.Windows.Forms.Button removeSelectedPrizeButton;
        private System.Windows.Forms.Label tournamentPrizeListLabel;
        private System.Windows.Forms.ListBox prizesListbox;
        private System.Windows.Forms.Button createTournamentButton;
    }
}