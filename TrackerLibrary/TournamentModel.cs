using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class TournamentModel
    {
        public string TournName { get; set; }
        public List<TeamModel> TeamsList { get; set; } = new List<TeamModel>();

        public List<WinnersModel> WinnersModel { get; set; } = new List<WinnersModel>();

        public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>();


    }
}
