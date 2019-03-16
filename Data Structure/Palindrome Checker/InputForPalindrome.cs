// -------------------------------------------------------------------------------------------------------------------------
// <copyright file="InputForPalindrome.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Aniket Kamble"/>
// ---------------------------------------------------------------------------------------------------------------------------
namespace Data_Structure.PalindromChecker
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Input for palindrome
    /// </summary>
    public class InputForPalindrome
    {
        /// <summary>
        /// Checks the palindrome.
        /// </summary>
        public static void CheckPalindrome()
        {
            try
            {
                Deque<char> deque = new Deque<char>();
                Console.WriteLine("Enter the String");
                string userString = Console.ReadLine();

                //// adding elements to rear
                for (int i = 0; i < userString.Length; i++)
                {
                    char c = userString[i];
                    deque.Addrear(c);
                }

                ////loop till size of queue and comparing the letters at front and rear of the queue
                while (deque.Size() > 1)
                {
                    if (deque.RemoveFront() != deque.RemoveRear())
                    {
                        Console.WriteLine("Given String is not Palindrome");
                        return;
                    }
                }

                Console.WriteLine("Given String is a Palindrome");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
