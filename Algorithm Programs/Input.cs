// -------------------------------------------------------------------------------------------------------------------------
// <copyright file="Input.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Aniket Kamble"/>
// ---------------------------------------------------------------------------------------------------------------------------
namespace Algorithm_Programs
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text;

    /// <summary>
    /// Give Input to the Programs
    /// </summary>
    public class Input
    {
        /// <summary>
        /// Inputs the Binary for int.
        /// </summary>
        public static void InputBinaryforInt()
        {
            long startTimer = Utility.Start();
            Console.WriteLine("Enter The Number Of Input");
            int size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];
            Console.WriteLine("Enter The Elements");
            for (int i = 0; i <= arr.Length - 1; i++)
            {
                ////Read Elements
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Enter The Key Element which want to Search");
            int key = int.Parse(Console.ReadLine());
            int result = Utility.BinarySearch(arr, key);
            if (result != -1)
            {
                Console.WriteLine("Element Found");
            }
            else
            {
                Console.WriteLine("Element Is not Found");
            }

            long endTimer = Utility.Stop();
            long elapseTime = endTimer - startTimer;
            Console.WriteLine("ElapseTime=" + elapseTime);
        }

        /// <summary>
        /// Inputs the Binary for string.
        /// </summary>
        public static void InputBinaryforString()
        {
            long startTimer = Utility.Start();
            Console.WriteLine("Enter The Number Of Input");
            int size = int.Parse(Console.ReadLine());
            string[] arr = new string[size];
            Console.WriteLine("Enter The Elements");
            for (int i = 0; i <= arr.Length - 1; i++)
            {
                ////Store The Elements In Array
                arr[i] = Console.ReadLine();
            }

            Array.Sort(arr);
            Console.WriteLine("Enter The Key Element which want to Search");
            string key = Console.ReadLine();
            int result = Utility.BinarySearch(arr, key);
            if (result != -1)
            {
                Console.WriteLine("Element Found");
            }
            else
            {
                Console.WriteLine("Element Is not Found");
            }

            long endTimer = Utility.Stop();
            long elapseTime = endTimer - startTimer;
            Console.WriteLine("ElapseTime=" + elapseTime);
        }

        /// <summary>
        /// Inputs the insertion for int.
        /// </summary>
        public static void InputInsertionforInt()
        {
            long startTime = Utility.Start();
            Console.WriteLine("Enter Number Of Elements For Sorting");
            int size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];
            Console.WriteLine("Enter Input Integer values");
            for (int i = 0; i <= arr.Length - 1; i++)
            {
                ////Store Elements In Array
                arr[i] = int.Parse(Console.ReadLine());
            }

            int[] result = Utility.Insertion(arr);
            Console.WriteLine("Sorted Array is:");
            for (int i = 0; i <= result.Length - 1; i++)
            {
                ////Sorted Array
                Console.WriteLine(result[i]);
            }

            long endTime = Utility.Stop();
            long elapseTime = endTime - startTime;
            Console.WriteLine("Elapse Time=" + elapseTime);
        }

        /// <summary>
        /// Inputs the insertion for string.
        /// </summary>
        public static void InputInsertionforString()
        {
            long starttime = Utility.Start();
            Console.WriteLine("Enter Number Of Elements For Sorting");
            int size = int.Parse(Console.ReadLine());
            string[] arr = new string[size];
            Console.WriteLine("Enter Input Strings");
            for (int i = 0; i <= arr.Length - 1; i++)
            {
                ////Storing Elements
                arr[i] = Console.ReadLine();
            }

            string[] result = Utility.Insertion(arr);
            Console.WriteLine("Sorted Array is:");
            for (int i = 0; i <= result.Length - 1; i++)
            {
                ////Sorted Array
                Console.WriteLine(result[i]);
            }

            long endtime = Utility.Stop();
            long elapseTime = endtime - starttime;
            Console.WriteLine("elapseTime=" + elapseTime);
        }

        /// <summary>
        /// Inputs the bubble sort for int.
        /// </summary>
        public static void InputBubbleSortforInt()
        {
            long startTime = Utility.Start();
            Console.WriteLine("Enter Number Of Elements For Sorting");
            int size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];
            Console.WriteLine("Enter Input Integer values");
            for (int i = 0; i <= arr.Length - 1; i++)
            {
                ////Store Data
                arr[i] = int.Parse(Console.ReadLine());
            }

            int[] result = Utility.BubbleSort(arr);
            Console.WriteLine("Sorted Array is:");
            for (int i = 0; i <= result.Length - 1; i++)
            {
                ////print The Sorted Array
                Console.WriteLine(result[i]);
            }

            long endTime = Utility.Stop();
            long elapseTime = endTime - startTime;
            Console.WriteLine("Elapse Time=" + elapseTime);
        }

        /// <summary>
        /// Inputs the bubble sort for string.
        /// </summary>
        public static void InputBubbleSortforString()
        {
            long startTime = Utility.Start();
            Console.WriteLine("Enter Number Of Elements For Sorting");
            int size = int.Parse(Console.ReadLine());
            string[] arr = new string[size];
            Console.WriteLine("Enter Input Integer values");
            for (int i = 0; i <= arr.Length - 1; i++)
            {
                ////Store Elements
                arr[i] = Console.ReadLine();
            }

            string[] result = Utility.BubbleSort(arr);
            Console.WriteLine("Sorted Array is:");
            for (int i = 0; i <= result.Length - 1; i++)
            {
                ////Prints Sorted Array
                Console.WriteLine(result[i]);
            }

            long endTime = Utility.Stop();
            long elapseTime = endTime - startTime;
            Console.WriteLine("Elapse Time=" + elapseTime);
        }

        /// <summary>
        /// Binaries the search using file.
        /// </summary>
        public static void BinarySearchUsingFile()
        {
            string array = File.ReadAllText(@"D:\Input for Binary Search.txt");
                string[] str = array.Split(' ');
            for (int i = 0; i <= str.Length - 1; i++)
            {
                ////Prints The Data In File
                str[i].Trim();
                Console.WriteLine("Array is" + str[i]);
            }

            Array.Sort(str);
            Console.WriteLine("Enter The String For Searching");
            string key = Console.ReadLine();
            int result = Utility.BinarySearch(str, key);
            if (result != -1)
            {
                Console.WriteLine("Element Found");
            }
            else
            {
                Console.WriteLine("Element Not Found");
            }
        }

        /// <summary>
        /// Bubbles the sort using file.
        /// </summary>
        public static void BubbleSortUsingFile()
        {
            string array = File.ReadAllText(@"D:\Input for Bubble Sort.txt");

            string[] str = array.Split(' ');

            Console.WriteLine("Array is=");
            for (int i = 0; i <= str.Length - 1; i++)
            {
                ////Print The Array Without Sorting
                str[i].Trim();
                Console.WriteLine(str[i]);
            }

            string[] result = Utility.BubbleSort(str);
            Console.WriteLine("Sorted Array=");
            for (int i = 0; i <= result.Length - 1; i++)
            {
                ////Print The Sorted Array
                str[i].Trim();
                Console.WriteLine(result[i]);
            }
        }

        /// <summary>
        /// Inputs to binary.
        /// </summary>
        /// <returns>Provide Input for Binary Formation And return binary Digits</returns>
        public static string InputToBinary()
        {
            Console.WriteLine("Enter The number For Binary Conversion");
            int number = int.Parse(Console.ReadLine());
            string result = Utility.ToBinary(number);
            return result;
        }

        /// <summary>
        /// Prints the binary digit.
        /// </summary>
        public static void PrintBinaryDigit()
        {
            string result = Input.InputToBinary();
            Console.WriteLine("Binary digits =" + result);
        }

        /// <summary>
        /// Merges the sort.
        /// </summary>
        public static void MergeSort()
        {
            Console.WriteLine("Enter the number of Elements For Merge Sort");
            int size = int.Parse(Console.ReadLine());
            string[] array = new string[size];
            Console.WriteLine("Enter The Elements");
            for (int i = 0; i <= size - 1; i++)
            {
                ////Storing Elements in Array
                array[i] = Console.ReadLine();
            }

            string[] result = Utility.MergeSort(array);
            for (int i = 0; i <= result.Length - 1; i++)
            {
                Console.WriteLine("Sorted Array is" + result[i]);
            }
        }
    }
}