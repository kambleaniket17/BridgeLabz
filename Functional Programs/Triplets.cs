// -------------------------------------------------------------------------------------------------------------------------
// <copyright file="Triplets.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Aniket Kamble"/>
// ---------------------------------------------------------------------------------------------------------------------------
namespace Functional_Programs
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// calculate number of triplet that addition is 0
    /// </summary>
    public class Triplets
    {
        /// <summary>
        /// Calculates the triple.
        /// </summary>
        public static void CalculateTriple()
        {
            Console.WriteLine("Enter The Numbers");
            try
            { 
            int b = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[b]; 
            Console.WriteLine("Enter " + b + "Numbers");
            for (int i = 0; i < b; i++)
            {
                   ////Numbers For Calculate Triplet
                    a[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < b; i++)
            {
                for (int j = i; j < b; j++)
                {
                    for (int k = j; k < b; k++)
                    {
                        if (a[i] + a[j] + a[k] == 0)
                        {
                                ////Checking 3 Numbers Equal To 0 or Not
                            Console.WriteLine("Number Is equal to 0");
                            Console.Write(a[i] + "\t");
                            Console.Write(a[j] + "\t");
                            Console.Write(a[k] + "\t");
                        }
                    }
                }
            }
            }
            catch
            {
                Console.WriteLine("Incorrect Input..Please enter Correct Input\n");
            }

            Console.ReadKey();
        }
    }
}
