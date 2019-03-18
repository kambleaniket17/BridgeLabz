// -------------------------------------------------------------------------------------------------------------------------
// <copyright file="InventoryInfo.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Aniket Kamble"/>
// ---------------------------------------------------------------------------------------------------------------------------
namespace Object_Oriented.InventoryDetails
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text;
    using Newtonsoft.Json.Linq;
    using System.Reflection.Metadata;

    /// <summary>
    /// Inventory Info
    /// </summary>
    public class InventoryInfo
    {

        /// <summary>
        /// inventory data managements this instance
        /// </summary>
        public static void PrintTotalData()
        {
            /// Reads the file and Display
            InventoryInfo printsDetailsOfInventory = new InventoryInfo();
            Files constants = new Files();
            IList<Inventory> data = printsDetailsOfInventory.ReadFile(constants.inventoryProducts);
            Console.WriteLine("Name\tweight\tRate\tAmount");
            foreach (var dataInfo in data)
            {
                Console.WriteLine("{0}" + "\t" + "{1}" + " \t" + "{2}" + "\t" + "{3}", dataInfo.Name, dataInfo.Weight, dataInfo.Price, dataInfo.Price * dataInfo.Weight);
            }
        }

        public List<Inventory> ReadFile(string fileName)
        {
            ////read from the file
            using (StreamReader r = new StreamReader(fileName))
            {
                var json = r.ReadToEnd();
                var items = JsonConvert.DeserializeObject<List<Inventory>>(json);
                return items;
            }
        }
    }
    }

