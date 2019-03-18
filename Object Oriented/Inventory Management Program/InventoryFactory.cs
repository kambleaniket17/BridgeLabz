// -------------------------------------------------------------------------------------------------------------------------
// <copyright file="InventoryFactory.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Aniket Kamble"/>
// ---------------------------------------------------------------------------------------------------------------------------
namespace Object_Oriented
{
    using System;

    /// <summary>
    /// Inventory operations method is calling class of all the methods
    /// </summary>
    public class InventoryFactory
    {
        /// <summary>
        /// Manages this instance.
        /// </summary>
        public static void Manage()
        {
            try
            {
                int ch;
                do
                {
                    InventoryManager inventory = new InventoryManager();
                    Console.WriteLine("** ** **");
                    Console.WriteLine("** Press 1 to Display Data from file **");
                    Console.WriteLine("** Press 2 to Add the data to file **");
                    Console.WriteLine("** Press 3 to Update the data in file **");
                    Console.WriteLine("** Press 4 to Remove the data in file");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            inventory.InventoryManage();
                            break;
                        case 2:
                            inventory.AddInventory();
                            break;
                        case 3:
                            inventory.UpdateInventory();
                            break;
                        case 4:
                            inventory.Delete();
                            break;
                    }

                    Console.WriteLine("Do you want to continue press 0");
                    ch = int.Parse(Console.ReadLine());
                }
                while (ch == 0);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
