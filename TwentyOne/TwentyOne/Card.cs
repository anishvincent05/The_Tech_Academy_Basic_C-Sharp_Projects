using System;
using System.Collections.Generic;
using System.Text;

namespace TwentyOne
{
    public struct Card
    {
        
        public Suit Suit { get; set; }
        public Face Face { get; set; }
        public override string ToString()//Overriding ToString method
        {
            return string.Format("{0} of {1} ",Face,Suit);
        }
    }
    public enum Suit
    {
        Club,
        Daimonds,
        Hearts,
        Spades
    }
    public enum Face
    {
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King,
        Ace
    }
}
