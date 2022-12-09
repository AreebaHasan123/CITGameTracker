using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;
using TrackerLibrary.DataAccess.TextHelpers;

namespace TrackerLibrary.DataAccess
{
    public class TextConnection : IDataConnection

    {
        private const string WinnersFile = "Winners.csv";
        private const string TeamsFile = "Teams.csv";
        private const string TeamsModelFile = "TeamsModel.csv";

        public TeamMember createPerson(TeamMember model)
        {
            List<TeamMember> teams = TeamsFile.FullFilePath().LoadFile().ConvertToTeamModels();
            int currentID = 1;
            if(teams.Count > 0)
            {
                currentID = teams.OrderByDescending(t => t.ID).First().ID+1;
            }
            model.ID = currentID;
            currentID += 1;
            teams.Add(model);
            teams.SaveToTeamFiles(TeamsFile);
            return model;
        }

        public List<TeamMember> GetEachMember()
        {
            return TeamsFile.FullFilePath().LoadFile().ConvertToTeamModels();
        }

        public WinnersModel createWinners(WinnersModel model)
        {
            //throw new NotImplementedException();
            //Load text file  //Convert text to List
            List<WinnersModel> winners = WinnersFile.FullFilePath().LoadFile().ConvertToWinnerModels();
            int currentID = 1;

            if (winners.Count > 0)
            {
                currentID = winners.OrderByDescending(x => x.ID).First().ID + 1;
            }

            model.ID = currentID;
            //Find the max ID
            currentID += 1;
            winners.Add(model);

            winners.SaveToPrizeFiles(WinnersFile);

            return model;

            //Save the list to the text file
        }

       

      
    }
}
