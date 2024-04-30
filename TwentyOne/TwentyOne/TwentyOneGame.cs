using System;
using System.Collections.Generic;
using System.Text;

namespace TwentyOne
{
   public class TwentyOneGame : Game, IWalkAway
    {
        public TwentyOneDealer Dealer { get; set; }
        public override void Play()
        {
            Dealer = new TwentyOneDealer();
            foreach (Player player in Players)
            {

            }
        }
        public override void ListPlayer()
        {
            Console.WriteLine("Welcome to 21 Game");
            base.ListPlayer();
        }
        public void WalkAway(Player player)
        {
            throw new NotImplementedException();
        }

    }
}
