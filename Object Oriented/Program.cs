// -------------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Aniket Kamble"/>
// ---------------------------------------------------------------------------------------------------------------------------
namespace Object_Oriented
{
    using System;
    using System.Text.RegularExpressions;
    using Stock;

   public  class Program
    {
        static void Main(string[] args)
        {
            int flag=0;
            try
            {
                do
                {
                    Console.WriteLine("*** List Of Programs ***\n1:Inventory Detais\n2:Regular Expression Demonstration\n3:Stock Report\n4:Inventory Management Program\n5:Deck Of Cards\n6:Deck Of Card Using Queue\n7:Address Book");
                    Console.WriteLine("Enter The Choice");
                    int choice = int.Parse(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            InventoryDetails.InventoryInfo.PrintTotalData();
                            Console.ReadKey();
                            break;
                        case 2:
                            RegularExpresstion exp = new RegularExpresstion();
                            exp.Operation();
                            Console.ReadKey();
                            break;
                        case 3:
                            StockPortfolio.StockShare();
                            break;
                        case 4:
                            InventoryFactory.Manage();
                            Console.ReadKey();
                            break;
                        case 5:
                            DeckOfCard.Card();
                            break;
                        case 6:
                            CardQueue.CardInQueue();
                            break;
                        case 7:
                            AddressBook.AddressBookDetails();
                            break;
                        default:
                            break;
                    }
                    Console.WriteLine("ENTER 0 for continue");
                    flag = int.Parse(Console.ReadLine());
                } while (flag == 0);
            }
            catch (Exception)
            {
                Console.WriteLine("Please Insert Correct Input");
                Console.ReadKey();
            }
            }
            
    }
}