using System;
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
            Deck deck = new Deck();
            
            //deck.Shuffle(3);

            //foreach (Card card in deck.Cards)
            //{
            //    Console.WriteLine(card.Face + " of " + card.Suit);
            //}
            //Console.WriteLine("Total card count: " + deck.Cards.Count);



            Console.Read();



            /* LAMBDA EXPRESSION PRACTICE */

            //int count = deck.Cards.Count(x => x.Face == Face.Ace); // .Count Lambda function.
            //Console.WriteLine(count);
            //List<Card> newList = deck.Cards.Where(x => x.Face == Face.King).ToList();
            //List<int> numberList = new List<int> { 1, 2, 3, 4365, 234, 34 };
            //int sum = numberList.Sum();
            //int y = numberList.Sum(x => x += 5);
            //int max = numberList.Max();
            //int min = numberList.Min();
            //int chain = numberList.Where(x => x > 20).Sum();

            //foreach (Card card in newList)
            //{
            //    Console.WriteLine(card.Face + " of " + card.Suit);
            //}
                                          
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
