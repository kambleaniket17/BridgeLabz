// -------------------------------------------------------------------------------------------------------------------------
// <copyright file="InputForCalendar.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Aniket Kamble"/>
// ---------------------------------------------------------------------------------------------------------------------------
namespace Data_Structure.Calendar
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Takes input 
    /// </summary>
    public class InputForCalendar
    {
        /// <summary>
        /// Starts the calendar.
        /// </summary>
        /// <exception cref="Exception">throws exception</exception>
        public static void StartCalender()
        {
            try
            {
                Console.WriteLine("Enter Month in Number");
                string mon = Console.ReadLine();
                Console.WriteLine("Enter Year in Number");
                string ye = Console.ReadLine();
                int year = 0;
                int month = 0;
                if (mon.Length != 2)
                {
                    Console.WriteLine("Please Enter the month and Year correctly in MM/YYYY");
                    Console.Read();
                    return;
                }

                if (Utility.IsNumber(mon) == false)
                {
                    Console.WriteLine("Invalid Month");
                    Console.Read();
                    return;
                }

                month = Convert.ToInt32(mon);
                if (month <= 0 || month > 12)
                {
                    Console.WriteLine("Invalid Month");
                    Console.Read();
                    return;
                }

                if (Utility.IsNumber(ye) == false)
                {
                    Console.WriteLine("Invalid year");
                    Console.Read();
                    return;
                }

                if (ye.Length < 4)
                {
                    Console.WriteLine("Wrong Year specified");
                    Console.Read();
                    return;
                }

                year = Convert.ToInt32(ye);

                Calendar.PrintCalendar(month, year);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
