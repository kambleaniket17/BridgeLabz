// -------------------------------------------------------------------------------------------------------------------------
// <copyright file="Utility.cs" company="Bridgelabz">
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
    /// Logics of Program
    /// </summary>
    public class Utility
    {
        /// <summary>
        /// Checks the anagram.
        /// </summary>
        public static void CheckAnagram()
        {
            Console.WriteLine("Enter 1st String");
            string str1 = Console.ReadLine();
            Console.WriteLine("Enter 2st String");
            string str2 = Console.ReadLine();
            bool check = Anagram(str1, str2);
            if (check == true)
            {
                Console.WriteLine("Strings are Anagram");
            }
            else
            {
                Console.WriteLine("Strings Are Not Anagram");
            }
        }

        /// <summary>
        /// Anagrams the specified STR1.
        /// </summary>
        /// <param name="str1">The STR1.</param>
        /// <param name="str2">The STR2.</param>
        /// <returns>Check And Return Result</returns>
        public static Boolean Anagram(string str1, string str2)
        {
            bool b = false;
            str1 = str1.ToLower();
            str2 = str2.ToLower();
            if (str1.Length == str2.Length)
            {
                char[] ch1 = str1.ToCharArray();
                char[] ch2 = str2.ToCharArray();
                Array.Sort(ch1);
                Array.Sort(ch2);
                string str3 = new string(ch1);
                string str4 = new string(ch2);
                if (string.Equals(str3, str4))
                {
                    ////Check String 3 And String 4 Are Equals or Not
                    return true;
                }
                else
                {
                    return b;
                }
            }
            else
            {
                return b;
            }
        }

        /// <summary>
        /// Cals the Calculate Anagram.
        /// </summary>
        /// <param name="str1">The STR1.</param>
        /// <param name="str2">The STR2.</param>
        /// <returns>Result of Anagram or Not</returns>
        public static Boolean CalCulateAnagram(string str1, string str2)
        {
            bool b = false;
            if (str1.Length == str2.Length)
            {
                char[] ch1 = str1.ToCharArray();
                char[] ch2 = str2.ToCharArray();
                Array.Sort(ch1);
                Array.Sort(ch2);
                string str3 = new string(ch1);
                string str4 = new string(ch2);
                if (string.Equals(str3, str4))
                {
                    return true;
                }
                else
                {
                    return b;
                }
            }
            else
            {
                return b;
            }
        }

        /// <summary>
        /// Starts this instance.
        /// </summary>
        /// <returns>Start Time</returns>
        public static long Start()
        {
            long startTimer = DateTime.UtcNow.Millisecond;
            return startTimer;
        }

        /// <summary>
        /// Stops this instance.
        /// </summary>
        /// <returns>Stop Time</returns>
        public static long Stop()
        {
            long stopTimer = DateTime.UtcNow.Millisecond;
            return stopTimer;
        }

        /// <summary>
        /// Gets the elapsed time.
        /// </summary>
        /// <returns>Elapsed Time</returns>
        public static long GetElapsedTime()
        {
            long elapsed;
            long startTimer = Utility.Start();
            long endTimer = Utility.Stop();
            elapsed = startTimer - endTimer;
            return elapsed;
        }

        /// <summary>
        /// Primes the numbers bet 1000.
        /// </summary>
        /// <returns>Prime Numbers Bet 1000</returns>
        public static ArrayList PrimeNumbersbet1000()
        {
            ArrayList list = new ArrayList();
            int i = 0, j = 0, number = 1000, k = 0;
            for (i = 2; i < number; i++)
            {
                k = 0;
                for (j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        k++;
                    }
                }

                if (k == 0)
                {
                    list.Add(i);
                }
            }

            return list;
        }

        /// <summary>
        /// Shows the list.
        /// </summary>
        /// <param name="list">The list.</param>
        public static void ShowList(ArrayList list)
        {
            foreach (int value in list)
            {
                Console.WriteLine(value);
            }
        }

        /// <summary>
        /// Primes the palindrome.
        /// </summary>
        public static void PrimePalindrome()
        {
             ArrayList list = PrimeNumbersbet1000();
            int i = 0, a = 0, count = 0; 
            foreach (int value in list)
             {
                for (i = 0; i <= value; i++)
                 {
                    count = 0;
                    a = Reverse(i);
                    if (a != i)
                    {
                        count++;
                    }
                }

                if (count == 0)
                {
                    Console.WriteLine(value);
                }
            }
            
            Console.ReadKey();
        }

        /// <summary>
        /// Reverses the specified number.
        /// </summary>
        /// <param name="number">The number.</param>
        /// <returns>Reversed Numbers</returns>
        public static int Reverse(int number)
        {
            int reminder = 0, reverse = 0;
                while (number != 0)
                {
                    reminder = number % 10;
                    reverse = (reverse * 10) + reminder;
                    number = number / 10;
                }

            return reverse;
        }

        /// <summary>
        /// Primes the anagram.
        /// </summary>
        public static void PrimeAnagram()
        {
            int j = 0;
            bool check = false;
            string a = string.Empty, b = string.Empty;
            ArrayList list = PrimeNumbersbet1000();
            foreach (int value in list)
            {
                for (int i = 1; i <= value - 1; i += 1)
                {
                    for (j = i + 1; j <= value; j += 1)
                    {
                        a = i.ToString();
                        b = j.ToString();
                        check = CalCulateAnagram(a, b);
                    }

                    if (check == true)
                    {
                        Console.WriteLine("anagram Numbers Are{0}{1} ", a, b);
                    }
                }
            }
        }

        /// <summary>
        /// Binaries the search.
        /// </summary>
        /// <param name="array">The array.</param>
        /// <param name="key">The key.</param>
        /// <returns>Result of Element Found or Not</returns>
        public static int BinarySearch(int[] array, int key)
        {
            int start = 0;
            int end = array.Length - 1;
            while (start <= end)
            {
                ////Calculate Mid
                int mid = (start + end) / 2;
                if (key == array[mid])
                {
                    ////Compare Key with Mid
                    return mid;
                }

                if (key < array[mid])
                {
                    ////Compare key Is Less Than key or Not
                    end = mid - 1;
                }
                else
                {
                    start = mid + 1;
                }
            }

            return -1;
        }

        /// <summary>
        /// Binaries the search.
        /// </summary>
        /// <param name="array">The array.</param>
        /// <param name="key">The key.</param>
        /// <returns>result Of String found or Not</returns>
        public static int BinarySearch(string[] array, string key)
        {
            int start = 0;
            int end = array.Length - 1;
            while (start <= end)
            {
                int mid = (start + end) / 2;
                if (key == array[mid])
                {
                    ////Compare key With Mid
                    return mid;
                }

                 if (key.CompareTo(array[mid]) < 0)
                {
                    ////Compare Key is less than mid Or Not
                    end = mid - 1;
                }
                else
                {
                    start = mid + 1;
                }
            }

            return -1;
        }

        /// <summary>
        /// Insertions the specified number.
        /// </summary>
        /// <param name="number">The number.</param>
        /// <returns>Sorted Integer Array</returns>
        public static int[] Insertion(int[] number)
        {
            int i = 0;
            int size = number.Length;

            for (i = 0; i <= size - 1; i++)
            {
                int key = number[i];
                int j = i - 1;
                   while (j >= 0 && number[j] > key)
                    {
                        ////Compare J And J+1 Elements
                        number[j + 1] = number[j];
                        j = j - 1;
                    }

                number[j + 1] = key;
                }

            return number;
        }

        /// <summary>
        /// Insertions the specified number.
        /// </summary>
        /// <param name="number">The number.</param>
        /// <returns>Sorted String Array</returns>
        public static string[] Insertion(string[] number)
        {
            int i = 0;
            int size = number.Length;
            for (i = 0; i <= size - 1; i++)
            {
                string key = number[i];
                int j = i - 1;
                while (j >= 0 && number[j].CompareTo(key) > 0)
                {
                    ////compare J And J+1 Elements
                    number[j + 1] = number[j];
                    j = j - 1;
                }

                number[j + 1] = key;
            }

            return number;
        }

        /// <summary>
        /// Days the of week.
        /// </summary>
        public static void DayOfWeek()
        {
            Console.WriteLine("Enter The Day");
            int day = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter The Month");
            int month = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter The Year");
            int year = int.Parse(Console.ReadLine());
            int y0 = year - ((14 - month) / 12);
            int x = y0 + (y0 / 4) - (y0 / 100) + (y0 / 400);
            int m0 = month + (12 * ((14 - month) / 12)) - 2;
            int d0 = (day + x + ((31 * m0) / 12)) % 7;
            Console.WriteLine(d0);
            switch (d0)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("sunday");
                    break;
            }
        }

        /// <summary>
        /// Temperature the conversion.
        /// </summary>
        public static void TemperaturConversion()
        {
            Console.WriteLine("enter The temperature in fahrenheit");
            double fahrenheit = double.Parse(Console.ReadLine());
            int celsius = (int)(fahrenheit - 32) * 5 / 9;
            Console.WriteLine("temperature in Celsius=" + celsius);
            Console.WriteLine("enter The temperature in Celsius");
            celsius = int.Parse(Console.ReadLine());
            fahrenheit = (double)(celsius * 9 / 5) + 32;
            Console.WriteLine("temperature in fahrenheit=" + fahrenheit);
        }

        /// <summary>
        /// Monthlies the payment.
        /// </summary>
        public static void MonthlyPayment()
        {
            Console.WriteLine("Enter The Loan Amount");
            double p = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter The Year");
            double y = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter The Interest Rate");
            double r = double.Parse(Console.ReadLine());
            double n = (double)12 * y;
            double r1 = (double)(r / (12 * 100));
            double payment = (double)(p * r1) / (1 - Math.Pow(1 + r1, -n));
            Console.WriteLine("payment=" + payment);
        }

        /// <summary>
        /// SQRTs this instance.
        /// </summary>
        public static void Sqrt()
        {
            Console.WriteLine("Enter The Number");
            double c = double.Parse(Console.ReadLine());
            double t = c;
            double epsilon = 1e-15;
            ////calculate Squere Root Using Formula
            while (Math.Abs(t - (c / t)) > epsilon * t)
            {
                t = ((c / t) + t) / 2;
            }

            Console.WriteLine("Square Root=" + t);
        }

        /// <summary>
        /// Converts to binary.
        /// </summary>
        /// <param name="number">The number.</param>
        /// <returns>Converted Binary Digits</returns>
        public static string ToBinary(int number)
        {
            int reminder = 0;
            string result = string.Empty;
            while (number > 0)
            {
                reminder = number % 2;
                number = number / 2;
                result = reminder.ToString() + result;
            }

            result = result.PadLeft(8, '0');
            return result;
        }

        /// <summary>
        /// Bubbles the sort.
        /// </summary>
        /// <param name="array">The array.</param>
        /// <returns>Sorted Int Array</returns>
        public static int[] BubbleSort(int[] array)
        {
            int size = array.Length;
            for (int i = 0; i <= size - 1; i++)
            {
                for (int j = 0; j <= size - 1 - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        ////Compare Adjucent Elements And Swap Them
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }

            return array;
        }

        /// <summary>
        /// Bubbles the sort.
        /// </summary>
        /// <param name="array">The array.</param>
        /// <returns>Sorted Array</returns>
        public static string[] BubbleSort(string[] array)
        {
            int size = array.Length;
            for (int i = 0; i <= size - 1; i++)
            {
                ////Start At 0th Position To End Of Array
                for (int j = 0; j <= size - 1 - 1; j++)
                {
                    ////Start At 0th Position To End-1 Of Array
                    if (array[j].CompareTo(array[j + 1]) > 0)
                    {
                        ////Compare And Swap Adjucent numbers
                        string temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }

            return array;
        }

        /// <summary>
        /// Merges the sort.
        /// </summary>
        /// <param name="array">The array.</param>
        /// <returns>Sorted Array</returns>
        public static string[] MergeSort(string[] array)
        {
            string[] left;
            string[] right;
            string[] result = new string[array.Length];
           
            if (array.Length <= 1)
            { 
                return array;
            }

            int midPoint = array.Length / 2;
            
            left = new string[midPoint];

            if (array.Length % 2 == 0)
            { 
                right = new string[midPoint];
            }
            else
            {
                ////if array has an odd number
                right = new string[midPoint + 1];
            }
            
            ////left Array
            for (int i = 0; i < midPoint; i++)
            { 
                left[i] = array[i];
            }

            int x = 0;
            ////Right Array
            for (int i = midPoint; i < array.Length; i++)
            {
                right[x] = array[i];
                x++;
            }
            
            left = MergeSort(left);
            right = MergeSort(right);
            result = Merge(left, right);

            return result;
        }

        /// <summary>
        /// Merge The Elements
        /// </summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>Merge Array</returns>
        public static string[] Merge(string[] left, string[] right)
        {
            int resultLength = right.Length + left.Length;
            string[] result = new string[resultLength];
            ////  
            int indexLeft = 0, indexRight = 0, indexResult = 0;
             
            while (indexLeft < left.Length || indexRight < right.Length)
            {
                if (indexLeft < left.Length && indexRight < right.Length)
                {
                    ////If item on left array is less than item on right array, add that item to result array  
                    if (left[indexLeft].CompareTo(right[indexRight]) <= 0)
                    {
                        result[indexResult] = left[indexLeft];
                        indexLeft++;
                        indexResult++;
                    }
                    else
                    {
                        ////else right array added to the results array
                        result[indexResult] = right[indexRight];
                        indexRight++;
                        indexResult++;
                    }
                }
                else if (indexLeft < left.Length)
                {
                    ////if only left array still has elements
                    result[indexResult] = left[indexLeft];
                    indexLeft++;
                    indexResult++;
                }
                else if (indexRight < right.Length)
                {
                    ////if only the right array still has elements
                    result[indexResult] = right[indexRight];
                    indexRight++;
                    indexResult++;
                }
            }

            return result;
        }
    }
}
