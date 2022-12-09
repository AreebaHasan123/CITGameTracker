using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class MatchupModel
    {
        private List<MatchupEntry> entries = new List<MatchupEntry>();

        public TeamModel Winner { get; set; }

        public int GivenRound { get; set; }

    }
}
