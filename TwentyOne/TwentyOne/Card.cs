using System;
using System.Collections.Generic;
using System.Text;

namespace TwentyOne
{
    public class Card
    {
        public Card()
        {
            Suit = "Spade";
            Face = "Two";
        }
        public string Suit { get; set; }
        public string Face { get; set; }
    }
}
