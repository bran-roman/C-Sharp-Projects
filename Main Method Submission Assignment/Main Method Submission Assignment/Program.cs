using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Method_Submission_Assignment
{
    class Program
    {
        public int Data { get; set; }
        static void Main()
        {
            // 2. Instantiate the class and call the one method, passing in an integer and display results on screen
            Console.WriteLine("Please input an integer to perform math operations on.");
            int intNum = Convert.ToInt32(Console.ReadLine());
            var operationObject = new Operations();
            var addResult = operationObject.Add(intNum);

            // Prints addResult
            Console.Write("Your number: " + intNum + " + " + intNum + " = " + addResult);
            Console.ReadLine();

            // 4. Instatiate class and call second method, passing in a decimal and display results
            Console.WriteLine("Please input a decimal to perform math operations on");
            decimal decNum = Convert.ToDecimal(Console.ReadLine());
            var timesResult = operationObject.Add(decNum);

            // Prints timesResult
            Console.WriteLine(decNum + " multiplied by " + decNum + " returned as an integer is " + timesResult);
            Console.ReadLine();

            // 6. Instatiate class + call third method, passing in a string equating to integer and display
            Console.WriteLine("Please input a string to perform math operations on");
            string strNum = Console.ReadLine();
            var divResult = operationObject.Add(strNum);

            // Prints divResult
            Console.WriteLine(strNum + " divided by " + strNum + " returned as an integer is " + divResult);
            Console.ReadLine();
        }
    }
}

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace TwentyOne
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Deck deck = new Deck();
//            int timesShuffled = 0;
//            // deck = Shuffle(deck);
//            // Named parameter in parentheses "deck: deck")
//            deck = Shuffle(deck: deck, out timesShuffled, 3);

//            foreach (Card card in deck.Cards)
//            {
//                Console.WriteLine(card.Face + " of " + card.Suit);
//            }
//            Console.WriteLine(deck.Cards.Count);
//            Console.WriteLine("Times shuffled: {0}", timesShuffled);
//            Console.ReadLine();

//        }
//        // When assigning default value, we're assuming it's 1
//        // Creates optional parameters in this method
//        // "out int timesShuffled" = out parameter, goes before optional parameters
//        public static Deck Shuffle(Deck deck, out int timesShuffled, int times = 1)
//        {
//            for (int i = 0; i < times; i++)
//            {
//                List<Card> TempList = new List<Card>();
//                Random random = new Random();
//                while (deck.Cards.Count > 0)
//                {
//                    timesShuffled++;
//                    // Creates random index, takes min and max value
//                    int randomIndex = random.Next(0, deck.Cards.Count);
//                    //Adds it to our TempList
//                    TempList.Add(deck.Cards[randomIndex]);
//                    //Function of list method that removes Random Index
//                    deck.Cards.RemoveAt(randomIndex);
//                }
//                deck.Cards = TempList;
//            }

//            return deck;
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
