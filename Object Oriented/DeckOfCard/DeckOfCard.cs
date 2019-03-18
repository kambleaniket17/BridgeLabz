﻿// -------------------------------------------------------------------------------------------------------------------------
// <copyright file="DeckofCard.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Aniket Kamble"/>
// ---------------------------------------------------------------------------------------------------------------------------
namespace Object_Oriented
{
    using System;

    /// <summary>
    /// DeckOfCard class 
    /// </summary>
    public class DeckOfCard
    {
        /// <summary>
        /// Decks the card.
        /// </summary>
        public static void Card()
        {
            ////assigning the return value to player card array
            string[,] playercard = PassingCards();
            ////printing on console
            Console.WriteLine("******");
            Console.WriteLine("Player1 \t Player2 \t Player3 \t Player4");
            Console.WriteLine();
            int x = 0;
            int y = 0;
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(playercard[x, y] + " \t ");
                    y++;
                    if (y == 9)
                    {
                        y = 0;
                        x++;
                    }
                }

                Console.WriteLine();
            }
        }
        public static string[,] PassingCards()
        {
            ////declaring and initializing string array 
            string[,] arr = new string[4, 13];
            ////calling recursively showcard method 
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
        /// show the card
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
    }
}