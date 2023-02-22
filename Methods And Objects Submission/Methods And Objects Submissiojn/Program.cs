using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_And_Objects_Submission
{
    public class Program : Employee
    {
        static public void Main(string[] args)
        {
            // 4. Instantiate and initialize an Employee object with first name Sample and Last name Student
            Employee employee = new Employee() { FirstName = "Sample", LastName = " Student" };

            // 5. Call superclass method SayName() on employee object
            employee.SayName();
            Console.ReadLine();

        }
    }
}

//namespace TwentyOne
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            // Superclass method = game
//            Game game = new Game();
//            game.Players = new List<string>() { "Jesse", "Bill", "Joe" };
//            game.ListPlayers();
//            game.Play();
//            Console.ReadLine();
//            //Initializes object with values
//            //Card card = new Card() { Face = "King", Suit = "Spades" };

//            //Deck deck = new Deck();
//            //deck.Shuffle();

//            foreach (Card card in deck.Cards)
//            {
//                Console.WriteLine(card.Face + " of " + card.Suit);
//            }
//            Console.WriteLine(deck.Cards.Count);
//            Console.ReadLine();

//        }

//        //public static Deck Shuffle(Deck deck, int times)
//        //{
//        //    for (int i= 0; i < times; i++)
//        //    {
//        //        deck = Shuffle(deck);
//        //    }
//        //    return deck;
//        //}
//    }
//}


//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace TwentyOne
//{
//    public class Game
//    {
//        public List<string> Players { get; set; }
//        public string Name { get; set; }
//        public string Dealer { get; set; }

//        public void ListPlayers()
//        {
//            foreach (String player in Players)
//            {
//                Console.WriteLine(player);
//            }
//        }
//    }
//}
