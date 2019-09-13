﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne_ClassesAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Card card = new Card();
            card.Suit = Suit.Clubs;

            int underlyingValue = (int)Suit.Hearts;
            Console.WriteLine(underlyingValue);

            Deck deck = new Deck();
            deck.Shuffle(3);

            //foreach (Card card in deck.Cards)
            //{
            //    Console.WriteLine(card.Face + " of " + card.Suit);
            //}
            //Console.WriteLine("Total card count: " + deck.Cards.Count);
            Console.Read();


            //Game game = new TwentyOneGame();
            //game.Players = new List<Player>();
            //    Player player = new Player() { Name = "Alex" };
            //game += player;
            //    game -= player;
            

            //// Overload method
            //public static Deck Shuffle(Deck deck, int times)
            //{
            //    for (int i = 0; i < times; i++)
            //    {
            //        deck = Shuffle(deck);
            //    }
            //    return deck;
            //}
        }

        public enum DaysOfTheWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
    }
}