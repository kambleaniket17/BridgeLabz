namespace Object_Oriented.DeckOfCard
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class DeckOfCard
    {
        public static void CardsInfo()
        {
            string[] suit= { "Clubs", "Diamonds", "Hearts", "Spades"};
            string[] ranks = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace" };
            Shuffles(suit,ranks);
        }
        public static void Shuffles(string[] suit,string[] ranks)
        {
            string[,] card = new string[4, 13];
            Random r = new Random();
           // int x = 4;
            int x1 = r.Next(4);
            int x2 = r.Next(13);
            int x3 = r.Next(4);
            int x4 = r.Next(13);
            Swap(x1,x2,x3,x4);
            for(int i=0;i<=card.Length-1;i++)
            {
              for(int j=0;i<card.Length-1;i++)
               {
                    int abc=r.Next(i,j);
                    ShowCards(card);
               }
            }
        }
        public static void ShowCards(string[,] cardInfo)
        {
            for(int i=1;i<=cardInfo.Length-1;i++)
            {
                for(int j=1;j<=cardInfo.Length-2;i++)
                {
                   // DeckOfCard deckOfCard = new DeckOfCard();
                    string[,] cardNames = cardInfo;
                    Console.WriteLine("Players="+cardNames[i-1,j]);
                }
            }
        }
        public static void Swap(int x1,int x2,int x3,int x4)
        {
             int player1=0, player2=0, player3=0, player4=0;
            //Swap(player1, player2, player3, player4);
        }
    }
}