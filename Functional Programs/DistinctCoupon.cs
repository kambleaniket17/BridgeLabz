// -------------------------------------------------------------------------------------------------------------------------
// <copyright file="DistinctCoupon.cs" company="Bridgelabz">
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
    /// Calculate Distinct Coupons
    /// </summary>
    public class DistinctCoupon
    {
        /// <summary>
        /// Random the number.
        /// </summary>
        /// <param name="random">The random.</param>
        /// <returns>Random Number</returns>
        public static int RandomNumber(Random random)
        {
            ////Calculate Random Numbers
            return (int)random.Next(0, 10);
        }

        /// <summary>
        /// Collects the specified number.
        /// </summary>
        /// <param name="number">The number.</param>
        /// <returns>Distinct Counts</returns>
        public static int Collect(int number)
        {
            int count = 0;
            int i = 0;
            int distinct = 0;
            int[] array = new int[number];

            while (i < number)
            {
                count++; ////Measure Count
                distinct = 1; ////for Distinct Coupons
                Random random = new Random(Guid.NewGuid().GetHashCode());
                for (int j = 0; j < number; j++)
                {
                    int value = RandomNumber(random); ////generate Random Numbers
                    if (array[i] == value)
                    {
                        ////Check Duplicate Coupons
                        distinct = 0;
                    }
                }

                if (distinct == 1)
                {
                    ////Check Distinct Coupons
                    array[i] = number;
                    i++;
                }

                Console.WriteLine(count);
            }

            return count;
        }
    }
}
