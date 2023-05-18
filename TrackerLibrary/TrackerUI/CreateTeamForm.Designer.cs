
namespace TrackerUI
{
    partial class CreateTeamForm
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
            this.teamNameValue = new System.Windows.Forms.TextBox();
            this.teamNameLabel = new System.Windows.Forms.Label();
            this.headerLabel = new System.Windows.Forms.Label();
            this.selectTeamMemberDropdown = new System.Windows.Forms.ComboBox();
            this.selectTeamMemberLabel = new System.Windows.Forms.Label();
            this.addMemberButton = new System.Windows.Forms.Button();
            this.addNewMemberGroupbox = new System.Windows.Forms.GroupBox();
            this.createMemberButton = new System.Windows.Forms.Button();
            this.cellphoneValue = new System.Windows.Forms.TextBox();
            this.phoneNoLabel = new System.Windows.Forms.Label();
            this.emailValue = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.lastNameValue = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameValue = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.teamMembersListbox = new System.Windows.Forms.ListBox();
            this.createTeamButton = new System.Windows.Forms.Button();
            this.deleteSelectedMemberButton = new System.Windows.Forms.Button();
            this.addNewMemberGroupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // teamNameValue
            // 
            this.teamNameValue.Location = new System.Drawing.Point(29, 113);
            this.teamNameValue.MinimumSize = new System.Drawing.Size(200, 4);
            this.teamNameValue.Name = "teamNameValue";
            this.teamNameValue.Size = new System.Drawing.Size(364, 43);
            this.teamNameValue.TabIndex = 41;
            // 
            // teamNameLabel
            // 
            this.teamNameLabel.AutoSize = true;
            this.teamNameLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.teamNameLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.teamNameLabel.Location = new System.Drawing.Point(29, 69);
            this.teamNameLabel.Name = "teamNameLabel";
            this.teamNameLabel.Size = new System.Drawing.Size(175, 41);
            this.teamNameLabel.TabIndex = 40;
            this.teamNameLabel.Text = "Team Name";
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI Light", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.headerLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.headerLabel.Location = new System.Drawing.Point(15, 3);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(248, 59);
            this.headerLabel.TabIndex = 39;
            this.headerLabel.Text = "Create Team";
            // 
            // selectTeamMemberDropdown
            // 
            this.selectTeamMemberDropdown.FormattingEnabled = true;
            this.selectTeamMemberDropdown.Location = new System.Drawing.Point(29, 204);
            this.selectTeamMemberDropdown.Name = "selectTeamMemberDropdown";
            this.selectTeamMemberDropdown.Size = new System.Drawing.Size(364, 45);
            this.selectTeamMemberDropdown.TabIndex = 44;
            // 
            // selectTeamMemberLabel
            // 
            this.selectTeamMemberLabel.AutoSize = true;
            this.selectTeamMemberLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.selectTeamMemberLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.selectTeamMemberLabel.Location = new System.Drawing.Point(29, 161);
            this.selectTeamMemberLabel.Name = "selectTeamMemberLabel";
            this.selectTeamMemberLabel.Size = new System.Drawing.Size(296, 41);
            this.selectTeamMemberLabel.TabIndex = 43;
            this.selectTeamMemberLabel.Text = "Select Team Member";
            // 
            // addMemberButton
            // 
            this.addMemberButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(155)))));
            this.addMemberButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.addMemberButton.FlatAppearance.BorderSize = 2;
            this.addMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(182)))));
            this.addMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.addMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addMemberButton.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addMemberButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.addMemberButton.Location = new System.Drawing.Point(86, 255);
            this.addMemberButton.Name = "addMemberButton";
            this.addMemberButton.Size = new System.Drawing.Size(250, 71);
            this.addMemberButton.TabIndex = 45;
            this.addMemberButton.Text = "Add Member";
            this.addMemberButton.UseVisualStyleBackColor = false;
            // 
            // addNewMemberGroupbox
            // 
            this.addNewMemberGroupbox.Controls.Add(this.createMemberButton);
            this.addNewMemberGroupbox.Controls.Add(this.cellphoneValue);
            this.addNewMemberGroupbox.Controls.Add(this.phoneNoLabel);
            this.addNewMemberGroupbox.Controls.Add(this.emailValue);
            this.addNewMemberGroupbox.Controls.Add(this.emailLabel);
            this.addNewMemberGroupbox.Controls.Add(this.lastNameValue);
            this.addNewMemberGroupbox.Controls.Add(this.lastNameLabel);
            this.addNewMemberGroupbox.Controls.Add(this.firstNameValue);
            this.addNewMemberGroupbox.Controls.Add(this.firstNameLabel);
            this.addNewMemberGroupbox.Location = new System.Drawing.Point(29, 332);
            this.addNewMemberGroupbox.Name = "addNewMemberGroupbox";
            this.addNewMemberGroupbox.Size = new System.Drawing.Size(364, 418);
            this.addNewMemberGroupbox.TabIndex = 46;
            this.addNewMemberGroupbox.TabStop = false;
            this.addNewMemberGroupbox.Text = "Add New Member";
            // 
            // createMemberButton
            // 
            this.createMemberButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(253)))), ((int)(((byte)(209)))));
            this.createMemberButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createMemberButton.FlatAppearance.BorderSize = 2;
            this.createMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(182)))));
            this.createMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.createMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createMemberButton.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.createMemberButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.createMemberButton.Location = new System.Drawing.Point(57, 309);
            this.createMemberButton.Name = "createMemberButton";
            this.createMemberButton.Size = new System.Drawing.Size(250, 83);
            this.createMemberButton.TabIndex = 47;
            this.createMemberButton.Text = "Create Member";
            this.createMemberButton.UseVisualStyleBackColor = false;
            this.createMemberButton.Click += new System.EventHandler(this.createMemberButton_Click);
            // 
            // cellphoneValue
            // 
            this.cellphoneValue.Location = new System.Drawing.Point(166, 242);
            this.cellphoneValue.MinimumSize = new System.Drawing.Size(150, 4);
            this.cellphoneValue.Name = "cellphoneValue";
            this.cellphoneValue.Size = new System.Drawing.Size(193, 43);
            this.cellphoneValue.TabIndex = 54;
            // 
            // phoneNoLabel
            // 
            this.phoneNoLabel.AutoSize = true;
            this.phoneNoLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.phoneNoLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.phoneNoLabel.Location = new System.Drawing.Point(6, 244);
            this.phoneNoLabel.Name = "phoneNoLabel";
            this.phoneNoLabel.Size = new System.Drawing.Size(151, 41);
            this.phoneNoLabel.TabIndex = 53;
            this.phoneNoLabel.Text = "Phone No";
            // 
            // emailValue
            // 
            this.emailValue.Location = new System.Drawing.Point(166, 180);
            this.emailValue.MinimumSize = new System.Drawing.Size(150, 4);
            this.emailValue.Name = "emailValue";
            this.emailValue.Size = new System.Drawing.Size(193, 43);
            this.emailValue.TabIndex = 52;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.emailLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.emailLabel.Location = new System.Drawing.Point(6, 180);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(88, 41);
            this.emailLabel.TabIndex = 51;
            this.emailLabel.Text = "Email";
            // 
            // lastNameValue
            // 
            this.lastNameValue.Location = new System.Drawing.Point(166, 118);
            this.lastNameValue.MinimumSize = new System.Drawing.Size(150, 4);
            this.lastNameValue.Name = "lastNameValue";
            this.lastNameValue.Size = new System.Drawing.Size(193, 43);
            this.lastNameValue.TabIndex = 50;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lastNameLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lastNameLabel.Location = new System.Drawing.Point(6, 118);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(157, 41);
            this.lastNameLabel.TabIndex = 49;
            this.lastNameLabel.Text = "Last Name";
            // 
            // firstNameValue
            // 
            this.firstNameValue.Location = new System.Drawing.Point(166, 56);
            this.firstNameValue.MinimumSize = new System.Drawing.Size(150, 4);
            this.firstNameValue.Name = "firstNameValue";
            this.firstNameValue.Size = new System.Drawing.Size(193, 43);
            this.firstNameValue.TabIndex = 48;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.firstNameLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.firstNameLabel.Location = new System.Drawing.Point(6, 56);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(160, 41);
            this.firstNameLabel.TabIndex = 47;
            this.firstNameLabel.Text = "First Name";
            // 
            // teamMembersListbox
            // 
            this.teamMembersListbox.FormattingEnabled = true;
            this.teamMembersListbox.ItemHeight = 37;
            this.teamMembersListbox.Location = new System.Drawing.Point(464, 113);
            this.teamMembersListbox.Name = "teamMembersListbox";
            this.teamMembersListbox.Size = new System.Drawing.Size(454, 411);
            this.teamMembersListbox.TabIndex = 47;
            // 
            // createTeamButton
            // 
            this.createTeamButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(253)))), ((int)(((byte)(207)))));
            this.createTeamButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createTeamButton.FlatAppearance.BorderSize = 2;
            this.createTeamButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(182)))));
            this.createTeamButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.createTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createTeamButton.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.createTeamButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.createTeamButton.Location = new System.Drawing.Point(464, 617);
            this.createTeamButton.Name = "createTeamButton";
            this.createTeamButton.Size = new System.Drawing.Size(454, 131);
            this.createTeamButton.TabIndex = 55;
            this.createTeamButton.Text = "Create Team";
            this.createTeamButton.UseVisualStyleBackColor = false;
            // 
            // deleteSelectedMemberButton
            // 
            this.deleteSelectedMemberButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.deleteSelectedMemberButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.deleteSelectedMemberButton.FlatAppearance.BorderSize = 2;
            this.deleteSelectedMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(182)))));
            this.deleteSelectedMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.deleteSelectedMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteSelectedMemberButton.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.deleteSelectedMemberButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.deleteSelectedMemberButton.Location = new System.Drawing.Point(464, 530);
            this.deleteSelectedMemberButton.Name = "deleteSelectedMemberButton";
            this.deleteSelectedMemberButton.Size = new System.Drawing.Size(454, 60);
            this.deleteSelectedMemberButton.TabIndex = 56;
            this.deleteSelectedMemberButton.Text = "Delete Selected";
            this.deleteSelectedMemberButton.UseVisualStyleBackColor = false;
            // 
            // CreateTeamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(959, 762);
            this.Controls.Add(this.deleteSelectedMemberButton);
            this.Controls.Add(this.createTeamButton);
            this.Controls.Add(this.teamMembersListbox);
            this.Controls.Add(this.addNewMemberGroupbox);
            this.Controls.Add(this.addMemberButton);
            this.Controls.Add(this.selectTeamMemberDropdown);
            this.Controls.Add(this.selectTeamMemberLabel);
            this.Controls.Add(this.teamNameValue);
            this.Controls.Add(this.teamNameLabel);
            this.Controls.Add(this.headerLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "CreateTeamForm";
            this.Text = "Create Team";
            this.addNewMemberGroupbox.ResumeLayout(false);
            this.addNewMemberGroupbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox teamNameValue;
        private System.Windows.Forms.Label teamNameLabel;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.ComboBox selectTeamMemberDropdown;
        private System.Windows.Forms.Label selectTeamMemberLabel;
        private System.Windows.Forms.Button addMemberButton;
        private System.Windows.Forms.GroupBox addNewMemberGroupbox;
        private System.Windows.Forms.Button createMemberButton;
        private System.Windows.Forms.TextBox cellphoneValue;
        private System.Windows.Forms.Label phoneNoLabel;
        private System.Windows.Forms.TextBox emailValue;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox lastNameValue;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox firstNameValue;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.ListBox teamMembersListbox;
        private System.Windows.Forms.Button createTeamButton;
        private System.Windows.Forms.Button deleteSelectedMemberButton;
    }
}