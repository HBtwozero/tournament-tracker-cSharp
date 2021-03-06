﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.IO;
using TrackerLibrary.Model;

namespace TrackerLibrary.DataAccess.TextHelper
{
   public static class TextConnectorProcessor
    {

        //Read Text File
        //Convert Text to List <PrizeModel>
        //Find the ID
        //Add the New Reacprd with the new ID (max+1)
        //Convert the prizes to list<string>


        //save the list<string> to the text file
        public static string FullPathFile(this string filename) //priceModel.csv
        {

            //C:\Users\kangr\source\repos\tournament-tracker-cSharp\PrizeModel.csv
            return $"{ConfigurationManager.AppSettings["filePath"]}\\{filename}";
        }

        public static List<string> LoadFile(this string file)
        {
            if (!File.Exists(file))
            {
                return new List<string>();
            }

            return File.ReadAllLines(file).ToList();
        }

        public static List<PrizeModel> ConvertToPrizeModel(this List<string> lines)
        {
            List<PrizeModel> output = new List<PrizeModel>();

            foreach (string line in lines)
            {
                string[] cols = line.Split(',');

                PrizeModel p = new PrizeModel();

                p.Id = int.Parse(cols[0]);
                p.PlaceNumber = int.Parse(cols[1]);
                p.PlaceName = cols[2];
                p.PrizeAmount = decimal.Parse(cols[3]);
                p.PrizePercentage = double.Parse(cols[4]);
                output.Add(p);
            }

            return output;
                
        }

        public static void SaveToPrizeFile(this List<PrizeModel> models, string fileName)
        {
            List<string> lines = new List<string>();
            foreach(PrizeModel p in models)
            {
                lines.Add($"{p.Id}, {p.PlaceNumber}, {p.PrizeAmount}, {p.PrizePercentage}");

            }
            File.WriteAllLines(fileName.FullPathFile(), lines);
        }
    }
}
