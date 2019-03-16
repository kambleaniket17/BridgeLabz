// -------------------------------------------------------------------------------------------------------------------------
// <copyright file="CrossGame.cs" company="Bridgelabz">
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
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Cross Game
    /// </summary>
    public class CrossGame
    {
        /// <summary>
        /// initialization of Elements
        /// </summary>
        private static char[] arr = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

        /// <summary>
        /// Initialize player 1 default
        /// </summary>
        private static int player = 1;

        /// <summary>
        /// Choice for selection of place for game
        /// </summary>
        private static int choice;

        /// <summary>
        /// initially flag set to 0
        /// </summary>
        private static int flag = 0;

        /// <summary>
        /// Play game
        /// </summary>
        public static void PlayGame()
        {
            do
            {
                Console.Clear();
                Console.WriteLine("Player1:X and Player2:O");
                Console.WriteLine("\n");
                if (player % 2 == 0)
                {
                    Console.WriteLine("Player 2 Chance");
                }
                else
                {
                    Console.WriteLine("Player 1 Chance");
                }

                Console.WriteLine("\n");
                Board();
                if (player % 2 == 0)
                {
                    Console.WriteLine("Enter Choice");
                    choice = int.Parse(Console.ReadLine());
                }
                else
                {
                    Thread.Sleep(2000);
                    Random r = new Random();
                    choice = r.Next(1, 9);
                }
                
                //// checking that position where user want to run is marked (with X or O) or not 
                if (arr[choice] != 'X' && arr[choice] != 'O')
                {
                    if (player % 2 == 0) 
                    {
                        ////if chance is of player 2 then mark O else mark X
                        arr[choice] = 'O';
                        player++;
                    }
                    else
                    {
                        arr[choice] = 'X';
                        player++;
                    }
                }
                else
                {
                    Console.WriteLine("Sorry the row {0} is already marked with {1}", choice, arr[choice]);
                    Console.WriteLine("\n");
                    Console.WriteLine("Please wait 2 second board is loading again.....");
                    Thread.Sleep(2000);
                }

                flag = CheckWin(); 
            }
            while (flag != 1 && flag != -1);
            Console.Clear();
            Board();  
            if (flag == 1)
            {
                Console.WriteLine("Player {0} has won", (player % 2) + 1);
            }
            else
            {
                ////if flag value is -1 the match will be draw and no one is winner  
                Console.WriteLine("Draw");
            }

            Console.ReadLine();
        }

        /// <summary>
        /// Create Board For View the Selection
        /// </summary>
        private static void Board()
        {
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[1], arr[2], arr[3]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[4], arr[5], arr[6]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[7], arr[8], arr[9]);
            Console.WriteLine("     |     |      ");
        }

        /// <summary>
        /// Checks the win.
        /// </summary>
        /// <returns>Flag 0 or 1</returns>
        private static int CheckWin()
        {
           //// Horzontal Winning Condtion
            if (arr[1] == arr[2] && arr[2] == arr[3])
            {
                return 1;
            }
            else if (arr[4] == arr[5] && arr[5] == arr[6])
            {
                return 1;
            }
            else if (arr[6] == arr[7] && arr[7] == arr[8])
            {
                return 1;
            }
            else if (arr[1] == arr[4] && arr[4] == arr[7])
            {
                ////vertical Winning Condtion
                return 1;
            }
            else if (arr[2] == arr[5] && arr[5] == arr[8])
            {
                return 1;
            }
            else if (arr[3] == arr[6] && arr[6] == arr[9])
            {
                return 1;
            }
            else if (arr[1] == arr[5] && arr[5] == arr[9])
            {
                return 1;
            }
            else if (arr[3] == arr[5] && arr[5] == arr[7])
            {
                return 1;
            }
            else if (arr[1] != '1' && arr[2] != '2' && arr[3] != '3' && arr[4] != '4' && arr[5] != '5' && arr[6] != '6' && arr[7] != '7' && arr[8] != '8' && arr[9] != '9')
            {
                ////Checking Draw
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}  