namespace TrackerUI
{
    partial class tournamentPlayersListBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tournamentPlayersListBox));
            this.headerLabel = new System.Windows.Forms.Label();
            this.turnamentNameValue = new System.Windows.Forms.TextBox();
            this.tournamentNameLabel = new System.Windows.Forms.Label();
            this.entryFeeValue = new System.Windows.Forms.TextBox();
            this.entryFeeLable = new System.Windows.Forms.Label();
            this.selectTeamDropDown = new System.Windows.Forms.ComboBox();
            this.selectTeamLabel = new System.Windows.Forms.Label();
            this.creatNewTeamLink = new System.Windows.Forms.LinkLabel();
            this.addTeamButton = new System.Windows.Forms.Button();
            this.createPrizeButton = new System.Windows.Forms.Button();
            this.roundLabel = new System.Windows.Forms.Label();
            this.deletePrizeButton = new System.Windows.Forms.Button();
            this.prizesListBox = new System.Windows.Forms.ListBox();
            this.deleteSelectedPlayersButton = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.createTournamentButton = new System.Windows.Forms.Button();
            this.tournamentListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI Light", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.headerLabel.Location = new System.Drawing.Point(26, 35);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(403, 62);
            this.headerLabel.TabIndex = 1;
            this.headerLabel.Text = "Create Tournament";
            // 
            // turnamentNameValue
            // 
            this.turnamentNameValue.Location = new System.Drawing.Point(37, 177);
            this.turnamentNameValue.Name = "turnamentNameValue";
            this.turnamentNameValue.Size = new System.Drawing.Size(392, 43);
            this.turnamentNameValue.TabIndex = 10;
            this.turnamentNameValue.TextChanged += new System.EventHandler(this.teamOneScoreText_TextChanged);
            // 
            // tournamentNameLabel
            // 
            this.tournamentNameLabel.AutoSize = true;
            this.tournamentNameLabel.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tournamentNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.tournamentNameLabel.Location = new System.Drawing.Point(29, 128);
            this.tournamentNameLabel.Name = "tournamentNameLabel";
            this.tournamentNameLabel.Size = new System.Drawing.Size(298, 46);
            this.tournamentNameLabel.TabIndex = 9;
            this.tournamentNameLabel.Text = "Tournament Name";
            // 
            // entryFeeValue
            // 
            this.entryFeeValue.Location = new System.Drawing.Point(227, 261);
            this.entryFeeValue.Name = "entryFeeValue";
            this.entryFeeValue.Size = new System.Drawing.Size(100, 43);
            this.entryFeeValue.TabIndex = 12;
            this.entryFeeValue.Text = "0";
            // 
            // entryFeeLable
            // 
            this.entryFeeLable.AutoSize = true;
            this.entryFeeLable.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entryFeeLable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.entryFeeLable.Location = new System.Drawing.Point(40, 258);
            this.entryFeeLable.Name = "entryFeeLable";
            this.entryFeeLable.Size = new System.Drawing.Size(158, 46);
            this.entryFeeLable.TabIndex = 11;
            this.entryFeeLable.Text = "Entry Fee";
            // 
            // selectTeamDropDown
            // 
            this.selectTeamDropDown.FormattingEnabled = true;
            this.selectTeamDropDown.Location = new System.Drawing.Point(48, 402);
            this.selectTeamDropDown.Name = "selectTeamDropDown";
            this.selectTeamDropDown.Size = new System.Drawing.Size(380, 45);
            this.selectTeamDropDown.TabIndex = 14;
            // 
            // selectTeamLabel
            // 
            this.selectTeamLabel.AutoSize = true;
            this.selectTeamLabel.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectTeamLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.selectTeamLabel.Location = new System.Drawing.Point(41, 353);
            this.selectTeamLabel.Name = "selectTeamLabel";
            this.selectTeamLabel.Size = new System.Drawing.Size(198, 46);
            this.selectTeamLabel.TabIndex = 13;
            this.selectTeamLabel.Text = "Select Team";
            // 
            // creatNewTeamLink
            // 
            this.creatNewTeamLink.AutoSize = true;
            this.creatNewTeamLink.Location = new System.Drawing.Point(288, 361);
            this.creatNewTeamLink.Name = "creatNewTeamLink";
            this.creatNewTeamLink.Size = new System.Drawing.Size(152, 38);
            this.creatNewTeamLink.TabIndex = 15;
            this.creatNewTeamLink.TabStop = true;
            this.creatNewTeamLink.Text = "create new";
            // 
            // addTeamButton
            // 
            this.addTeamButton.BackColor = System.Drawing.Color.White;
            this.addTeamButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.addTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addTeamButton.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addTeamButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.addTeamButton.Location = new System.Drawing.Point(94, 463);
            this.addTeamButton.Name = "addTeamButton";
            this.addTeamButton.Size = new System.Drawing.Size(277, 62);
            this.addTeamButton.TabIndex = 16;
            this.addTeamButton.Text = "Add Team";
            this.addTeamButton.UseVisualStyleBackColor = false;
            // 
            // createPrizeButton
            // 
            this.createPrizeButton.BackColor = System.Drawing.Color.White;
            this.createPrizeButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createPrizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createPrizeButton.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createPrizeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.createPrizeButton.Location = new System.Drawing.Point(94, 545);
            this.createPrizeButton.Name = "createPrizeButton";
            this.createPrizeButton.Size = new System.Drawing.Size(277, 58);
            this.createPrizeButton.TabIndex = 17;
            this.createPrizeButton.Text = "Create Prize";
            this.createPrizeButton.UseVisualStyleBackColor = false;
            this.createPrizeButton.Click += new System.EventHandler(this.scoreButton_Click);
            // 
            // roundLabel
            // 
            this.roundLabel.AutoSize = true;
            this.roundLabel.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.roundLabel.Location = new System.Drawing.Point(542, 128);
            this.roundLabel.Name = "roundLabel";
            this.roundLabel.Size = new System.Drawing.Size(216, 46);
            this.roundLabel.TabIndex = 19;
            this.roundLabel.Text = "Team/Players";
            // 
            // deletePrizeButton
            // 
            this.deletePrizeButton.BackColor = System.Drawing.Color.White;
            this.deletePrizeButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.deletePrizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deletePrizeButton.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletePrizeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.deletePrizeButton.Location = new System.Drawing.Point(871, 490);
            this.deletePrizeButton.Name = "deletePrizeButton";
            this.deletePrizeButton.Size = new System.Drawing.Size(147, 113);
            this.deletePrizeButton.TabIndex = 24;
            this.deletePrizeButton.Text = "Delete Selected";
            this.deletePrizeButton.UseVisualStyleBackColor = false;
            // 
            // prizesListBox
            // 
            this.prizesListBox.FormattingEnabled = true;
            this.prizesListBox.ItemHeight = 37;
            this.prizesListBox.Location = new System.Drawing.Point(550, 451);
            this.prizesListBox.Name = "prizesListBox";
            this.prizesListBox.Size = new System.Drawing.Size(305, 189);
            this.prizesListBox.TabIndex = 23;
            // 
            // deleteSelectedPlayersButton
            // 
            this.deleteSelectedPlayersButton.AutoSize = true;
            this.deleteSelectedPlayersButton.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteSelectedPlayersButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.deleteSelectedPlayersButton.Location = new System.Drawing.Point(542, 402);
            this.deleteSelectedPlayersButton.Name = "deleteSelectedPlayersButton";
            this.deleteSelectedPlayersButton.Size = new System.Drawing.Size(259, 46);
            this.deleteSelectedPlayersButton.TabIndex = 22;
            this.deleteSelectedPlayersButton.Text = "Delete/Selected";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.button1.Location = new System.Drawing.Point(871, 212);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 113);
            this.button1.TabIndex = 25;
            this.button1.Text = "Delete Selected";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // createTournamentButton
            // 
            this.createTournamentButton.BackColor = System.Drawing.Color.White;
            this.createTournamentButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createTournamentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createTournamentButton.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createTournamentButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.createTournamentButton.Location = new System.Drawing.Point(382, 676);
            this.createTournamentButton.Name = "createTournamentButton";
            this.createTournamentButton.Size = new System.Drawing.Size(285, 67);
            this.createTournamentButton.TabIndex = 26;
            this.createTournamentButton.Text = "Create Tournament";
            this.createTournamentButton.UseVisualStyleBackColor = false;
            // 
            // tournamentListBox
            // 
            this.tournamentListBox.FormattingEnabled = true;
            this.tournamentListBox.ItemHeight = 37;
            this.tournamentListBox.Location = new System.Drawing.Point(550, 177);
            this.tournamentListBox.Name = "tournamentListBox";
            this.tournamentListBox.Size = new System.Drawing.Size(305, 189);
            this.tournamentListBox.TabIndex = 27;
            // 
            // tournamentPlayersListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1041, 775);
            this.Controls.Add(this.tournamentListBox);
            this.Controls.Add(this.createTournamentButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.deletePrizeButton);
            this.Controls.Add(this.prizesListBox);
            this.Controls.Add(this.deleteSelectedPlayersButton);
            this.Controls.Add(this.roundLabel);
            this.Controls.Add(this.createPrizeButton);
            this.Controls.Add(this.addTeamButton);
            this.Controls.Add(this.creatNewTeamLink);
            this.Controls.Add(this.selectTeamDropDown);
            this.Controls.Add(this.selectTeamLabel);
            this.Controls.Add(this.entryFeeValue);
            this.Controls.Add(this.entryFeeLable);
            this.Controls.Add(this.turnamentNameValue);
            this.Controls.Add(this.tournamentNameLabel);
            this.Controls.Add(this.headerLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "tournamentPlayersListBox";
            this.Text = "CreateTournament";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.TextBox turnamentNameValue;
        private System.Windows.Forms.Label tournamentNameLabel;
        private System.Windows.Forms.TextBox entryFeeValue;
        private System.Windows.Forms.Label entryFeeLable;
        private System.Windows.Forms.ComboBox selectTeamDropDown;
        private System.Windows.Forms.Label selectTeamLabel;
        private System.Windows.Forms.LinkLabel creatNewTeamLink;
        private System.Windows.Forms.Button addTeamButton;
        private System.Windows.Forms.Button createPrizeButton;
        private System.Windows.Forms.Label roundLabel;
        private System.Windows.Forms.Button deletePrizeButton;
        private System.Windows.Forms.ListBox prizesListBox;
        private System.Windows.Forms.Label deleteSelectedPlayersButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button createTournamentButton;
        private System.Windows.Forms.ListBox tournamentListBox;
    }
}