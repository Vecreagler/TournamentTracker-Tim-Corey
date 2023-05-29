using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary.Models
{
    public class MatchupEntryModel
    {
        public int ID { get; set; }
        public int TeamCompetingId { get; set; }
        public int ParentMatchupId { get; set; }
        public TeamModel TeamCompeting { get; set; }
        public double Score { get; set; }
        public MatchupModel ParentMatchup { get; set; }

        
    }
}
