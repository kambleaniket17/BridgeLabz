using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Object_Oriented.Test;
using Newtonsoft.Json.Linq;
using static Object_Oriented.Inventory_Data_Management.Inventory;

namespace Object_Oriented.Test
{
    public class InventoryInfo
    {
        public static void JsonInventory()
        {
           // Inventory inventory = new Inventory();
            string information = File.ReadAllText("E:/New Bridge/Object Oriented/Inventory.json");
             var json = JObject.Parse(information);
             JArray array = (JArray)json["Rice"];
             Console.WriteLine("*** Rice Details: ***");
             foreach(var rice in array)
             {
                 Console.WriteLine("Name:"+rice["name"].ToString());
                 Console.WriteLine("price:"+ rice["price"]);
                 Console.WriteLine("Weight:" + rice["weight"].ToString());
                 var a = rice["price"];
                a = rice["0"];
                 Console.WriteLine();
             }
             Console.WriteLine("*** Pulses Details: ***");
             array = (JArray)json["Pulses"];
             foreach (var pulses in array)
             {
                 Console.WriteLine("Name:" + pulses["name"].ToString());
                 Console.WriteLine("price:" + pulses["price"]);
                 Console.WriteLine("Weight:" + pulses["weight"].ToString());
                 Console.WriteLine();
             }
             Console.WriteLine("*** Wheats Details: ***");
             var wheats = json["Wheats"];

                 Console.WriteLine("Name:" + wheats["name"].ToString());
                 Console.WriteLine("price:" + wheats["price"]);
                 Console.WriteLine("Weight:" + wheats["weight"].ToString());
        }
    }
    }

