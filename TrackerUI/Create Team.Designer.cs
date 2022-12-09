namespace TrackerUI
{
    partial class Create_Team
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
            this.createTeamLabel = new System.Windows.Forms.Label();
            this.newTeamMemberGroupBox = new System.Windows.Forms.GroupBox();
            this.createMemberButton = new System.Windows.Forms.Button();
            this.emailAddTextbox = new System.Windows.Forms.TextBox();
            this.emailAddressLabel = new System.Windows.Forms.Label();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameText = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.newTeamMemberGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // createTeamLabel
            // 
            this.createTeamLabel.AutoSize = true;
            this.createTeamLabel.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.createTeamLabel.ForeColor = System.Drawing.Color.Red;
            this.createTeamLabel.Location = new System.Drawing.Point(14, 12);
            this.createTeamLabel.Name = "createTeamLabel";
            this.createTeamLabel.Size = new System.Drawing.Size(333, 45);
            this.createTeamLabel.TabIndex = 2;
            this.createTeamLabel.Text = "Create Team Member:";
            this.createTeamLabel.Click += new System.EventHandler(this.createTeamLabel_Click);
            // 
            // newTeamMemberGroupBox
            // 
            this.newTeamMemberGroupBox.Controls.Add(this.createMemberButton);
            this.newTeamMemberGroupBox.Controls.Add(this.emailAddTextbox);
            this.newTeamMemberGroupBox.Controls.Add(this.emailAddressLabel);
            this.newTeamMemberGroupBox.Controls.Add(this.lastNameTextBox);
            this.newTeamMemberGroupBox.Controls.Add(this.lastNameLabel);
            this.newTeamMemberGroupBox.Controls.Add(this.firstNameText);
            this.newTeamMemberGroupBox.Controls.Add(this.firstNameLabel);
            this.newTeamMemberGroupBox.ForeColor = System.Drawing.Color.Maroon;
            this.newTeamMemberGroupBox.Location = new System.Drawing.Point(14, 85);
            this.newTeamMemberGroupBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.newTeamMemberGroupBox.Name = "newTeamMemberGroupBox";
            this.newTeamMemberGroupBox.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.newTeamMemberGroupBox.Size = new System.Drawing.Size(649, 515);
            this.newTeamMemberGroupBox.TabIndex = 9;
            this.newTeamMemberGroupBox.TabStop = false;
            this.newTeamMemberGroupBox.Text = "Add New Team Member";
            // 
            // createMemberButton
            // 
            this.createMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createMemberButton.Location = new System.Drawing.Point(471, 367);
            this.createMemberButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.createMemberButton.Name = "createMemberButton";
            this.createMemberButton.Size = new System.Drawing.Size(133, 52);
            this.createMemberButton.TabIndex = 10;
            this.createMemberButton.Text = "Create Member";
            this.createMemberButton.UseVisualStyleBackColor = true;
            this.createMemberButton.Click += new System.EventHandler(this.createMemberButton_Click);
            // 
            // emailAddTextbox
            // 
            this.emailAddTextbox.Location = new System.Drawing.Point(161, 181);
            this.emailAddTextbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.emailAddTextbox.Name = "emailAddTextbox";
            this.emailAddTextbox.Size = new System.Drawing.Size(230, 27);
            this.emailAddTextbox.TabIndex = 14;
            // 
            // emailAddressLabel
            // 
            this.emailAddressLabel.AutoSize = true;
            this.emailAddressLabel.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.emailAddressLabel.ForeColor = System.Drawing.Color.Red;
            this.emailAddressLabel.Location = new System.Drawing.Point(7, 177);
            this.emailAddressLabel.Name = "emailAddressLabel";
            this.emailAddressLabel.Size = new System.Drawing.Size(148, 30);
            this.emailAddressLabel.TabIndex = 13;
            this.emailAddressLabel.Text = "Email Address";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(161, 109);
            this.lastNameTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(230, 27);
            this.lastNameTextBox.TabIndex = 12;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lastNameLabel.ForeColor = System.Drawing.Color.Red;
            this.lastNameLabel.Location = new System.Drawing.Point(7, 109);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(114, 30);
            this.lastNameLabel.TabIndex = 11;
            this.lastNameLabel.Text = "Last Name";
            // 
            // firstNameText
            // 
            this.firstNameText.Location = new System.Drawing.Point(161, 51);
            this.firstNameText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.firstNameText.Name = "firstNameText";
            this.firstNameText.Size = new System.Drawing.Size(230, 27);
            this.firstNameText.TabIndex = 10;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.firstNameLabel.ForeColor = System.Drawing.Color.Red;
            this.firstNameLabel.Location = new System.Drawing.Point(7, 51);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(117, 30);
            this.firstNameLabel.TabIndex = 9;
            this.firstNameLabel.Text = "First Name";
            this.firstNameLabel.Click += new System.EventHandler(this.teamOneScore_Click);
            // 
            // Create_Team
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.newTeamMemberGroupBox);
            this.Controls.Add(this.createTeamLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Create_Team";
            this.Text = "Create_Team";
            this.newTeamMemberGroupBox.ResumeLayout(false);
            this.newTeamMemberGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label createTeamLabel;
        private GroupBox newTeamMemberGroupBox;
        private TextBox firstNameText;
        private Label firstNameLabel;
        private TextBox lastNameTextBox;
        private Label lastNameLabel;
        private TextBox emailAddTextbox;
        private Label emailAddressLabel;
        private Button createMemberButton;
    }
}