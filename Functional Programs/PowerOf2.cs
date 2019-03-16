// -------------------------------------------------------------------------------------------------------------------------
// <copyright file="PowerOf2.cs" company="Bridgelabz">
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
    /// Calculating Power Of 2
    /// </summary>
    public class PowerOf2
    {
        /// <summary>
        /// Calculates the power of2.
        /// </summary>
        public void CalculatePowerOf2()
        { 
            Console.WriteLine("Enter The Number");
            try
            {
             int num = Convert.ToInt32(Console.ReadLine());
             for (int i = 1; i <= num; i++)
            {
                    ////Calculate Power
              Console.WriteLine("Power of 2 is" + Math.Pow(2, i));
            }

             Console.ReadKey();
            }
            catch
            {
                Console.WriteLine("Incorrect input..Please Enter Correct Input\n");
            }
        }
    }
}
