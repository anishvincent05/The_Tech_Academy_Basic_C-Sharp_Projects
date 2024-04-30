using System;
using System.Collections.Generic;
using System.Text;

namespace TwentyOne
{
   public class Player
    { public Player(string name,int beginingBalance)//Contractor for intialising player details from main program
        {
            Hand = new List<Card>();
            Balance = beginingBalance;
            Name = name;
        }
        public List<Card> Hand { get; set; }
        public string Name { get; set; }
        public int Balance { get; set; }
        public bool isActivePlaying { get; set; }
        public bool Stay { get; set; }

        public static Game operator+ (Game game,Player player)
        {
            game.Players.Add(player);
            return game;
        }
        public static Game operator -(Game game, Player player)
        {
            game.Players.Remove(player);
            return game;
        }
    }
}
