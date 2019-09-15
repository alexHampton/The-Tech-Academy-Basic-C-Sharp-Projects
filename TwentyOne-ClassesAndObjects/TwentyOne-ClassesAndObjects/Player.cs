using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne_ClassesAndObjects
{

    public class Player
    {
        public Player(string name, int beginningBalance)
        {
            Hand = new List<Card>();
            Balance = beginningBalance;
            Name = name;
        }
        public List<Card> Hand { get; set; }
        public int Balance { get; set; }
        public string Name { get; set; }
        public bool IsActivelyPlaying { get; set; }
        public bool Stay { get; set; }

        public bool Bet(int amount)
        {
            if (Balance - amount < 0)
            {
                Console.WriteLine("You don't have enough to place that bet.");
                return false;
            }
            else
            {
                Balace -= amount;
                return true;
            }
        }

        public static Game operator+ (Game game, Player player) // Overloaded operator
        {
            game.Players.Add(player);
            return game;
        }
        public static Game operator- (Game game, Player player) // Overloaded operator
        {
            game.Players.Remove(player);
            return game;
        }
    }
}
