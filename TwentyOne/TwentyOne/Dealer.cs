using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace TwentyOne
{
   public class Dealer
    {
        public Deck Deck { get; set; }
        public string Name { get; set; }
        public int Balance { get; set; }
        
        public void Deal(List<Card> Hand)
        {
            Hand.Add(Deck.Cards.First());
            Console.WriteLine(Hand.First());
            Deck.Cards.RemoveAt(0);
        }
          
        
    }
}
