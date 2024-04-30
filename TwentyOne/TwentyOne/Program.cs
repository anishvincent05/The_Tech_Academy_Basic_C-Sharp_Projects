using System;
using System.Collections.Generic;
using System.Text;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Grand Hotel and Casino. Let's start by telling me your name.");
            string playerName = Console.ReadLine();//Reading user name
            Console.WriteLine("And how much money did you bring today?");
            int bank = Convert.ToInt32(Console.ReadLine());//Reading user money
            Console.WriteLine("Hello,{0}. Would you like to join a game of 21 right now?", playerName);
            string answer = Console.ReadLine().ToLower();//Reading user input and coverting to lower case
            if(answer == "yes" || answer == "yeah" || answer == "y")

            {
                Player player = new Player(playerName,bank);//Passing value to contractor
                Game game = new TwentyOneGame();
                game += player; //Adding player to game
                player.isActivePlaying = true;
                while(player.isActivePlaying && player.Balance >0)//Checking status of player
                {
                    game.Play();//Start game
                }
                game -= player;
                Console.WriteLine("Thank you for playing");
            }
            Console.WriteLine("Feel free to look around the casino. Bye for now.");
            Console.Read();
           

        }
        
        
    }
}
