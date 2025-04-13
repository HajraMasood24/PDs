using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.BL
{
    internal class Hand
    {
        protected List<Card> cards = new List<Card>();

        public void addCard(Card card)
        {
            cards.Add(card);
        }

        public int getCardCount()
        {
            return cards.Count;
        }

        public Card getCard(int index)
        {
            return cards[index];
        }

        public void clear()
        {
            cards.Clear();
        }

        public void showHand()
        {
            foreach (Card card in cards)
            {
                Console.WriteLine(card.toString());
            }
        }
    }

}

