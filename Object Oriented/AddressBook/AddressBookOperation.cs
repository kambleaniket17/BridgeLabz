// -------------------------------------------------------------------------------------------------------------------------
// <copyright file="AddressBookOperation.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Aniket Kamble"/>
// ---------------------------------------------------------------------------------------------------------------------------
namespace Object_Oriented
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text.RegularExpressions;
    using Newtonsoft.Json;

    /// <summary>
    /// Address Operation
    /// </summary>
    public class AddressBookOperation
    {
        /// <summary>
        /// Reads the file.
        /// </summary>
        /// <param name="path">The file.</param>
        /// <returns>returns the list</returns>
        public static string ReadFile(string file)
        {
            using (StreamReader streamReader = new StreamReader(file))
            {
                string json = streamReader.ReadToEnd();
                streamReader.Close();
                return json;
            }
        }

        /// <summary>
        /// Adds the person.
        /// </summary>
        public void AddPerson()
        {
            try
            {
                Files files = new Files();
                IList<AddressBookDetails> addressBook = new List<AddressBookDetails>();
                Console.WriteLine("enter first name");
                string firstname = Console.ReadLine();
                Console.WriteLine("enter last name");
                string lastname = Console.ReadLine();
                Console.WriteLine("enter address");
                string address = Console.ReadLine();
                Console.WriteLine("enter city");
                string city = Console.ReadLine();
                Console.WriteLine("enter state");
                string state = Console.ReadLine();
                Console.WriteLine("enter zip");
                string zip = Console.ReadLine();
                Console.WriteLine("enter phone number");
                string phoneNumber = Console.ReadLine();
                    AddressBookDetails addressBookDetails = new AddressBookDetails()
                    {
                        FirstName = firstname,
                        LastName = lastname,
                        Address = address,
                        City = city,
                        State = state,
                        ZipCode = zip,
                        PhoneNumber = phoneNumber
                    };
                    string file = AddressBookOperation.ReadFile(files.Address);
                    addressBook = JsonConvert.DeserializeObject<List<AddressBookDetails>>(file);
                    addressBook.Add(addressBookDetails);
                    var serializedJson = JsonConvert.SerializeObject(addressBook);
                    File.WriteAllText(files.Address, serializedJson);
                    Console.WriteLine("new person added");
                    this.PrintAddressBook();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        
        /// <summary>
        /// Prints the address book.
        /// </summary>
        public void PrintAddressBook()
        {
            try
            {
                Files files = new Files();
                IList<AddressBookDetails> addressBook = new List<AddressBookDetails>();
                using (StreamReader stream = new StreamReader(files.Address))
                {
                    string data = stream.ReadToEnd();
                    stream.Close();
                    addressBook = JsonConvert.DeserializeObject<List<AddressBookDetails>>(data);
                    foreach (var items in addressBook)
                    {
                        Console.Write(items.FirstName + "\t" + items.LastName + "\t" + items.Address + "\t" + items.City + "\t" + items.State + "\t" + items.ZipCode + "\t" + items.PhoneNumber);
                        Console.WriteLine();
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}