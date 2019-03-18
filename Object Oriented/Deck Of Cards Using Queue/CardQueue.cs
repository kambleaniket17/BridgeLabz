// -------------------------------------------------------------------------------------------------------------------------
// <copyright file="CardQueue.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Aniket Kamble"/>
// ---------------------------------------------------------------------------------------------------------------------------
namespace Object_Oriented
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Card queue class
    /// </summary>
    public class CardQueue
    {
        /// <summary>
        /// Cards the in queue.
        /// </summary>
        public static void CardInQueue()
        {
            string[,] CardOfPlayer = PassingCards();

            Queue<Queue<string>> sortedcard = SortingCards(CardOfPlayer);
            string[] playername = { "** Player 1 **", "** Player 2 **", "** Player 3 **", "** Player 4 **" };
            int index = 0;
            while (sortedcard.Count != 0)
            {
                Queue<string> temp = sortedcard.Dequeue();
                Console.WriteLine(playername[index] + ":");
                while (temp.Count != 0)
                {
                    Console.Write(temp.Dequeue() + " \t ");
                }

                Console.WriteLine();
                index++;
            }
        }
        
        /// <summary>
        /// Passing the Cards
        /// </summary>
        /// <returns></returns>
        public static string[,] PassingCards()
        {
            ////declaring and initializing string array 
            string[,] arr = new string[4, 13];
            ////calling recursively cardInsert method 
            ShowCard(arr);
            ////calling card shuffle method recursively
            Shuffle(arr);
            ////initializing and declaring array of string
            string[,] playercard = new string[4, 9];
            ////iteration to print all the length card
            for (int i = 0; i < playercard.GetLength(0); i++)
            {
                for (int j = 0; j < playercard.GetLength(1); j++)
                {
                    ////assigning arr in play
                    playercard[i, j] = arr[i, j];
                }
            }

            return playercard;
        }

        /// <summary>
        /// Cards the insert.
        /// </summary>
        /// <param name="arr">The array of string</param>
        public static void ShowCard(string[,] arr)
        {
            ////declaring and initializing suits array
            string[] suits = { "Clubs", "Diamonds", "Hearts", "Spades" };
            ////declaring and initializing rank cards
            string[] rank = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "King", "Queen", "Ace" };
            ////iteration till suits length
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                ////iteration till length of rank card
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    ////assigning suits and rank in array 
                    arr[i, j] = suits[i] + " " + rank[j];
                }
            }
        }

        /// <summary>
        /// Cards the shuffle.
        /// </summary>
        /// <param name="arr">The array of string</param>
        public static void Shuffle(string[,] arr)
        {
            ////creating object of random class
            Random r1 = new Random();
            for (int i = 0; i < 150; i++)
            {
                int x1 = Convert.ToInt32(r1.Next(4));
                int x2 = Convert.ToInt32(r1.Next(13));
                int x3 = Convert.ToInt32(r1.Next(4));
                int x4 = Convert.ToInt32(r1.Next(13));
                ////calling recursively swap method
                Swap(arr, x1, x2, x3, x4);
            }
        }

        /// <summary>
        /// Swaps the specified arr.
        /// </summary>
        /// <param name="arr">The array.</param>
        /// <param name="x1">The x1.</param>
        /// <param name="x2">The x2.</param>
        /// <param name="x3">The x3.</param>
        /// <param name="x4">The x4.</param>
        public static void Swap(string[,] arr, int x1, int x2, int x3, int x4)
        {
            string temp = arr[x1, x2];
            arr[x1, x2] = arr[x3, x4];
            arr[x3, x4] = temp;
        }
        public static Queue<Queue<string>> SortingCards(string[,] playercard)
        {
            Queue<Queue<string>> sortedcard = new Queue<Queue<string>>();

            string[] rank = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace" };
            int[] arr = new int[9];
            int index = 0;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    string[] temp = (playercard[i, j] + " ").Split(' ');
                    for (int k = 0; k < 13; k++)
                    {
                        if (temp[1].Equals(rank[k]))
                        {
                            arr[index] = k;
                            index++;
                        }
                    }
                }

                Console.WriteLine();
                index = 0;
                for (int k1 = 0; k1 < arr.Length - 1; k1++)
                {
                    for (int k2 = k1 + 1; k2 < arr.Length; k2++)
                    {
                        if (arr[k1] > arr[k2])
                        {
                            int temp = arr[k1];
                            arr[k1] = arr[k2];
                            arr[k2] = temp;

                            string temp1 = playercard[i, k1];
                            playercard[i, k1] = playercard[i, k2];
                            playercard[i, k2] = temp1;
                        }
                    }
                }
            }

            for (int i = 0; i < playercard.GetLength(0); i++)
            {
                Queue<string> temp = new Queue<string>();
                for (int j = 0; j < playercard.GetLength(1); j++)
                {
                    temp.Enqueue(playercard[i, j]);
                }

                sortedcard.Enqueue(temp);
            }

            return sortedcard;
        }
    }
}
