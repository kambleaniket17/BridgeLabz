// -------------------------------------------------------------------------------------------------------------------------
// <copyright file="LeapYear.cs" company="Bridgelabz">
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
    /// Calculating Leap Year
    /// </summary>
    public class LeapYear
    {
        /// <summary>
        /// Calculates the leaf year.
        /// </summary>
        public void CalculateLeafYear()
        {
            // TODO Auto-generated method stub
            try
            { 
            Console.WriteLine("Enter Year");
            int year = Convert.ToInt32(Console.ReadLine());
           
                ////Checking Leaf year
            if (year >= 1582 && ((year % 4 == 0) || (year % 400 == 0 && year % 100 != 0)))
            {
                Console.WriteLine("Leap Year:" + year);
            }
            else
            {
                Console.WriteLine("Not a Leap Year:" + year);
            }

            Console.ReadKey();
            }
            catch (Exception)
            {
                Console.WriteLine("Incorrect Input..Please Enter Correct Input");
            }
        }
    }
}
