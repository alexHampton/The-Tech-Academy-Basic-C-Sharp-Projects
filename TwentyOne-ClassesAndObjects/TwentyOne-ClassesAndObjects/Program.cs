using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TwentyOne_ClassesAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {


            DateTime yearOfBirth = new DateTime(1995, 5, 23, 8, 32, 45); // Multiple overloads
            DateTime yearOfGraduation = new DateTime(2013, 6, 1, 16, 34, 22);

            TimeSpan ageAtGraduation = yearOfGraduation - yearOfBirth;
            Console.WriteLine(yearOfGraduation <= yearOfBirth);

            Console.WriteLine("Welcome to the Grand Hotel and Casino. Let's start by telling me your name.");
            string playerName = Console.ReadLine(); // Used to create instance of player class.
            Console.WriteLine("And how much money did you bring today?");
            int bank = Convert.ToInt32(Console.ReadLine()); // used to create instance of player class.
            Console.WriteLine("Hello, {0}. Would you like to join a game of 21 right now?", playerName);
            string answer = Console.ReadLine().ToLower();
            if (answer == "yes" || answer == "yeah" || answer == "sure" || answer == "y" || answer == "ya")
            {
                Player player = new Player(playerName, bank); // Create a new Player Object using the name and money the user inputted.
                Game game = new TwentyOneGame(); // polymorphism so that we can use those overloaded operation properties.
                game += player;
                player.IsActivelyPlaying = true;
                while (player.IsActivelyPlaying && player.Balance > 0)
                {
                    game.Play(); // Set this to play one hand. After that, check to see if the player wants to continue playing. If so, continue While loop.
                }
                game -= player;
                Console.WriteLine("Thank you for playing!");
            }
            Console.WriteLine("Feel free to look around the casino. Bye for now.");
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

        //public enum DaysOfTheWeek
        //{
        //    Monday,
        //    Tuesday,
        //    Wednesday,
        //    Thursday,
        //    Friday,
        //    Saturday,
        //    Sunday
        //}
    }
}
