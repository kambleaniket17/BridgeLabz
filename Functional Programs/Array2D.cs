// -------------------------------------------------------------------------------------------------------------------------
// <copyright file="Array2D.cs" company="Bridgelabz">
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
    /// Implementation of 2 Dimensional Array
    /// </summary>
     public class Array2D
    {
        /// <summary>
        /// Calculates the array.
        /// </summary>
        public static void Calculate2dArray()
        {
            try
            {
            Console.WriteLine("Enter Row");
            int row = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Column");
            int col = Convert.ToInt32(Console.ReadLine());
            int i = 0, j = 0;
            int[,] array = new int[row, col]; ////Declare Array

            Console.WriteLine("Enter The Elements");
            for (i = 0; i < row; i++)
            {
                ////Row
                for (j = 0; j < col; j++)
                {
                    ////Column
                    array[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("The 2D Array is:\n");
            for (i = 0; i < row; i++)
            {
                ////Display Array in Row
                for (j = 0; j < col; j++)
                {
                    ////Display Array in Column
                    Console.Write("{0}\t", array[i, j]);
                }

                Console.Write("\n");
            }

            Console.ReadKey();
            }
            catch (Exception)
            {
                Console.WriteLine("Incorrect Input..Please enter Correct Input\n");
            }
        }
    }
}
