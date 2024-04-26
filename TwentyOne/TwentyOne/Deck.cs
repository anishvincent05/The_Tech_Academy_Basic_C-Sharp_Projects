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
            
            Cards = new List<Card>();//Create Deck of 52 cards

            for(int i = 0; i < 13; i++)
            {
                for(int j=0 ; j < 4; j++)
                {
                    Card card = new Card();
                    card.Face = (Face)i;//Converting int to enum
                    card.Suit = (Suit)j;//Converting int to enum
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
