using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.BL
{
    internal class BlackjackHand : Hand
    {
        public int getBlackjackValue()
        {
            int val = 0;
            int aceCount = 0;

            foreach (Card card in cards)
            {
                int cardValue = card.getValue();
                if (cardValue > 10)
                {
                    val += 10; // Jack, Queen, King
                }
                else if (cardValue == 1)
                {
                    val += 1;
                    aceCount++;
                }
                else
                {
                    val += cardValue;
                }
            }

            // Upgrade ace value to 11 if it doesn’t bust
            if (aceCount > 0 && val + 10 <= 21)
            {
                val += 10;
            }

            return val;
        }
    }

}

