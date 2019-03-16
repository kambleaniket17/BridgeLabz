// -------------------------------------------------------------------------------------------------------------------------
// <copyright file="_2DArrayPrimeNumber.cs" company="Bridgelabz">
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
    /// Stores the prime number in 2D array
    /// </summary>
    public class _2DArrayPrimeNumber
    {
        /// <summary>
        /// 2s the d array.
        /// </summary>
        public static void _2DArray()
        {
            try
            {
                int[,] prime2DArray = new int[30, 11];
                ArrayList arr = PrimeNumber.GetPrimeNumbersList();

                int changeColumn = 100;
                int row = 0;
                int column = 0;

                foreach (int num in arr)
                {
                    if (num < changeColumn)
                    {
                        prime2DArray[row, column] = num;
                        row++;
                    }
                    else
                    {
                        row = 0;
                        column++;
                        prime2DArray[row, column] = num;
                        changeColumn = changeColumn + 100;
                        row++;
                    }
                }

                PrintMatrix(prime2DArray);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Prints the matrix.
        /// </summary>
        /// <param name="array">The array</param>
        public static void PrintMatrix(int[,] array)
        {
            try
            {
                try
                {
                    var rowCount = array.GetLength(0);
                    var colCount = array.GetLength(1);
                    for (int row = 0; row < rowCount; row++)
                    {
                        for (int col = 0; col < colCount; col++)
                        {
                            if (array[row, col] != 0)
                            {
                                Console.Write("  " + array[row, col] + "  ");
                            }
                        }

                        Console.WriteLine();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
