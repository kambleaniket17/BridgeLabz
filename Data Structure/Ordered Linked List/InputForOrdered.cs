// -------------------------------------------------------------------------------------------------------------------------
// <copyright file="InputForOrdered.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Aniket Kamble"/>
// ---------------------------------------------------------------------------------------------------------------------------
namespace Data_Structure.LinkedList_Ordered_
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text;

    /// <summary>
    /// Takes required inputs
    /// </summary>
    public class InputForOrdered
    {
        /// <summary>
        /// reads and writes to file
        /// </summary>
        public static void OrderedLinkedList()
        {
            try
            {
                string path = string.Empty;
                SinglyLinkedList singlyLinkedList = new SinglyLinkedList();

                bool loopPath = true;
                while (loopPath)
                {
                    Console.WriteLine("Specify the path");
                    path = Console.ReadLine();

                    if (File.Exists(path) == false)
                    {
                        Console.WriteLine("Specified Path does not exist");
                        Console.Read();
                        continue;
                    }

                    loopPath = false;
                }

                string dataFromFile = File.ReadAllText(path);
                string[] splitArray = dataFromFile.Split(' ');
                
                //// Array.Sort(splitArray);

                foreach (string word in splitArray)
                {
                    if (word.Trim() != string.Empty)
                    {
                        singlyLinkedList.Add(Convert.ToInt32(word.Trim()));
                    }
                }

                Console.WriteLine("Enter the number you want to search");
                string number = Console.ReadLine();
                int numberToSearch = Convert.ToInt32(number);

                if (singlyLinkedList.Contains(numberToSearch))
                {
                    if (singlyLinkedList.Delete(numberToSearch))
                    {
                        Console.WriteLine("Word " + numberToSearch + " has been removed ");
                    }
                }
                else
                {
                    singlyLinkedList.Add(numberToSearch);
                    Console.WriteLine("The word " + numberToSearch + " not found , Added to linked list and written to file");
                }

                singlyLinkedList.WriteToFile(path);
                Console.Read();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
