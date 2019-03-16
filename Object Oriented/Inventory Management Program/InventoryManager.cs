using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace Object_Oriented.Inventory_Management_Program
{
    public class InventoryManager
    {
        public static void manage()
        {
            InventoryFactory inventoryFactory = new InventoryFactory();
            JObject json = InventoryFactory.inventoryInfo();

            JArray jArray = (JArray)json["Rice"];

            foreach (JToken array in jArray)
            {
                Console.WriteLine("Price of Rice:" + array["price"]);
            }
            JToken wheat = json["Wheats"];
                Console.WriteLine("Price of Wheats:" + wheat["price"]);

            jArray = (JArray)json["Pulses"];

            foreach (JToken array in jArray)
            {
                Console.WriteLine("Price of Pulses:" + array["price"]);
                if(array.Equals("Price"))
                {
                    Console.WriteLine("Total="+"price[0]");
                }
            }
        }
    }
}