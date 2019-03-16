// -------------------------------------------------------------------------------------------------------------------------
// <copyright file="Quadratic.cs" company="Bridgelabz">
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
    /// Calculate Roots using Quadratic Equations
    /// </summary>
    public class Quadratic
    {
        /// <summary>
        /// Quadratics the equations.
        /// </summary>
        public static void CalculatesQuadraticEquations()
        {
            try
            {
            Console.WriteLine("Enter A");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter b");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter C");
            int c = Convert.ToInt32(Console.ReadLine());
             //// Calculate Using quadratic Equations           
            double delta = (b * b) - (4 * a * c);
            Console.WriteLine(delta);
            double root1 = (-b + Math.Sqrt(delta)) / (2 * a);
            Console.WriteLine(root1);
            double root2 = (-b - Math.Sqrt(delta)) / (2 * a);
            Console.WriteLine(root2);
            Console.ReadKey();
            }
            catch
            {
                Console.WriteLine("Incorrect Input..Please enter Correct Input\n");
            }
        }
    }
}
