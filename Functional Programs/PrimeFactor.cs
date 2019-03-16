// -------------------------------------------------------------------------------------------------------------------------
// <copyright file="PrimeFactor.cs" company="Bridgelabz">
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
    /// Calculating Prime Factors
    /// </summary>
    public class PrimeFactor
    {
        /// <summary>
        /// Calculates the prime factor.
        /// </summary>
        public static void CalculatePrimeFactor()
        { 
        // TODO Auto-generated method stub
        Console.WriteLine("Enter number");
            try
            { 
        int n = Convert.ToInt32(Console.ReadLine());
        for (int i = 2; i <= n; i++)
        {
                    ////Calculate Factor
                int x = 0;
                while (n % i == 0)
                {
                    ////Checking Prime Numbers And Calculate Factors
                    n /= i;
                    x++;
                    Console.WriteLine("Prime factor=" + i);
                }
            }
            }
            catch
            {
                Console.WriteLine("Incorrect Input..Please Enter Correct Input\n");
            }

            Console.ReadKey();
        }
    }
}
