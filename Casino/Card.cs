using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    public struct Card
    {
        // Constructor: Value assigned to object upon creation 
        public Face Face { get; set; }
        public Suit Suit { get; set; }
        

        public override string ToString()
        {
            return string.Format("{0} of {1}", Face, Suit);
        }
    }
    
    public enum Face
    {
        Two,
        Three,
        Four,
        Five,
        Six ,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King,
        Ace
    }

    public enum Suit
    {
        Clubs,
        Diamonds,
        Hearts,
        Spades
    }
}
