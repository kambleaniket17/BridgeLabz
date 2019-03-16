// -------------------------------------------------------------------------------------------------------------------------
// <copyright file="InputForCAshCounter.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Aniket Kamble"/>
// ---------------------------------------------------------------------------------------------------------------------------
namespace Data_Structure.BankingCashCounter
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Simulates Banking cash Counter
    /// </summary>
    public class InputForCashCounter
    {
        /// <summary>
        /// Counters this instance.
        /// </summary>
        public static void Counter()
        {
            try
            {
                string personName = string.Empty;
                int option = 0;
                Person[] personArray;
                int personNumber = 1;
                int numberOfPeople = 0;
                int balance = 0;

                Queue queue = new Queue();

                bool loopNumberOfPeople = true;
                while (loopNumberOfPeople)
                {
                    Console.WriteLine("Enter the Number of people in Queue");
                    string stringNumberOfPeople = Console.ReadLine();
                    if (Utility.IsNumber(stringNumberOfPeople) == false)
                    {
                        Console.WriteLine("Invalid Input ");
                        continue;
                    }

                    numberOfPeople = Convert.ToInt32(stringNumberOfPeople);
                    if (numberOfPeople <= 0)
                    {
                        Console.WriteLine("There must be atleast one person in Queue");
                        continue;
                    }

                    loopNumberOfPeople = false;
                }

                personArray = new Person[numberOfPeople];
                for (int i = 0; i < numberOfPeople; i++)
                {
                    bool loopPersonName = true;
                    while (loopPersonName)
                    {
                        Console.WriteLine("Enter the Name for the " + personNumber + " person");
                        personName = Console.ReadLine();

                        if (Utility.CheckString(personName))
                        {
                            Console.WriteLine("Please Provide a name");
                            continue;
                        }

                        if (Utility.ContainsCharacter(personName))
                        {
                            Console.WriteLine("No Characters allowed");
                            continue;
                        }

                        if (Utility.IsNumber(personName))
                        {
                            Console.WriteLine("Please provide a proper name");
                            continue;
                        }

                        loopPersonName = false;
                    }

                    bool loopForBalance = true;
                    while (loopForBalance)
                    {
                        Console.WriteLine("Enter the Balance for person " + personName);
                        string stringBalance = Console.ReadLine();

                        if (Utility.IsNumber(stringBalance) == false)
                        {
                            Console.WriteLine("invalid input");
                            continue;
                        }

                        balance = Convert.ToInt32(stringBalance);
                        loopForBalance = false;
                    }

                    personNumber++;

                    personArray[i] = new Person(personName, balance);
                }

                for (int i = 0; i < numberOfPeople; i++)
                {
                    queue.Enqueue(personArray[i]);
                }

                Console.WriteLine("All " + numberOfPeople + " people are Enqueued");

                int person = 0; //// this for accessing as index for personArray.

                bool loop = true;
                while (loop)
                {
                    Console.WriteLine("Person " + personArray[person].Name + " is at Counter");
                    Console.WriteLine("What do you want to do");
                    Console.WriteLine("1) deposite");
                    Console.WriteLine("2) withdraw");
                    Console.WriteLine("3) Check the Size of queue");
                    string stringOption = Console.ReadLine();

                    if (Utility.IsNumber(stringOption) == false)
                    {
                        Console.WriteLine("Please provide Correct input");
                        continue;
                    }

                    option = Convert.ToInt32(stringOption);
                    switch (option)
                    {
                        case 1:
                            {
                                TransactionInput.DepositeDetails(personArray[person]);
                                queue.Dequeue();
                                person = person + 1;

                                if (queue.CheckSize() == 0)
                                {
                                    loop = false;
                                }

                                break;
                            }

                        case 2:
                            {
                                TransactionInput.WithdrawlDetails(personArray[person]);
                                queue.Dequeue();
                                person = person + 1;
                                if (queue.CheckSize() == 0)
                                {
                                    loop = false;
                                }

                                break;
                            }

                        case 3:
                            {
                                int size = queue.CheckSize();
                                Console.WriteLine("There are " + size + " in queue");
                                break;
                            }

                        default:
                            {
                                Console.WriteLine("Invalid Input");
                                break;
                            }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
