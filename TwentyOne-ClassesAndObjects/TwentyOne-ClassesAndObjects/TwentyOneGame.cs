﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne_ClassesAndObjects
{
    public class TwentyOneGame : Game, IWalkAway // IWalkAway is an interface. Naming convention for interface, start with "I".
    {
        public TwentyOneDealer Dealer { get; set; }
        public override void Play()
        {
            Dealer = new TwentyOneDealer();
            foreach (Player player in Players)
            {
                player.Hand = new List<Card>();
                player.Stay = false;
            }
            Dealer.Hand = new List<Card>();
            Dealer.Stay = false;
            Dealer.Deck = new Deck();
            Dealer.Deck.Shuffle();
            Console.WriteLine("Place your bet!");

            foreach (Player player in Players)
            {
                Console.WriteLine("Current total: {0}", player.Balance);
                int bet = Convert.ToInt32(Console.ReadLine());
                bool successfullyBet = player.Bet(bet);
                if (!successfullyBet)
                {
                    return; // Will end the current Play method, and restart it so the player can place another bet.
                }
                Bets[player] = bet; // for each player, record their bets in this Dictionary.
            }
            for (int i = 0; i < 2; i++) // Do two times, so each player gets two cards.
            {
                Console.WriteLine("Dealing...");
                foreach (Player player in Players)
                {
                    Console.Write("{0}: ", player.Name);
                    Dealer.Deal(player.Hand);
                    if (i == 1) // After player receives second card...
                    {
                        bool blackJack = TwentyOneRules.CheckForBlackJack(player.Hand); // Check for blackjack.
                        if (blackJack)
                        {
                            Console.WriteLine("Blackjack! {0} wins {1}", player.Name, Bets[player]);
                            player.Balance += Convert.ToInt32((Bets[player] * 1.5) + Bets[player]);
                            return;
                        }
                    }
                }
                Console.Write("Dealer: ");
                Dealer.Deal(Dealer.Hand);
                if (i == 1) // After dealer receives second card...
                {
                    bool blackJack = TwentyOneRules.CheckForBlackJack(Dealer.Hand); // Check for blackjack.
                    if (blackJack)
                    {
                        Console.WriteLine("Dealer has Blackjack! Everyone loses!");
                        foreach(KeyValuePair<Player, int> entry in Bets)
                        {
                            Dealer.Balance += entry.Value;
                        }
                        return;
                    }
                }
            }

            foreach(Player player in Players)
            {
                while (!player.Stay)
                {
                    Console.WriteLine("Your cards are: "); // After receiveing two cards, and after hitting, write cards to the console.
                    foreach( Card card in player.Hand)
                    {
                        Console.Write("{0} ", card.ToString());
                    }
                    Console.WriteLine("\n\nDealer's cards are: "); // Also write the dealer's cards for quick comparison.
                    foreach (Card card in Dealer.Hand)
                    {
                        Console.Write("{0} ", card.ToString());
                    }
                    Console.WriteLine("\n\nHit or stay?");
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
                    bool busted = TwentyOneRules.IsBusted(player.Hand); // Determine if player busted.
                    if (busted)
                    {
                        Dealer.Balance += Bets[player];
                        Console.WriteLine("{0} Busted! You lose your bet of {1}. Your balance is now {2}.", player.Name, Bets[player], player.Balance);
                        if (player.Balance == 0) // If new balance is 0, game ends.
                        {
                            player.IsActivelyPlaying = false;
                            return;
                        }
                        Console.WriteLine("Do you want to play again?");
                        answer = Console.ReadLine().ToLower(); //Case insensitive
                        if (answer == "yes" || answer == "yeah" || answer == "sure" || answer == "ok")
                        {
                            player.IsActivelyPlaying = true;
                            return;
                        }
                        else // any response other than the few above will end the game.
                        {
                            player.IsActivelyPlaying = false;
                            return;
                        }
                    }
                }
            }
            Dealer.isBusted = TwentyOneRules.IsBusted(Dealer.Hand);
            Dealer.Stay = TwentyOneRules.ShouldDealerStay(Dealer.Hand);
            while (!Dealer.Stay && !Dealer.isBusted) // Dealer only hits if 16 or less.
            {
                Console.WriteLine("Dealer is hitting...");
                Dealer.Deal(Dealer.Hand);
                Dealer.isBusted = TwentyOneRules.IsBusted(Dealer.Hand);
                Dealer.Stay = TwentyOneRules.ShouldDealerStay(Dealer.Hand);
            }
            if (Dealer.Stay)
            {
                Console.WriteLine("Dealer is staying.");
            }
            if (Dealer.isBusted)
            {
                Console.WriteLine("Dealer Busted!");
                foreach (KeyValuePair<Player, int> entry in Bets)
                {
                    Console.WriteLine("{0} won {1}", entry.Key.Name, entry.Value);
                    Players.Where(x => x.Name == entry.Key.Name).First().Balance += (entry.Value * 2);
                    Dealer.Balance -= entry.Value;
                }
                return;
            }
            foreach (Player player in Players)
            {
                bool? playerWon = TwentyOneRules.CompareHands(player.Hand, Dealer.Hand); //? allows structs to have Null value
                if (playerWon == null)
                {
                    Console.WriteLine("Push! No one wins.");
                    player.Balance += Bets[player];
                    Bets.Remove(player);
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
                    if (player.Balance == 0)
                    {
                        Console.WriteLine("Your balance is 0.");
                        player.IsActivelyPlaying = false;
                        return;
                    }
                }
                Console.WriteLine("Play again?");
                string answer = Console.ReadLine().ToLower();
                if (answer == "yes" || answer == "yeah")
                {
                    player.IsActivelyPlaying = true;
                }
                else
                {
                    player.IsActivelyPlaying = false;
                }
            }
            


        }
        public override void ListPlayers()
        {
            Console.WriteLine("21 Players: ");
            base.ListPlayers();
        }
        public void WalkAway(Player player)
        {
            throw new NotImplementedException();
        }
    }
}
