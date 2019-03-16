namespace Object_Oriented
{
    using System;
    using System.Text.RegularExpressions;

   public  class Program
    {
        static void Main(string[] args)
        {
            char flag;
            try
            {
                do
                {
                    Console.WriteLine("*** List Of Programs ***\n1:Inventory Detais\n2:Regular Expression Demonstration\n3:Stock Report\n4:Inventory Management Program\n5:Deck Of Cards\n");
                    Console.WriteLine("Enter The Choice");
                    int choice = int.Parse(Console.ReadLine());

                    switch (choice)
                    {
                        case 0:
                            Test.InventoryInfo.JsonInventory();
                            Console.ReadKey();
                            break;
                        case 1:
                            Inventory_Data_Management.InventoryInfo.JsonInventory();
                            Console.ReadKey();
                            break;
                        case 2:
                            RegularExpresstion exp = new RegularExpresstion();
                            exp.Operation();
                            Console.ReadKey();
                            break;
                        case 3:
                            Testing.abc.test();
                            Console.ReadKey();
                            break;
                        case 4:
                            Inventory_Management_Program.InventoryManager.manage();
                            Console.ReadKey();
                            break;
                        case 5:
                            DeckOfCard.DeckOfCard.CardsInfo();

                            break;
                        default:
                            break;
                    }
                    Console.WriteLine("ENTER YES FOR Y AND NO FOR N");
                    flag = Convert.ToChar(Console.ReadLine());
                } while (flag == 'y' || flag == 'Y');
            }
            catch (Exception)
            {
                Console.WriteLine("Please Insert Correct Input");
                Console.ReadKey();
            }
            }
            
    }
}