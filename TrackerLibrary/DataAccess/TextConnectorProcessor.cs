using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Microsoft.IdentityModel.Protocols;

namespace TrackerLibrary.DataAccess.TextHelpers
{
    public static class TextConnectorProcessor
    {
        public static string FullFilePath(this string fileName)
        {
            return $"{ConfigurationManager.AppSettings["filepath"]}\\{fileName}";
        }

        public static List<string> LoadFile(this string file)
        {
            if (!File.Exists(file))
            {
                return new List<string>();
            }
            return File.ReadLines(file).ToList();
        }

        public static List<WinnersModel> ConvertToWinnerModels(this List<string> lines)
        {
            List<WinnersModel> output = new List<WinnersModel>();

            foreach (string line in lines)
            {
                string[] cols = line.Split(',');

                WinnersModel w = new WinnersModel();
                w.ID = int.Parse(cols[0]);
                w.PlaceNumber = int.Parse(cols[1]);
                w.PlaceName = cols[2];
                w.PrizeAmount= decimal.Parse(cols[3]);
                w.PrizePercentage = double.Parse(cols[4]);
                output.Add(w);

            }
            return output;
        }

        public static List<TeamMember> ConvertToTeamModels(this List<string> lines)
        {
            List<TeamMember> output = new List<TeamMember>();

            foreach (string line in lines)
            {
                string[] cols = line.Split(',');

                TeamMember w = new TeamMember();
                w.FirstName = cols[0];
                w.LastName = cols[1];
                w.EmailAddress= cols[2];
                output.Add(w);

            }
            return output;
        }

        

        public static void SaveToPrizeFiles(this List<WinnersModel> models, string fileName)
        {
            List<string> lines = new List<string>();

            foreach (WinnersModel w in models)
            {
                lines.Add($"{w.ID}, {w.PlaceNumber}, {w.PlaceName}, {w.PrizeAmount}, {w.PrizePercentage}");
            }
            File.WriteAllLines(fileName.FullFilePath(), lines);
        }
        public static void SaveToTeamFiles(this List<TeamMember> models, string fileName)
        {
            List<string> lines = new List<string>();

            foreach (TeamMember w in models)
            {
                lines.Add($"{w.FirstName}, {w.LastName}, {w.EmailAddress}");
            }
            File.WriteAllLines(fileName.FullFilePath(), lines);
        }
        public static void SaveToFormTeamsFiles(this List<TeamModel> models, string fileName)
        {
            List<string> lines = new List<string>();

            foreach (TeamModel w in models)
            {
                lines.Add($"{w.TeamName}, {w.TeamMembers}");
            }
            File.WriteAllLines(fileName.FullFilePath(), lines);
        }

       
    }
}
