// -------------------------------------------------------------------------------------------------------------------------
// <copyright file="InventoryManager.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Aniket Kamble"/>
// ---------------------------------------------------------------------------------------------------------------------------
namespace Object_Oriented
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using Newtonsoft.Json;

    /// <summary>
    /// Inventory management will keep track of the inventory items
    /// </summary>
    public class InventoryManager
    {
        /// <summary>
        /// The inventory
        /// </summary>
        private IList<InventoryManager> inventory = new List<InventoryManager>();

        /// <summary>
        /// The constants
        /// </summary>
        private Files files = new Files();

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the weight.
        /// </summary>
        /// <value>
        /// The weight.
        /// </value>
        public double Weight { get; set; }

        /// <summary>
        /// Gets or sets the price per kg.
        /// </summary>
        /// <value>
        /// The price per kg.
        /// </value>
        public double Price { get; set; }

        /// <summary>
        /// Reads the file.
        /// </summary>
        /// <param name="fileName">Name of the file.</param>
        /// <returns> string return type </returns>
        public static string ReadingFile(string file)
        {
            using (StreamReader streamReader = new StreamReader(file))
            {
                string json = streamReader.ReadToEnd();
                streamReader.Close();
                return json;
            }
        }

        /// <summary>
        /// Inventories the management data.
        /// </summary>
        public void InventoryManage()
        {
            try
            {
                Console.WriteLine("******");
                using (StreamReader streamReader = new StreamReader(this.files.InventoryManage))
                {
                    string json = streamReader.ReadToEnd();
                    this.inventory = JsonConvert.DeserializeObject<List<InventoryManager>>(json);
                    streamReader.Close();
                }

                foreach (var items in this.inventory)
                {
                    Console.WriteLine(items.Id + "\t" + items.Name + "\t" + items.Weight + "\t" + items.Price);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// Adds to inventory.
        /// </summary>
        public void AddInventory()
        {
            try
            {
                Console.WriteLine("Enter name of the item");
                string name = Console.ReadLine();
                Console.WriteLine("Enter Weight");
                double weight = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter the price");
                double price = Convert.ToDouble(Console.ReadLine());
                InventoryManager manager = new InventoryManager()
                {
                    Name = name,
                    Weight = weight,
                    Price = price
                };

                string data = InventoryManager.ReadingFile(this.files.InventoryManage);
                this.inventory = JsonConvert.DeserializeObject<List<InventoryManager>>(data);
                this.inventory.Add(manager);
                var serializeJson = JsonConvert.SerializeObject(this.inventory);
                File.WriteAllText(this.files.InventoryManage, serializeJson);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// Updates the inventory data.
        /// </summary>
        public void UpdateInventory()
        {
            try
            {
                string data = InventoryManager.ReadingFile(this.files.InventoryManage);
                IList<InventoryManager> inventoryinfo = JsonConvert.DeserializeObject<List<InventoryManager>>(data);
                foreach (var inventoryItem in inventoryinfo)
                {
                    Console.WriteLine(inventoryItem.Id + "\t" + inventoryItem.Name + "\t" + inventoryItem.Weight + "\t" + inventoryItem.Price);
                }

                Console.WriteLine("Enter the Id for update");
                int id = Convert.ToInt32(Console.ReadLine());
                foreach (var item in inventoryinfo)
                {
                    while (id == item.Id)
                    {
                        Console.WriteLine(item.Id + "\t" + item.Name + "\t" + item.Weight + "\t" + item.Price);
                        break;

                    }
                }

                Console.WriteLine("Enter 1 to change the price \n Enter 2 to change weight");
                int choice = Convert.ToInt32(Console.ReadLine());
                int newPrice = 0;
                int newWeight = 0;
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter new Price");
                        newPrice = Convert.ToInt32(Console.ReadLine());
                        foreach (var item in inventoryinfo)
                        {
                            while (id == item.Id)
                            {
                                item.Price = newPrice;
                                break;
                            }
                        }

                        break;
                    case 2:
                        Console.WriteLine("Enter new Price");
                        newWeight = Convert.ToInt32(Console.ReadLine());
                        foreach (var item in inventoryinfo)
                        {
                            while (id == item.Id)
                            {
                                item.Weight = this.Weight;
                                break;
                            }
                        }

                        break;
                }

                var serializeJson = JsonConvert.SerializeObject(inventoryinfo);
                File.WriteAllText(this.files.InventoryManage, serializeJson);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// Deletes this instance.
        /// </summary>
        public void Delete()
        {
            try
            {
                string data = InventoryManager.ReadingFile(this.files.InventoryManage);
                IList<InventoryManager> inventoryDetails = JsonConvert.DeserializeObject<List<InventoryManager>>(data);

                foreach (var items in inventoryDetails)
                {
                    Console.WriteLine(items.Id + "\t" + items.Name + "\t" + items.Weight + "\t" + items.Price);
                }

                Console.WriteLine("Enter the Id to Delete");
                int id = Convert.ToInt32(Console.ReadLine());
                foreach (var item in inventoryDetails)
                {
                    while (id == item.Id)
                    {
                        Console.WriteLine(item.Id + "\t" + item.Name + "\t" + item.Weight + "\t" + item.Price);
                        break;
                    }
                }

                foreach (var item in inventoryDetails)
                {
                    while (id == item.Id)
                    {
                        inventoryDetails.Remove(item);
                        break;
                    }
                }

                var serializeJson = JsonConvert.SerializeObject(inventoryDetails);
                File.WriteAllText(this.files.InventoryManage, serializeJson);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}