// -------------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Aniket Kamble"/>
// ---------------------------------------------------------------------------------------------------------------------------
namespace Data_Structure
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Data_Structure.BalancedParenthses;
    using Data_Structure.BankingCashCounter;
    using Data_Structure.Calendar;
    using Data_Structure.CalendarQueue;
    using Data_Structure.LinkedList_Ordered_;
    using Data_Structure.LinkedList_UnOrdered_;
    using Data_Structure.PalindromChecker;
    using Data_Structure.PrimeAnagrams;
    using Data_Structure.PrimeAnagramStack;
    using Data_Structure.PrimeNumberIn2DArray;
    using Data_Structure.Test;
    using Data_Structure.PrimeAnagramQueue;
    ////using Data_Structure.PrimeAnagramQueue;

    /// <summary>
    /// Main Program Start
    /// </summary>
     public class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        public static void Main(string[] args)
        {
            int choice = 0;
            do
            {
                Console.WriteLine("1:UnOrdered Linked List\n2:Ordered Linked List\n3:Balanced Paranthesis\n4:Bank Cash Counter\n5:Palindrome Checker\n6:Calender\n7:Calender Queue\n8:2DPrime Number\n9:2D Prime Anagram\n10:Prime Anagram Using Stack" +
                    "\n11:Prime Anagram Using Queue");
                Console.WriteLine("Enter The Choice");
                try
                {
                    choice = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Please Enter Correct Input");
                }

                switch (choice)
                {
                    case 1:
                        InputForUnordered.UnOrderedList();
                        Console.ReadLine();
                        break;
                    case 2:
                        InputForOrdered.OrderedLinkedList();
                        break;
                    case 3:
                        InputForParentheses.CheckParentheses();
                        break;
                    case 4:
                        InputForCashCounter.Counter();
                        break;
                    case 5:
                        InputForPalindrome.CheckPalindrome();
                        Console.ReadKey();
                        break;
                    case 6:
                        InputForCalendar.StartCalender();
                        break;
                    case 7:
                        InputForCalendarQueue.StartCalendar();
                        Console.ReadKey();
                        break;
                    case 8:
                        _2DArrayPrimeNumber._2DArray();
                        Console.ReadKey();
                        break;
                    case 9:
                        _2DPrimeAnagrams.Print2DPrimeAnagram();
                        Console.ReadKey();
                        break;
                    case 10:
                        PrimeAnagramStack.InputForStack.Input();
                        break;
                    case 11:
                        PrimeAnagramQueue.InputForQueue.Input();
                        break;
                    default:
                        break;
                }
            }
            while (choice != 0);
        }
    }
}