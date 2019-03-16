// -------------------------------------------------------------------------------------------------------------------------
// <copyright file="Permutation.cs" company="Bridgelabz">
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
    /// permutation of the String
    /// </summary>
    public class Permutation
    {
        /// <summary>
        /// Calculates the permute.
        /// </summary>
        /// <param name="str">The string.</param>
        /// <param name="l">The l.</param>
        /// <param name="r">The r.</param>
        /// <returns>Permutes String</returns>
        public static string CalculatePermute(string str, int l, int r)
        {
            if (l == r)
            { 
                ////if No Element Or 1 Element
                Console.WriteLine(str);
            }
            else
            {
                for (int i = l; i <= r; i++)
                {
                    ////Swapping And Checking permutation
                    str = SwapString(str, l, i);
                    CalculatePermute(str, l + 1, r);
                    str = SwapString(str, l, i);
                }
            }

            return str;
        }

        /// <summary>
        /// Swaps the string.
        /// </summary>
        /// <param name="a">The a.</param>
        /// <param name="i">The i.</param>
        /// <param name="j">The j.</param>
        /// <returns>String which is Swapped</returns>
        public static string SwapString(string a, int i, int j)
        {
            ////Swapping String
            char temp;
            char[] charArray = a.ToCharArray(); ////Character Array
            temp = charArray[i];
            charArray[i] = charArray[j];
            charArray[j] = temp;
            string s = new string(charArray);
            return s;
        }
    }
}
