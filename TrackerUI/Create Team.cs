using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.DataAccess;

namespace TrackerUI
{
    public partial class Create_Team : Form

    {

        public Create_Team()
        {
            InitializeComponent();
            CreateSampleData();
           
        }


        private List<TeamMember> availableTeamMembers = new List<TeamMember>();
        private List<TeamMember> selectedTeamMembers = new List<TeamMember>();

    private void CreateSampleData()
        {
            availableTeamMembers.Add(new TeamMember { FirstName = "Areeba", LastName = "Hasan" });
            availableTeamMembers.Add(new TeamMember { FirstName = "Mark", LastName = "Johnson" });

            selectedTeamMembers.Add(new TeamMember { FirstName = "Daniel", LastName = "Hancock" });
            selectedTeamMembers.Add(new TeamMember { FirstName = "Rashi", LastName = "Tyagi" });
        }
      
        private void selectTeamLabel_Click(object sender, EventArgs e)
        {

        }

        private void teamOneScore_Click(object sender, EventArgs e)
        {

        }

        private void createMemberButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                TeamMember p = new TeamMember();
                p.FirstName=firstNameText.Text;
                p.LastName=lastNameTextBox.Text;
                p.EmailAddress=emailAddTextbox.Text;

                foreach (IDataConnection db in GlobalConfig.Connection)
                {
                    db.createPerson(p);
                }

                firstNameText.Text = "";
                lastNameTextBox.Text = "";
                emailAddTextbox.Text = "";

            }
            else
            {
                MessageBox.Show("You will need to fill in all of the fields.");
            }

        }

        private bool ValidateForm()
        {
            if(firstNameText.Text.Length == 0)
            {
                return false;
            }
            if (lastNameTextBox.Text.Length == 0)
            {
                return false;
            }
            if(emailAddTextbox.Text.Length == 0)
            {
                return false;
            }
            return true;
        }

        private void selectTeamComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void createTeamLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
