// -------------------------------------------------------------------------------------------------------------------------
// <copyright file="InputForCalendarQueue.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Aniket Kamble"/>
// ---------------------------------------------------------------------------------------------------------------------------
namespace Data_Structure.CalendarQueue
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Takes required input for this class
    /// </summary>
    public class InputForCalendarQueue
    {
        /// <summary>
        /// Starts the calendar.
        /// </summary>
        public static void StartCalendar()
        {
            try
            {
                int month = 0;
                int year = 0;

                bool loopForMonth = true;
                while (loopForMonth)
                {
                    Console.WriteLine("Enter the month");
                    string stringMonth = Console.ReadLine();

                    if (Utility.IsNumber(stringMonth) == false)
                    {
                        Console.WriteLine("Invalid Month");

                        continue;
                    }

                    month = Convert.ToInt32(stringMonth);
                    if (month <= 0 || month > 12)
                    {
                        Console.WriteLine("Invalid Month");
                        continue;
                    }

                    loopForMonth = false;
                }

                bool loopForYear = true;
                while (loopForYear)
                {
                    Console.WriteLine("Enter the year");
                    string stringYear = Console.ReadLine();

                    if (Utility.IsNumber(stringYear) == false)
                    {
                        Console.WriteLine("Invalid Month");

                        continue;
                    }

                    if (stringYear.Length < 4)
                    {
                        Console.WriteLine("Wrong Year specified");
                        Console.Read();
                        return;
                    }

                    year = Convert.ToInt32(stringYear);
                    loopForYear = false;
                }

                Calendar.PrintCalendar(month, year);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
