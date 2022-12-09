namespace TrackerUI
{
    partial class GameForm
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
            this.createGameLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameLabelText = new System.Windows.Forms.TextBox();
            this.selectTeamLabel = new System.Windows.Forms.Label();
            this.selectTeamComboBox = new System.Windows.Forms.ComboBox();
            this.createNewTeamLink = new System.Windows.Forms.LinkLabel();
            this.addTeamButton = new System.Windows.Forms.Button();
            this.addNewWinnerButoon = new System.Windows.Forms.Button();
            this.gameListBox = new System.Windows.Forms.ListBox();
            this.teamPlayerLabel = new System.Windows.Forms.Label();
            this.deleteSelected = new System.Windows.Forms.Button();
            this.deleteSelectedButton2 = new System.Windows.Forms.Button();
            this.teamPlayerLabel2 = new System.Windows.Forms.Label();
            this.winnerListBox = new System.Windows.Forms.ListBox();
            this.createGameButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // createGameLabel
            // 
            this.createGameLabel.AutoSize = true;
            this.createGameLabel.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.createGameLabel.ForeColor = System.Drawing.Color.Red;
            this.createGameLabel.Location = new System.Drawing.Point(12, 9);
            this.createGameLabel.Name = "createGameLabel";
            this.createGameLabel.Size = new System.Drawing.Size(177, 36);
            this.createGameLabel.TabIndex = 1;
            this.createGameLabel.Text = "Create Game: ";
            this.createGameLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameLabel.ForeColor = System.Drawing.Color.Red;
            this.nameLabel.Location = new System.Drawing.Point(12, 71);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(96, 36);
            this.nameLabel.TabIndex = 2;
            this.nameLabel.Text = "Name: ";
            // 
            // nameLabelText
            // 
            this.nameLabelText.Location = new System.Drawing.Point(12, 110);
            this.nameLabelText.Name = "nameLabelText";
            this.nameLabelText.Size = new System.Drawing.Size(177, 23);
            this.nameLabelText.TabIndex = 3;
            // 
            // selectTeamLabel
            // 
            this.selectTeamLabel.AutoSize = true;
            this.selectTeamLabel.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.selectTeamLabel.ForeColor = System.Drawing.Color.Red;
            this.selectTeamLabel.Location = new System.Drawing.Point(12, 204);
            this.selectTeamLabel.Name = "selectTeamLabel";
            this.selectTeamLabel.Size = new System.Drawing.Size(164, 36);
            this.selectTeamLabel.TabIndex = 4;
            this.selectTeamLabel.Text = "Select Team: ";
            // 
            // selectTeamComboBox
            // 
            this.selectTeamComboBox.FormattingEnabled = true;
            this.selectTeamComboBox.Location = new System.Drawing.Point(12, 264);
            this.selectTeamComboBox.Name = "selectTeamComboBox";
            this.selectTeamComboBox.Size = new System.Drawing.Size(177, 23);
            this.selectTeamComboBox.TabIndex = 5;
            // 
            // createNewTeamLink
            // 
            this.createNewTeamLink.AutoSize = true;
            this.createNewTeamLink.Location = new System.Drawing.Point(129, 246);
            this.createNewTeamLink.Name = "createNewTeamLink";
            this.createNewTeamLink.Size = new System.Drawing.Size(94, 15);
            this.createNewTeamLink.TabIndex = 6;
            this.createNewTeamLink.TabStop = true;
            this.createNewTeamLink.Text = "create new team";
            // 
            // addTeamButton
            // 
            this.addTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addTeamButton.Location = new System.Drawing.Point(48, 320);
            this.addTeamButton.Name = "addTeamButton";
            this.addTeamButton.Size = new System.Drawing.Size(141, 39);
            this.addTeamButton.TabIndex = 7;
            this.addTeamButton.Text = "Add New Team";
            this.addTeamButton.UseVisualStyleBackColor = true;
            // 
            // addNewWinnerButoon
            // 
            this.addNewWinnerButoon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addNewWinnerButoon.Location = new System.Drawing.Point(48, 388);
            this.addNewWinnerButoon.Name = "addNewWinnerButoon";
            this.addNewWinnerButoon.Size = new System.Drawing.Size(141, 39);
            this.addNewWinnerButoon.TabIndex = 8;
            this.addNewWinnerButoon.Text = "Add New Winner";
            this.addNewWinnerButoon.UseVisualStyleBackColor = true;
            // 
            // gameListBox
            // 
            this.gameListBox.FormattingEnabled = true;
            this.gameListBox.ItemHeight = 15;
            this.gameListBox.Location = new System.Drawing.Point(289, 71);
            this.gameListBox.Name = "gameListBox";
            this.gameListBox.Size = new System.Drawing.Size(223, 124);
            this.gameListBox.TabIndex = 9;
            // 
            // teamPlayerLabel
            // 
            this.teamPlayerLabel.AutoSize = true;
            this.teamPlayerLabel.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.teamPlayerLabel.ForeColor = System.Drawing.Color.Red;
            this.teamPlayerLabel.Location = new System.Drawing.Point(289, 21);
            this.teamPlayerLabel.Name = "teamPlayerLabel";
            this.teamPlayerLabel.Size = new System.Drawing.Size(162, 36);
            this.teamPlayerLabel.TabIndex = 10;
            this.teamPlayerLabel.Text = "Team/ Player";
            // 
            // deleteSelected
            // 
            this.deleteSelected.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteSelected.Location = new System.Drawing.Point(563, 101);
            this.deleteSelected.Name = "deleteSelected";
            this.deleteSelected.Size = new System.Drawing.Size(141, 39);
            this.deleteSelected.TabIndex = 11;
            this.deleteSelected.Text = "Delete Selected";
            this.deleteSelected.UseVisualStyleBackColor = true;
            // 
            // deleteSelectedButton2
            // 
            this.deleteSelectedButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteSelectedButton2.Location = new System.Drawing.Point(563, 308);
            this.deleteSelectedButton2.Name = "deleteSelectedButton2";
            this.deleteSelectedButton2.Size = new System.Drawing.Size(141, 39);
            this.deleteSelectedButton2.TabIndex = 14;
            this.deleteSelectedButton2.Text = "Delete Selected";
            this.deleteSelectedButton2.UseVisualStyleBackColor = true;
            // 
            // teamPlayerLabel2
            // 
            this.teamPlayerLabel2.AutoSize = true;
            this.teamPlayerLabel2.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.teamPlayerLabel2.ForeColor = System.Drawing.Color.Red;
            this.teamPlayerLabel2.Location = new System.Drawing.Point(289, 229);
            this.teamPlayerLabel2.Name = "teamPlayerLabel2";
            this.teamPlayerLabel2.Size = new System.Drawing.Size(162, 36);
            this.teamPlayerLabel2.TabIndex = 13;
            this.teamPlayerLabel2.Text = "Team/ Player";
            // 
            // winnerListBox
            // 
            this.winnerListBox.FormattingEnabled = true;
            this.winnerListBox.ItemHeight = 15;
            this.winnerListBox.Location = new System.Drawing.Point(289, 279);
            this.winnerListBox.Name = "winnerListBox";
            this.winnerListBox.Size = new System.Drawing.Size(223, 124);
            this.winnerListBox.TabIndex = 12;
            // 
            // createGameButton
            // 
            this.createGameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createGameButton.ForeColor = System.Drawing.Color.IndianRed;
            this.createGameButton.Location = new System.Drawing.Point(608, 399);
            this.createGameButton.Name = "createGameButton";
            this.createGameButton.Size = new System.Drawing.Size(141, 39);
            this.createGameButton.TabIndex = 15;
            this.createGameButton.Text = "Create Game";
            this.createGameButton.UseVisualStyleBackColor = true;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.createGameButton);
            this.Controls.Add(this.deleteSelectedButton2);
            this.Controls.Add(this.teamPlayerLabel2);
            this.Controls.Add(this.winnerListBox);
            this.Controls.Add(this.deleteSelected);
            this.Controls.Add(this.teamPlayerLabel);
            this.Controls.Add(this.gameListBox);
            this.Controls.Add(this.addNewWinnerButoon);
            this.Controls.Add(this.addTeamButton);
            this.Controls.Add(this.createNewTeamLink);
            this.Controls.Add(this.selectTeamComboBox);
            this.Controls.Add(this.selectTeamLabel);
            this.Controls.Add(this.nameLabelText);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.createGameLabel);
            this.Name = "GameForm";
            this.Text = "GameForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label createGameLabel;
        private Label nameLabel;
        private TextBox nameLabelText;
        private Label selectTeamLabel;
        private ComboBox selectTeamComboBox;
        private LinkLabel createNewTeamLink;
        private Button addTeamButton;
        private Button addNewWinnerButoon;
        private ListBox gameListBox;
        private Label teamPlayerLabel;
        private Button deleteSelected;
        private Button deleteSelectedButton2;
        private Label teamPlayerLabel2;
        private ListBox winnerListBox;
        private Button createGameButton;
    }
}