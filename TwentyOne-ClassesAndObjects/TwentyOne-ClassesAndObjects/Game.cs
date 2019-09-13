using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne_ClassesAndObjects
{
    public abstract class Game //Abstract class: Would never be instantiated. Makes it impossible for class to be used as an object.
    {
        public List<Player> Players { get; set; }
        public string Name { get; set; }
        public string Dealer { get; set; }


        // Abstract method.
        public abstract void Play(); // Any class inheriting this class (Game) must implement this method.
        public virtual void ListPlayers() // virtual: this method is inherited, but has the ability to override it.
        {
            foreach (Player player in Players)
            {
                Console.WriteLine(player.Name);
            }
        }
    }
}
