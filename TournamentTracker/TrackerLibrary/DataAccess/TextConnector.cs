using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Model;
using TrackerLibrary.DataAccess.TextHelper;

namespace TrackerLibrary.DataAccess
{
    public class TextConnector : IDataConnection
    {

        private const string PrizesFile = "PrizeModels.csv";
        //TODO Wire up the CreatePrize for text files.
        /// <summary>
        /// Saves  a new prize to the database
        /// </summary>
        /// <param name="model">The prize information</param>
        /// <returns>returns the prize information including the unique identifier</returns>
        public PrizeModel CreatePrize(PrizeModel model)
        {
            //throw new NotImplementedException();
            //  model.Id = 1;
            //return model;


            //Read Text File
            //Convert Text to List <PrizeModel>

           
            //Load text file and convert the text to PrizeModel List
            List<PrizeModel> prizes = PrizesFile.FullPathFile().LoadFile().ConvertToPrizeModel();

            int currentId = 1;
            if(prizes.Count > 0)
            {
                currentId= prizes.OrderByDescending(x => x.Id).First().Id + 1;
            }
            //Find the ID
            model.Id = currentId;
            //Add the New Reacprd with the new ID (max+1)
            prizes.Add(model);


            //Convert the prizes to list<string>
            //save the list<string> to the text file
            prizes.SaveToPrizeFile(PrizesFile);

            return model;

        }
    }
}
