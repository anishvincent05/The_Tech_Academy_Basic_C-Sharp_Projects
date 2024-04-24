using System;
using System.Collections.Generic;
using System.Text;


namespace TwentyOne
{
    public class Deck

    {
        public List<Card> Cards { get; set; }
        public Deck()
        {
            List<string> Suits = new List<string>() { "Clubs", "Hearts", "Daimonds", "Spades" };
            List<string> Faces = new List<string>() { "Two","Three","Four","Five","Six","Seven","Eight","Nine","Ten","Jack",
                                                "Queen","King","Ace"};
            Cards = new List<Card>();

            foreach (string face in Faces)
            {
                foreach (string suit in Suits)
                {
                    Card card = new Card();
                    card.Face = face;
                    card.Suit = suit;
                    Cards.Add(card);
                }
            }
        }
        public void Shuffle( int times = 1)
        {

            for (int i = 0; i < times; i++)
            {
                List<Card> TempList = new List<Card>();
                Random random = new Random();

                while (Cards.Count > 0)
                {
                    int randomIndex = random.Next(0,Cards.Count);
                    TempList.Add(Cards[randomIndex]);
                    Cards.RemoveAt(randomIndex);
                }
                Cards = TempList;
               
            }
            

        }
    }
}
