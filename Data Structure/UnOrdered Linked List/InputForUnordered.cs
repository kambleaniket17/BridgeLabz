// -------------------------------------------------------------------------------------------------------------------------
// <copyright file="InputForUnordered.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Aniket Kamble"/>
// ---------------------------------------------------------------------------------------------------------------------------
namespace Data_Structure.LinkedList_UnOrdered_
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text;

    /// <summary>
    /// Takes input required for this class.
    /// </summary>
    public class InputForUnordered
    {
        /// <summary>
        /// Unordered LinkedList
        /// </summary>
        public static void UnOrderedList()
        {
            string path = string.Empty;
            SinglyLinkedList<string> singlyLinkedList = new SinglyLinkedList<string>();

            bool loopPath = true;
            while (loopPath)
            {
                Console.WriteLine("Specify the File path");
                path = Console.ReadLine();

                if (File.Exists(path) == false)
                {
                    Console.WriteLine("Specified Path does not exist");
                    continue;
                }

                loopPath = false;
            }

            string dataFromFile = File.ReadAllText(path);
            string[] splitArray = dataFromFile.Split(' ');

            foreach (string word in splitArray)
            {
                singlyLinkedList.Add(word.Trim());
            }

            Console.WriteLine("Enter the word you want to search");
            string wordToSearch = Console.ReadLine();

            if (singlyLinkedList.Contains(wordToSearch))
            {
                if (singlyLinkedList.Delete(wordToSearch))
                {
                    Console.WriteLine("Word " + wordToSearch + " has been removed ");
                }
            }
            else
            {
                singlyLinkedList.Add(wordToSearch);
                Console.WriteLine("The word " + wordToSearch + " not found , Added to linked list and written to file");
            }

            singlyLinkedList.WriteToFile(path);
            Console.Read();
        }
    }
}