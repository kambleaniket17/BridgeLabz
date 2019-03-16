// -------------------------------------------------------------------------------------------------------------------------
// <copyright file="ReplaceString.cs" company="Bridgelabz">
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
    /// Replace Strings
    /// </summary>
    public class ReplaceString
    {
        /// <summary>
        /// Replaces the string.
        /// </summary>
        public void ReplaceStrings()
        {
            string str1, str2, str3;
            Console.WriteLine("Enter Name");
            try
            {
            str1 = Console.ReadLine();
            int len = str1.Length;
            if (len >= 3)
            {
                ////Compare String is Grater Then 3 Or Not
                Console.WriteLine("hello:\t" + str1 + ",How are You?");
                Console.WriteLine("Enter Name which you want to replace");
                str2 = Console.ReadLine();
                str3 = str1.Replace(str1, str2); ////Replace String
                Console.WriteLine("hello:\t" + str3 + ",How are You?");
            }
            else
            {
                Console.WriteLine("Enter valide name");
            }
            }
            catch (Exception)
            {
                Console.WriteLine("Incorrect Input..Please Enter Correct Input\n");
            }

            Console.ReadKey();
        }
    }
    }