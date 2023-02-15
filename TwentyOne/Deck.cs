using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class Deck
    {
        public Deck()
        {
            Cards = new List<Card>();
            List<string> Suits = new List<string>() { "Clubs", "Hearts", "Diamonds", "Spades" };
            List<string> Faces = new List<string>()
            {
                "Two", "Three", "Four", "Five", "Six", "Seven",
                "Eight", "Nine", "Ten", "Jack", "Queen", "King", "Ace"
            };

            foreach (string face in Faces)
            {
                foreach (string suit in Suits)
                {
                    Card card = new Card();
                    card.Suit = suit;
                    card.Face = face;
                    Cards.Add(card);
                }
            }
        }
        // List data type easier to use than array
        public List<Card> Cards { get; set; }

        // When assigning default value, we're assuming it's 1
        // Creates optional parameters in this method
        // "out int timesShuffled" = out parameter, goes before optional parameters
        public void Shuffle(int times = 1)
        {
            for (int i = 0; i < times; i++)
            {
                List<Card> TempList = new List<Card>();
                Random random = new Random();
                while (Cards.Count > 0)
                {
                    // Creates random index, takes min and max value
                    int randomIndex = random.Next(0, Cards.Count);
                    //Adds it to our TempList
                    TempList.Add(Cards[randomIndex]);
                    //Function of list method that removes Random Index
                    Cards.RemoveAt(randomIndex);
                }
                Cards = TempList;
            }
        }
    }
        


}
