using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    public class Deck
    {
        public Deck()
        {
            Cards = new List<Card>();

            for (int i = 0; i < 13; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Card card = new Card
                    {
                        Face = (Face)i,
                        Suit = (Suit)j
                    };
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
