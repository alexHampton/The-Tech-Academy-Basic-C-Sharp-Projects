using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne_ClassesAndObjects
{
    public class Card
    {
        public Card() //Constructor, is always the name of the class
        {
        }
        public Suit Suit { get; set; }
        public string Face { get; set; }
    }
    public enum Suit
    {
        Clubs=4,
        Diamonds=10,
        Hearts=12,
        Spades=15
    }
}
