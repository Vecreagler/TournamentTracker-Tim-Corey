
namespace TrackerUI
{
    partial class TournamentViewerForm
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
            this.scoreButton = new System.Windows.Forms.Button();
            this.versusLabel = new System.Windows.Forms.Label();
            this.team2ScoreValue = new System.Windows.Forms.TextBox();
            this.team2ScoreLabel = new System.Windows.Forms.Label();
            this.teamTwoName = new System.Windows.Forms.Label();
            this.team1ScoreValue = new System.Windows.Forms.TextBox();
            this.team1ScoreLabel = new System.Windows.Forms.Label();
            this.teamOneName = new System.Windows.Forms.Label();
            this.matchupListbox = new System.Windows.Forms.ListBox();
            this.unplayedOnlyCheckbox = new System.Windows.Forms.CheckBox();
            this.roundDropdown = new System.Windows.Forms.ComboBox();
            this.roundLabel = new System.Windows.Forms.Label();
            this.tournamentName = new System.Windows.Forms.Label();
            this.headerLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // scoreButton
            // 
            this.scoreButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(255)))), ((int)(((byte)(115)))));
            this.scoreButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.scoreButton.FlatAppearance.BorderSize = 2;
            this.scoreButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(182)))));
            this.scoreButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.scoreButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.scoreButton.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.scoreButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.scoreButton.Location = new System.Drawing.Point(919, 378);
            this.scoreButton.Name = "scoreButton";
            this.scoreButton.Size = new System.Drawing.Size(170, 95);
            this.scoreButton.TabIndex = 41;
            this.scoreButton.Text = "Score";
            this.scoreButton.UseVisualStyleBackColor = false;
            // 
            // versusLabel
            // 
            this.versusLabel.AutoSize = true;
            this.versusLabel.BackColor = System.Drawing.Color.Black;
            this.versusLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.versusLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.versusLabel.Location = new System.Drawing.Point(522, 423);
            this.versusLabel.MaximumSize = new System.Drawing.Size(0, 5);
            this.versusLabel.Name = "versusLabel";
            this.versusLabel.Size = new System.Drawing.Size(370, 5);
            this.versusLabel.TabIndex = 40;
            this.versusLabel.Text = "                                            ";
            // 
            // team2ScoreValue
            // 
            this.team2ScoreValue.Location = new System.Drawing.Point(708, 530);
            this.team2ScoreValue.Name = "team2ScoreValue";
            this.team2ScoreValue.Size = new System.Drawing.Size(125, 43);
            this.team2ScoreValue.TabIndex = 39;
            // 
            // team2ScoreLabel
            // 
            this.team2ScoreLabel.AutoSize = true;
            this.team2ScoreLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.team2ScoreLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.team2ScoreLabel.Location = new System.Drawing.Point(578, 532);
            this.team2ScoreLabel.MaximumSize = new System.Drawing.Size(175, 0);
            this.team2ScoreLabel.Name = "team2ScoreLabel";
            this.team2ScoreLabel.Size = new System.Drawing.Size(92, 41);
            this.team2ScoreLabel.TabIndex = 38;
            this.team2ScoreLabel.Text = "Score";
            // 
            // teamTwoName
            // 
            this.teamTwoName.AutoSize = true;
            this.teamTwoName.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.teamTwoName.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.teamTwoName.Location = new System.Drawing.Point(522, 462);
            this.teamTwoName.Name = "teamTwoName";
            this.teamTwoName.Size = new System.Drawing.Size(185, 41);
            this.teamTwoName.TabIndex = 37;
            this.teamTwoName.Text = "<team two>";
            // 
            // team1ScoreValue
            // 
            this.team1ScoreValue.Location = new System.Drawing.Point(708, 340);
            this.team1ScoreValue.Name = "team1ScoreValue";
            this.team1ScoreValue.Size = new System.Drawing.Size(125, 43);
            this.team1ScoreValue.TabIndex = 36;
            // 
            // team1ScoreLabel
            // 
            this.team1ScoreLabel.AutoSize = true;
            this.team1ScoreLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.team1ScoreLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.team1ScoreLabel.Location = new System.Drawing.Point(578, 340);
            this.team1ScoreLabel.MaximumSize = new System.Drawing.Size(175, 0);
            this.team1ScoreLabel.Name = "team1ScoreLabel";
            this.team1ScoreLabel.Size = new System.Drawing.Size(92, 41);
            this.team1ScoreLabel.TabIndex = 35;
            this.team1ScoreLabel.Text = "Score";
            // 
            // teamOneName
            // 
            this.teamOneName.AutoSize = true;
            this.teamOneName.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.teamOneName.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.teamOneName.Location = new System.Drawing.Point(522, 267);
            this.teamOneName.Name = "teamOneName";
            this.teamOneName.Size = new System.Drawing.Size(186, 41);
            this.teamOneName.TabIndex = 34;
            this.teamOneName.Text = "<team one>";
            // 
            // matchupListbox
            // 
            this.matchupListbox.FormattingEnabled = true;
            this.matchupListbox.ItemHeight = 37;
            this.matchupListbox.Location = new System.Drawing.Point(53, 267);
            this.matchupListbox.Name = "matchupListbox";
            this.matchupListbox.Size = new System.Drawing.Size(446, 263);
            this.matchupListbox.TabIndex = 33;
            this.matchupListbox.SelectedIndexChanged += new System.EventHandler(this.matchupListbox_SelectedIndexChanged);
            // 
            // unplayedOnlyCheckbox
            // 
            this.unplayedOnlyCheckbox.AutoSize = true;
            this.unplayedOnlyCheckbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.unplayedOnlyCheckbox.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.unplayedOnlyCheckbox.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.unplayedOnlyCheckbox.Location = new System.Drawing.Point(189, 193);
            this.unplayedOnlyCheckbox.Name = "unplayedOnlyCheckbox";
            this.unplayedOnlyCheckbox.Size = new System.Drawing.Size(233, 45);
            this.unplayedOnlyCheckbox.TabIndex = 32;
            this.unplayedOnlyCheckbox.Text = "Unplayed Only";
            this.unplayedOnlyCheckbox.UseVisualStyleBackColor = true;
            // 
            // roundDropdown
            // 
            this.roundDropdown.FormattingEnabled = true;
            this.roundDropdown.Location = new System.Drawing.Point(189, 121);
            this.roundDropdown.Name = "roundDropdown";
            this.roundDropdown.Size = new System.Drawing.Size(227, 45);
            this.roundDropdown.TabIndex = 31;
            this.roundDropdown.SelectedIndexChanged += new System.EventHandler(this.roundDropdown_SelectedIndexChanged);
            // 
            // roundLabel
            // 
            this.roundLabel.AutoSize = true;
            this.roundLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.roundLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.roundLabel.Location = new System.Drawing.Point(52, 125);
            this.roundLabel.Name = "roundLabel";
            this.roundLabel.Size = new System.Drawing.Size(105, 41);
            this.roundLabel.TabIndex = 30;
            this.roundLabel.Text = "Round";
            // 
            // tournamentName
            // 
            this.tournamentName.AutoSize = true;
            this.tournamentName.Font = new System.Drawing.Font("Segoe UI Light", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tournamentName.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.tournamentName.Location = new System.Drawing.Point(320, 35);
            this.tournamentName.Name = "tournamentName";
            this.tournamentName.Size = new System.Drawing.Size(173, 59);
            this.tournamentName.TabIndex = 29;
            this.tournamentName.Text = "<none>";
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI Light", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.headerLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.headerLabel.Location = new System.Drawing.Point(37, 35);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(248, 59);
            this.headerLabel.TabIndex = 28;
            this.headerLabel.Text = "Tournament:";
            // 
            // TournamentViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1176, 677);
            this.Controls.Add(this.scoreButton);
            this.Controls.Add(this.versusLabel);
            this.Controls.Add(this.team2ScoreValue);
            this.Controls.Add(this.team2ScoreLabel);
            this.Controls.Add(this.teamTwoName);
            this.Controls.Add(this.team1ScoreValue);
            this.Controls.Add(this.team1ScoreLabel);
            this.Controls.Add(this.teamOneName);
            this.Controls.Add(this.matchupListbox);
            this.Controls.Add(this.unplayedOnlyCheckbox);
            this.Controls.Add(this.roundDropdown);
            this.Controls.Add(this.roundLabel);
            this.Controls.Add(this.tournamentName);
            this.Controls.Add(this.headerLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "TournamentViewerForm";
            this.Text = "Tournament Viewer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button scoreButton;
        private System.Windows.Forms.Label versusLabel;
        private System.Windows.Forms.TextBox team2ScoreValue;
        private System.Windows.Forms.Label team2ScoreLabel;
        private System.Windows.Forms.Label teamTwoName;
        private System.Windows.Forms.TextBox team1ScoreValue;
        private System.Windows.Forms.Label team1ScoreLabel;
        private System.Windows.Forms.Label teamOneName;
        private System.Windows.Forms.ListBox matchupListbox;
        private System.Windows.Forms.CheckBox unplayedOnlyCheckbox;
        private System.Windows.Forms.ComboBox roundDropdown;
        private System.Windows.Forms.Label roundLabel;
        private System.Windows.Forms.Label tournamentName;
        private System.Windows.Forms.Label headerLabel;
    }
}