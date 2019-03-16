// -------------------------------------------------------------------------------------------------------------------------
// <copyright file="Origin.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Aniket Kamble"/>
// ---------------------------------------------------------------------------------------------------------------------------
namespace Algorithm_Programs
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// main class for choose the programs
    /// </summary>
    public class Origin
    {
        /// <summary>
        /// Mains the specified arguments.
        /// </summary>
        /// <param name="args">The arguments.</param>
        public static void Main(string[] args)
        {
            int choice = 0;
            Console.WriteLine("1:Check Anagram\n2:Prime Numbers Bet 1000\n3:Prime Palindrome\n4:Prime Anagram\n5:Binary Sort For Integer\n6:Binary Sort for String\n" +
                "7:Insertion sort for String\n8:Insertion sort for Integer\n9:Calculate Day Of Week\n10:Temperature Conversion\n11:Monthly Payment\n12:" +
                "Squere Root\n13:Calculate Binary Numbers\n14:Bubble Sort For Integer\n15:Bubble Sort For String\n16:Binay Search For File\n17:" +
                "Bubble Sort Using File\n18:Calculate Notes\n19:binary Operation Swapping Nibbles\n20:Merge Sort");
            do
            {
                try
                {
                    Console.WriteLine("Enter Your Choice");
                    choice = int.Parse(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            Utility.CheckAnagram();
                            Console.ReadKey();
                            break;
                        case 2:
                            ArrayList list = Utility.PrimeNumbersbet1000();
                            Utility.ShowList(list);
                            Console.ReadKey();
                            break;
                        case 3:
                            Utility.PrimePalindrome();
                            break;
                        case 4:
                            Utility.PrimeAnagram();
                            Console.ReadKey();
                            break;
                        case 5:
                            Input.InputBinaryforInt();
                            Console.ReadKey();
                            break;
                        case 6:
                            Input.InputBinaryforString();
                            Console.ReadKey();
                            break;
                        case 7:
                            Input.InputInsertionforString();
                            Console.ReadKey();
                            break;
                        case 8:
                            Input.InputInsertionforInt();
                            Console.ReadKey();
                            break;
                        case 9:
                            Utility.DayOfWeek();
                            Console.ReadKey();
                            break;
                        case 10:
                            Utility.TemperaturConversion();
                            Console.ReadKey();
                            break;
                        case 11:
                            Utility.MonthlyPayment();
                            Console.ReadKey();
                            break;
                        case 12:
                            Utility.Sqrt();
                            Console.ReadKey();
                            break;
                        case 13:
                            Input.PrintBinaryDigit();
                            Console.ReadKey();
                            break;
                        case 14:
                            Input.InputBubbleSortforInt();
                            Console.ReadKey();
                            break;
                        case 15:
                            Input.InputBubbleSortforString();
                            Console.ReadKey();
                            break;
                        case 16:
                            Input.BinarySearchUsingFile();
                            Console.ReadKey();
                            break;
                        case 17:
                            Input.BubbleSortUsingFile();
                            Console.ReadKey();
                            break;
                        case 18:
                            VendingMachine.CalculateNotes();
                            Console.ReadKey();
                            break;
                        case 19:
                            Binary.SwapNibbles();
                            Console.ReadKey();
                            break;
                        case 20:
                            Input.MergeSort();
                            Console.ReadKey();
                            break;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Please Enter Correct Input");
                }
            }
            while (choice != 0);
        }
    }
}
