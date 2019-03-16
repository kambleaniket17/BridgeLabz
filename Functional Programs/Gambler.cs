// -------------------------------------------------------------------------------------------------------------------------
// <copyright file="Gambler.cs" company="Bridgelabz">
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
    /// Calculating Win or Loss using Random Function
    /// </summary>
    public class Gambler
    {
        /// <summary>
        /// Gamblers this instance.
        /// </summary>
        public static void CalculateGambler()
        {
            try
            {
                // TODO Auto-generated method stub
                int betPrice = 1, win = 0, loss = 0;
                Random random = new Random();
                Console.WriteLine("Enter Stake"); 
                int stake = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Goal");
                int goal = Convert.ToInt32(Console.ReadLine());
                while (stake != 0 && stake != goal)
                {
                    if (random.NextDouble() > 0.5)
                    {
                        ////If User Win
                        stake = stake + betPrice;
                        Console.WriteLine("User Win and Stake=" + stake);
                        win++;
                    }
                    else
                    {
                        ////If User Loss
                        stake = stake - betPrice;
                        Console.WriteLine("User Loss and stake=" + stake);
                        loss++;
                    }
                }

                Console.WriteLine("win=" + win);
                Console.WriteLine("Loss=" + loss);

                int total = win + loss;

                double winPercentage = (double)win / total * 100; ////Win Percentage

                double lossPercentage = (double)loss / total * 100; ////Loss Percentage
                Console.WriteLine("win Percentage=" + winPercentage);
                Console.WriteLine("Loss Percentage=" + lossPercentage);
                Console.ReadKey();
            }
            catch (Exception)
            {
                Console.WriteLine("Incorrect Input..Please enter Correct Input\n");
            }
        }
    }
}
