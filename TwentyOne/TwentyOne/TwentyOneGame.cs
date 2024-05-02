using System;
using System.Collections.Generic;
using System.Linq;
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
                player.Hand = new List<Card>();//Resetting hands
                player.Stay = false;

            }
            Dealer.Hand = new List<Card>();//Resetting hands
            Dealer.Stay = false;
            Dealer.Deck = new Deck();
            Dealer.Deck.Shuffle();
            Console.WriteLine("Place your bet!");
            foreach (Player player in Players)//Taking bet from each player
            {
                int bet = Convert.ToInt32(Console.ReadLine());//Getting bet amount
                bool successfullyBet = player.Bet(bet);
                if (!successfullyBet)
                {
                    return;
                }
                Bets[player] = bet;//Players bet
            }
            for(int i=0; i<2;i++) //Giving card to player
            {
                Console.WriteLine("Dealing...");
                foreach(Player player in Players)
                {
                    Console.Write("{0}",player.Name);
                    Dealer.Deal(player.Hand);//Dealing card 
                    if (i==0)
                    {
                        bool blackJack = TwentyOneRules.CheckForBlackJack(player.Hand);//checking Black Jack
                        if (blackJack)
                        {
                            Console.WriteLine("Blackjack! {0} win {1}", player.Name, Bets[player]);
                            player.Balance += Convert.ToInt32((Bets[player] * 1.5) + Bets[player]);
                            return;
                        }

                    }
                }
                Console.Write("Dealer:");
                Dealer.Deal(Dealer.Hand);
                if (i==1)
                {
                    bool blackJack = TwentyOneRules.CheckForBlackJack(Dealer.Hand);//Checking black jack for dealer
                    if (blackJack)
                    {
                        Console.WriteLine("Dealer has BlackJack! Everyone loses!");
                        foreach (KeyValuePair < Player,int> entry in Bets)//iterating through dictionary of players
                        {
                            Dealer.Balance += entry.Value;//Adding bets to dealer balance
                        }
                        return;
                    }
                }

            }
            foreach (Player player in Players)//Asking player want to stay
            {
                 while(!player.Stay)
                {
                    Console.WriteLine("Your cards are:");
                    foreach(Card card in player.Hand)
                    {
                        Console.Write("{0}", card.ToString());
                    }
                    Console.WriteLine("\n\nHit or stay");
                    string answer = Console.ReadLine().ToLower();
                    if (answer == "stay")
                    {
                        player.Stay = true;
                        break;
                    }
                    else if (answer == "hit")
                    {
                        Dealer.Deal(player.Hand);
                    }
                    bool busted = TwentyOneRules.IsBusted(player.Hand);//Checking if player is busted
                    if(busted)//if player is busted
                    {
                        Dealer.Balance += Bets[player];
                        Console.WriteLine("{0} Busted! You lose yout bet of {1} . Your balance is now {2}.", player.Name, Bets[player], player.Balance);
                        Console.WriteLine("Do you want to play again?");
                        answer = Console.ReadLine().ToLower();
                        if (answer == "yes" || answer == "yeah")//Checking player want to play again
                        {
                            player.isActivePlaying = true;
                            return;
                        }
                        else
                        {
                            player.isActivePlaying = false;
                            return;
                        }
                    }
                }
            }
            Dealer.isBusted = TwentyOneRules.IsBusted(Dealer.Hand);//Checking dealer is busted
            Dealer.Stay = TwentyOneRules.ShouldDealerStay(Dealer.Hand);//Checking dealer should stay
            while (!Dealer.Stay && !Dealer.isBusted)//Dealer hitting until busted or stay
            {
                Console.WriteLine("Dealer is hitting...");
                Dealer.Deal(Dealer.Hand);
                Dealer.isBusted = TwentyOneRules.IsBusted(Dealer.Hand);
                Dealer.Stay = TwentyOneRules.ShouldDealerStay(Dealer.Hand);
                    }
            if(Dealer.isBusted)
            {
                Console.WriteLine("Dealer Busted!");
                foreach(KeyValuePair<Player,int> entry in Bets)//Displaying win amount for each player

                {
                    Console.WriteLine("{0} won {1}!", entry.Key.Name, entry.Value);
                    Players.Where(x => x.Name == entry.Key.Name).First().Balance += (entry.Value * 2);//Adding win amount for each player
                    Dealer.Balance -= entry.Value;
                }
                return;
            }
            foreach(Player player in Players)//Comparing each player hand with dealer
            {
                bool? playerWon = TwentyOneRules.CompareHands(player.Hand, Dealer.Hand);
                if (playerWon == null)
                {
                    Console.WriteLine("Push! No one wins.");
                    player.Balance += (Bets[player]);
                }
                else if (playerWon == true)
                {
                    Console.WriteLine("{0} won {1}!", player.Name, Bets[player]);
                    player.Balance += (Bets[player] * 2);
                    Dealer.Balance -= Bets[player];
                }  
                else
                {
                    Console.WriteLine("Dealer wins {0}!", Bets[player]);
                    Dealer.Balance += Bets[player];
                }
                Console.WriteLine("Play again?");//Asking each player for playing again
                string answer = Console.ReadLine().ToLower();
                if (answer == "yes" || answer == "yeah")
                {
                    player.isActivePlaying = true;//Assigning bool value if player is playing
                }
                else
                {
                    player.isActivePlaying = false;//Assigning bool value
                                                   //if player is playing
                }
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
