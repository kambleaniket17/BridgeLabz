// -------------------------------------------------------------------------------------------------------------------------
// <copyright file="Harmonic.cs" company="Bridgelabz">
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
    /// calculate nth Harmonic Numbers
    /// </summary>
    public class Harmonic
    {
        /// <summary>
        /// Calculates the harmonic number.
        /// </summary>
        public void CalculateHarmonicNumber()
        {
        // TODO Auto-generated method stub
        double result = 0;
        Console.WriteLine("Enter Number:");
        try
        { 
        int n = Convert.ToInt32(Console.ReadLine());
        while (n > 0)
        {
                    ////Calculate Harmonic Number Using Formula
            result = result + (double)(1 / n);
            n--;
        }

    Console.WriteLine("Harmonic Number=" + result);
            Console.ReadKey();
            }
            catch (Exception)
            {
                Console.WriteLine("Incorrect Input..Please Enter Correct Input");
            }
    }
    }
}
