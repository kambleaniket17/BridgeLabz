// -------------------------------------------------------------------------------------------------------------------------
// <copyright file="FlipCoin.cs" company="Bridgelabz">
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
    /// Calculating the random Flip coin Percentage
    /// </summary>
    public class FlipCoin
    {
        /// <summary>
        /// Calculates the flip coin.
        /// </summary>
        public void CalculateFlipCoin()
        { 
            Random random = new Random();
            int count = 0, count1 = 0, heads = 0, tails = 0;
            try
            { 
            Console.WriteLine("Enter The Number"); ////Number of Time use throw Coin
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                if (random.NextDouble() < 0.5)
                {
                        ////Checking Tails
                    tails = tails + count;
                    tails++;
                    Console.WriteLine("tails=" + tails);
                }
                else
                {
                       //// Checking Heads
                    heads = heads + count1;
                    heads++;
                    Console.WriteLine("Heads=" + heads);
                }
            }
                ////percenteage calculation
                float a = (float)tails / n * 100; 
            Console.WriteLine("Percentage of Tails=" + a);
            float b = (float)heads / n * 100;
            Console.WriteLine("Percentage of Heads=" + b);
            Console.ReadKey();
            }
            catch (Exception)
            {
                Console.WriteLine("Incorrect Input..Please Enter Correct Input\n");
            }
        }
    }
}
