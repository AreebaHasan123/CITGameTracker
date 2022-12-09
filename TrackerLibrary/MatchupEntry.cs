using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;

namespace TrackerLibrary
{
    public class MatchupEntry
    {
        /// <summary>
        /// represents one team in the matchup
        /// </summary>
        public TeamModel TeamCompeting { get; set; }

        /// <summary>
        /// represents the score for a specific team
        /// </summary>
        public double Score { get; set; }

        public MatchupModel ParentMatchup { get; set; }
    }
}
