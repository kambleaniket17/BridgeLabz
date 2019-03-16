// -------------------------------------------------------------------------------------------------------------------------
// <copyright file="Origin.cs" company="Bridgelabz">
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
    /// Main class Origin.
    /// </summary>
    public class Origin
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        public static void Main(string[] args)
        {
            int n = 0;
            
            do
            {
                try
                {
                    Console.WriteLine("1:Calculate Distance\n2:Replace String\n3:Calculate Flip Coin\n4:Calculate Leap Year\n5:Calculate Power Of 2\n6:" +
                "Harmonic Number\n7:Calculate Prime Factors\n8:Gambler\n9:Calculate Distinct Coupon\n10:Calculate 2D Array\n11:Calculate Triplet Of Sum 0\n12:" +
                "Stopwatch\n13:Calculate Quadratic Equation\n14:CAlculate Wind Chill\n15:Calculate Permutation\n");
                    Console.WriteLine("Enter Your Choice");
                    n = int.Parse(Console.ReadLine());
                    switch (n)
                    {
                        case 1:
                            Distance d = new Distance();
                            Distance.CalculateDistance();
                            break;
                        case 2:
                            ReplaceString r = new ReplaceString();
                            r.ReplaceStrings();
                            break;
                        case 3:
                            FlipCoin f = new FlipCoin();
                            f.CalculateFlipCoin();
                            break;
                        case 4:
                            LeapYear l = new LeapYear();
                            l.CalculateLeafYear();
                            break;
                        case 5:
                            PowerOf2 p = new PowerOf2();
                            p.CalculatePowerOf2();
                            break;
                        case 6:
                            Harmonic h = new Harmonic();
                            h.CalculateHarmonicNumber();
                            break;
                        case 7:
                            PrimeFactor.CalculatePrimeFactor();
                            break;
                        case 8:
                            Gambler.CalculateGambler();
                            break;
                        case 9:
                            Console.WriteLine("Enter The Number");
                            int number = int.Parse(Console.ReadLine());
                            int a = DistinctCoupon.Collect(number);
                            Console.WriteLine(a);
                            Console.ReadKey();
                            break;
                        case 10:
                            Array2D.Calculate2dArray();
                            break;
                        case 11:
                            Triplets.CalculateTriple();
                            break;
                        case 12:
                            StopWatch s = new StopWatch();
                            s.CalculateStopWatch();
                            break;
                        case 13:
                            Quadratic.CalculatesQuadraticEquations();
                            break;
                        case 14:
                            WindChill.CalculateWindTemp();
                            break;
                        case 15:
                            Console.WriteLine("Enter The String");
                            string name = Console.ReadLine();

                            string permute = (string)Permutation.CalculatePermute(name, 0, name.Length - 1);
                            Console.WriteLine(permute);
                            Console.Read();
                            break;
                        case 16:
                            CrossGame.PlayGame();
                            Console.ReadKey();
                            
                            break;

                        default:
                            Console.WriteLine();
                            break;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Please Insert Correct Choice");
                    Console.ReadKey();
                }
            }
            while (n != 0);
        }
    }
}
