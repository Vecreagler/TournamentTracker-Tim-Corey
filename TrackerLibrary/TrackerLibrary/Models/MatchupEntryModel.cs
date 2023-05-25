using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary.Models
{
    public class MatchupEntryModel
    {
        public int ID { get; set; }
        /// <summary>
        /// Represents one team 
        /// </summary>
        public TeamModel TeamCompeting { get; set; }

        /// <summary>
        /// Represents score for team
        /// </summary>
        public double Score { get; set; }

        /// <summary>
        /// Represents the matchup that this team
        /// came from as the winner
        /// </summary>
        public MatchupModel ParentMatchup { get; set; }

        
    }
}
