// -------------------------------------------------------------------------------------------------------------------------
// <copyright file="Distance.cs" company="Bridgelabz">
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
    /// Calculate the Euclidean distance between two Points
    /// </summary>
    public class Distance
    {
        /// <summary>
        /// Calculates the distance.
        /// </summary>
        public static void CalculateDistance()
        {
            try
            {
            // TODO Auto-generated method stub\
            double distance;
            Console.WriteLine("Enter X:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Y:");
            int y = Convert.ToInt32(Console.ReadLine());
            distance = (double)Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
            Console.WriteLine("Distance=" + distance);
            Console.ReadKey();
            }
            catch (Exception)
            {
                Console.WriteLine("Incorrect Input..Please enter Correct Input");
            }
        }
    }
 }
