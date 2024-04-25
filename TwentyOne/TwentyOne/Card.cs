using System;
using System.Collections.Generic;
using System.Text;

namespace TwentyOne
{
    public class Card
    {
        
        public Suit Suit { get; set; }
        public Face Face { get; set; }
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
