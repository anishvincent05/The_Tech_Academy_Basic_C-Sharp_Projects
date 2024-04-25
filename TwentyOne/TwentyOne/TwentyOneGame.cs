using System;
using System.Collections.Generic;
using System.Text;

namespace TwentyOne
{
   public class TwentyOneGame : Game, IWalkAway
    {
        public override void Play()
        {
            throw new NotImplementedException();
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
