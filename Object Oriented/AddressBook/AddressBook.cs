// -------------------------------------------------------------------------------------------------------------------------
// <copyright file="AddressBook.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Aniket Kamble"/>
// ---------------------------------------------------------------------------------------------------------------------------
namespace Object_Oriented
{
    using System;

    /// <summary>
    /// adress Class
    /// </summary>
    public class AddressBook
    {
        /// <summary>
        /// Addresses the book
        /// </summary>
        /// <exception cref="Exception">exception</exception>
        public static void AddressBookDetails()
        {
            try
            {
                int Condition;
                string check = null;
                do
                {
                    Console.WriteLine("enter 1 for add person");
                    Console.WriteLine("enter 2 for print address book");
                    Condition = Convert.ToInt32(Console.ReadLine());
                   AddressBookOperation adressbookOperation = new AddressBookOperation();
                    switch (Condition)
                    {
                        case 1:
                            adressbookOperation.AddPerson();
                            break;
                        case 2:
                            adressbookOperation.PrintAddressBook();
                            break; 
                    }

                    Console.WriteLine("enter y to continue");
                    check = Console.ReadLine();
                }
                while (check.Equals("y"));
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}