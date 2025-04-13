using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp2.BL;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            Deck deck = new Deck();
            deck.shuffle();

            BlackjackHand player = new BlackjackHand();
            BlackjackHand dealer = new BlackjackHand();

            // Deal 2 cards to each
            player.addCard(deck.dealCard());
            player.addCard(deck.dealCard());

            dealer.addCard(deck.dealCard());
            dealer.addCard(deck.dealCard());

            Console.WriteLine("Dealer's visible card: " + dealer.getCard(0).toString());

            Console.WriteLine("\nYour hand:");
            player.showHand();
            Console.WriteLine("Total: " + player.getBlackjackValue());

            // Player turn
            while (true)
            {
                Console.Write("\nDo you want to Hit or Stand? (h/s): ");
                string input = Console.ReadLine().ToLower();

                if (input == "h")
                {
                    player.addCard(deck.dealCard());
                    Console.WriteLine("\nYour hand:");
                    player.showHand();
                    int value = player.getBlackjackValue();
                    Console.WriteLine("Total: " + value);

                    if (value > 21)
                    {
                        Console.WriteLine("You busted! Dealer wins.");
                        return;
                    }
                }
                else if (input == "s")
                {
                    break;
                }
            }

            // Dealer turn
            Console.WriteLine("\nDealer's hand:");
            dealer.showHand();
            while (dealer.getBlackjackValue() < 17)
            {
                Console.WriteLine("Dealer hits...");
                dealer.addCard(deck.dealCard());
                dealer.showHand();
            }

            int playerValue = player.getBlackjackValue();
            int dealerValue = dealer.getBlackjackValue();

            Console.WriteLine($"\nFinal Scores - You: {playerValue} | Dealer: {dealerValue}");

            if (dealerValue > 21)
            {
                Console.WriteLine("Dealer busted! You win!");
            }
            else if (playerValue > dealerValue)
            {
                Console.WriteLine("You win!");
            }
            else if (playerValue < dealerValue)
            {
                Console.WriteLine("Dealer wins.");
            }
            else
            {
                Console.WriteLine("It's a tie!");
            }
            
        }

    }
}
    


