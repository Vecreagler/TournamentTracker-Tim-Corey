using System;
using System.Collections.Generic;
using System.Text;
using TrackerLibrary.Models;
using TrackerLibrary.DataAccess.TextHelpers;
using System.Linq;

namespace TrackerLibrary.DataAccess
{
    public class TextConnector : IDataConnection
    {
        private const string PrizesFile = "PrizeModels.csv";

        public PrizeModel CreatePrize(PrizeModel model)
        {

            List<PrizeModel> prizes = PrizesFile.FullFilePath().LoadFile().ConvertToPrizeModels();

            int currentID = 1;
            if(prizes.Count >0)
            { 
                currentID = prizes.OrderByDescending(x => x.ID).First().ID + 1; 
            }
            // int maxId = prizes.Max(p => p.Id) better way to do that 


            model.ID = currentID;
            prizes.Add(model);

            prizes.SaveToPrizeFile(PrizesFile);

            return model;

        }
    }
}
