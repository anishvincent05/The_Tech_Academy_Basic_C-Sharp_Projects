﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new TwentyOneGame();
            game.Players = new List<Player>();
            Player player = new Player();
            player.Name = "Anish";
            game += player;
            Deck deck = new Deck();
            deck.Shuffle(5);
           
            

            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face +"of"+ card.Suit);
                
            }
            Console.WriteLine(deck.Cards.Count);
           

        }
        
        
    }
}
