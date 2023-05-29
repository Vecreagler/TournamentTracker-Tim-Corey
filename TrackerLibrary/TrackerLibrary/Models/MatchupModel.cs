﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary.Models
{
    public class MatchupModel
    {
        public int ID { get; set; }
        public List<MatchupEntryModel> Entries { get; set; } = new List<MatchupEntryModel>();
        public int WinnerId { get; set; }
        public TeamModel Winner { get; set; }
        public int MatchupRound { get; set; }
    }
}
