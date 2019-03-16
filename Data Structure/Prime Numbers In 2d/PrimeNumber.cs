// -------------------------------------------------------------------------------------------------------------------------
// <copyright file="PrimeNumber.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Aniket Kamble"/>
// ---------------------------------------------------------------------------------------------------------------------------
namespace Data_Structure.PrimeNumberIn2DArray
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// generates primeNumber between given range
    /// </summary>
    public class PrimeNumber
    {
        /// <summary>
        /// Gets the prime numbers list.
        /// </summary>
        /// <returns> returns array of prime Numbers</returns>
        public static ArrayList GetPrimeNumbersList()
        {
            try
            {
                ArrayList primeNumberArrayList = new ArrayList();
                bool primeNumberFound = false; ////for checking prime number
                bool flag = true; //// to Print if a number is Prime.
                int initialNumber = 0;
                int lastNumber = 0;
                bool initialFlag = true;
                int indexForPrimeArray = 0;

                while (initialFlag)
                {
                    Console.WriteLine("Enter the Initial Range");
                    string strInitial = Console.ReadLine();

                    if (Utility.IsNumber(strInitial) == false)
                    {
                        Console.WriteLine("Invalid Number");
                        continue;
                    }

                    initialNumber = Convert.ToInt32(strInitial);

                    if (initialNumber < 0)
                    {
                        Console.WriteLine("Enter a number greater then 0");
                        continue;
                    }

                    initialFlag = false;
                }

                bool lastFlag = true; //// keep asking the user till valid number is given.
                while (lastFlag)
                {
                    Console.WriteLine("Enter the Last Number ,you want to print Prime Numbers till");
                    string strLast = Console.ReadLine();

                    if (Utility.IsNumber(strLast) == false)
                    {
                        Console.WriteLine("Invalid Number");
                        continue;
                    }

                    lastNumber = Convert.ToInt32(strLast);

                    if (lastNumber <= initialNumber)
                    {
                        Console.WriteLine("Last number should be greater than the initial Value ");
                        continue;
                    }

                    lastFlag = false;
                }

                //// For keep checking for PrimeNumber till last Range.
                for (int i = initialNumber; i <= lastNumber; i++)
                {
                    if (i == 2)
                    {
                        flag = true;
                    }

                    if (i % 2 == 0 && i != 2)
                    {
                        continue;
                    }

                    if (i == 1)
                    {
                        continue;
                    }

                    //// checking for divisibility for each odd number.
                    for (int j = 3; j < i; j = j + 2)
                    {
                        if (i % j == 0)
                        {
                            flag = false;
                            break;
                        }
                    }

                    if (flag)
                    {
                        primeNumberArrayList.Add(i);
                        indexForPrimeArray++;
                        primeNumberFound = true;
                    }
                    else
                    {
                        flag = true;
                    }
                }

                if (primeNumberFound == false)
                {
                    Console.WriteLine("There are no Prime Numbers between range " + initialNumber + " & " + lastNumber);
                }

                return primeNumberArrayList;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
