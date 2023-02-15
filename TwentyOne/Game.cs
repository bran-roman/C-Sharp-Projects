using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public abstract class Game
    {
        private List<Player> _players = new List<Player>();
        private Dictionary<Player, int> _bets = new Dictionary<Player, int>();


        public List<Player> Players { get { return _players; } set { _players = value; } }
        public string Name { get; set; }
        public Dictionary<Player, int> Bets { get { return _bets; } set { _bets = value; } }

        // Abstract method that only exists in abstract class + contains no implementation
        // Any class inheriting this class must implement this method
        public abstract void Play();

        // What if we wanted to have our own implementation of players?
        // Use "virtual" keyword - Virtual method in an abstract class that means
        // This method gets inherited by inheriting class but has ability to override 
        public virtual void ListPlayers()
        {
            foreach (Player player in Players)
            {
                Console.WriteLine(player.Name);
            }
        }
    }
}
