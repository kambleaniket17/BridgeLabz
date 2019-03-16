// -------------------------------------------------------------------------------------------------------------------------
// <copyright file="_2DPrimeAnagrams.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Aniket Kamble"/>
// ---------------------------------------------------------------------------------------------------------------------------
namespace Data_Structure.PrimeAnagrams
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Prime Anagrams in 2D array
    /// </summary>
    public class _2DPrimeAnagrams
    {
        /// <summary>
        /// Print2s the d prime anagram.
        /// </summary>
        /// <exception cref="Exception"> throws Exception</exception>
        public static void Print2DPrimeAnagram()
        {
            try
            {
                string[,] array = Utility.GetAnagrams(Utility.GetPrimeNumbersList());
                Utility.PrintMatrix(array);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);               
            }
        }
    }
}
