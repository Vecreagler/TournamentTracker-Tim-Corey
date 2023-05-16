using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary
{
    public class MatchupEntryModel
    {
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
