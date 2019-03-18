// -------------------------------------------------------------------------------------------------------------------------
// <copyright file="StockPortfolio.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Aniket Kamble"/>
// ---------------------------------------------------------------------------------------------------------------------------
namespace Object_Oriented.Stock
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text;

    /// <summary>
    /// StockPortfolio
    /// </summary>
    public class StockPortfolio
    {
        public static void StockShare()
        {
            ////creating obj for constant class
            Files constants = new Files();
            ////Creating one obj for stock model 
            IList<Stock> stockModels = new List<Stock>();
            ////the method Stock.ReadFile is called for reading the elements from the stock object
            stockModels = StockPortfolio.ReadFile(constants.StocInfo);
            Console.WriteLine("Id\t name\t availableshare\t price");
            ////looping the all element printend in the json file
            foreach (var item in stockModels)
            {
                Console.WriteLine("{0}" + "\t" + "{1}" + "\t" + "{2}" + "\t" + "{3}", item.id, item.name, item.shares, item.Price);
            }
        }
        /// <summary>
        /// Reads the file.
        /// </summary>
        /// <param name="fileName">Name of the file.</param>
        /// <returns>returns the elements in a stock object </returns>
        /// <exception cref="Exception"></exception>
        public static IList<Stock> ReadFile(string fileName)
        {
            try
            {
                using (StreamReader r = new StreamReader(fileName))
                {
                    var json = r.ReadToEnd();
                    /// deserialize data because it is in json format
                    var items = JsonConvert.DeserializeObject<List<Stock>>(json);
                    return items;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

    }
}

