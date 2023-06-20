using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Black_Jack_Game
{
    /// <summary>
    /// BlackJack hands extends hand class this has function that returns the value of all cards in hand
    /// </summary>
    
    public class BlackJack : Hand
    {
        // constructor
        public BlackJack() { }  

        // function
        public int Get_BlackJack_Value()
        {
            // total value of cards
            int value = 0;
            // number of cards hand contains
            int Number_of_Cards = base.Get_Card_Count();
            // checks if it contains any ace 
            bool IsAcePresent = false;
            foreach (Card card in base.cards)
            {
                // gets value as string of card in hand
                string card_value = card.Get_Value_aString();

                // checks if card is ace bool will become true to identify there is ace card present
                if (card_value == "Ace")
                {
                    IsAcePresent = true;
                }
                // checks if jack, queen or king then ads 10 to value
                if (card_value == "Jack" || card_value == "Queen" || card_value == "King")
                {
                    value += 10;
                }
                // else adds card value to value variable
                else
                {
                    value += card.Get_Value();
                }
            }
            // after calculating all value
            // if there was any ace card will add 10 more cause 1st ace card has value 11
            if (IsAcePresent == true)
            {
                value += 10;
            }
            // returns the value as integer
            return value;
        }
    }
}
