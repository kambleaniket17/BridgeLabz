// -------------------------------------------------------------------------------------------------------------------------
// <copyright file="Binary.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Aniket Kamble"/>
// ---------------------------------------------------------------------------------------------------------------------------
namespace Algorithm_Programs
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Operations on Binary Digits
    /// Swapping
    /// </summary>
    public class Binary
    {
        /// <summary>
        /// Swaps the nibbles.
        /// </summary>
        public static void SwapNibbles()
        {
            string result = Input.InputToBinary(); ////Calling Input Function For Input
            int result1 = Convert.ToInt32(result); ////return Result
            Console.WriteLine((result1 & 0x0F) << 4 | (result1 & 0xF0) >> 4);
        }
    }
}
