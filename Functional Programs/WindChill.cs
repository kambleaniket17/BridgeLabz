// -------------------------------------------------------------------------------------------------------------------------
// <copyright file="WindChill.cs" company="Bridgelabz">
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
    /// Calculates Wind Child
    /// </summary>
    public class WindChill
    {
        /// <summary>
        /// Calculates the wind temporary.
        /// </summary>
        public static void CalculateWindTemp()
        {
            Console.WriteLine("Enter Temperature");
            try
            { 
            int t = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Wind Speed");
            int v = Convert.ToInt32(Console.ReadLine());
             //// Calculate Wind Chill Using Formula
            double w = 35.74 + (0.6215 * t) + (((0.4275 * t) - 35.75) * Math.Pow(v, 0.16));
            Console.WriteLine("Wind Chill=" + w);
            Console.ReadKey();
            }
            catch
            {
                Console.WriteLine("Incorrect Input..please Enter Correct Input\n");
            }
        }
    }
}
