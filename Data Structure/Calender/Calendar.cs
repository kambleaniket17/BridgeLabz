// -------------------------------------------------------------------------------------------------------------------------
// <copyright file="Calendar.cs" company="Bridgelabz">
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
    /// Print calendar of given month and year
    /// </summary>
    public class Calendar
    {
        /// <summary>
        /// Prints the calendar.
        /// </summary>
        /// <param name="month">The month.</param>
        /// <param name="year">The year.</param>
        /// <exception cref="Exception">throws exception </exception>
        public static void PrintCalendar(int month, int year)
        {
            try
            {
                string[] monthsArray = { string.Empty, "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
                int[] numberOfDaysArray = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

                ////to check if the given year is a leap year
                if (month == 2 && Utility.CheckLeapYear(year))
                {
                    numberOfDaysArray[month] = 29;
                }

                Console.WriteLine(monthsArray[month]);
                Console.WriteLine(year);
                Console.WriteLine(" S  M  T  W  TH  F  S");

                ////getting the first day of specified month and year
                int day = Utility.DayOfWeek(month, 1, year);

                for (int i = 0; i < day; i++)
                {
                    Console.Write("   ");
                }

                for (int i = 0; i <= numberOfDaysArray[month]; i++)
                {
                    Console.Write(i + "  ");

                    ////for moving to next Line after one week
                    if ((i + day) % 7 == 0 || (i == numberOfDaysArray[month]))
                    {
                        Console.WriteLine();
                    }
                }

                Console.Read();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}