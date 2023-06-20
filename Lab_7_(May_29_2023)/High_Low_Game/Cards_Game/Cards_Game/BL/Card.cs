using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Cards_Game
{   
    public class Card
    /// <summary>
    /// Cards Class implements real world card with value and suit
    /// </summary>
    {
        // attributes
        private int value;
        private int suit;

        // constructor 
        public Card(int value, int suit) 
        { 
            this.value = value;
            this.suit = suit;
        }

        // get function
        public int Get_Value()
        {
            return this.value;
        }

        public int Get_Suit()
        {
            return this.suit;
        }

        // functions returning human readable forms of value and suit of cards
        public string Get_Value_aString() // returns values as string of cards
        {
            string ValueAstring;
            if (value == 1)
            {
                ValueAstring = "Ace";

            }
            else if (value == 11)
            {
                ValueAstring = "Jack";
            }
            else if (value == 12)
            {
                ValueAstring = "Queen";
            }
            else if (value == 13)
            {
                ValueAstring = "King";
            }
            else
            {
                ValueAstring = $"{this.value}";
            }
            return ValueAstring;
        }

        public string Get_Suit_aString() // returns cards suits as strings
        {
            string SuitAstring;
            if (suit == 1)
            {
                SuitAstring = "Clubs";
            }
            else if (suit == 2)
            {
                SuitAstring = "Diamonds";
            }
            else if (suit == 3)
            {
                SuitAstring = "Spades";
            }
            else 
            {
                SuitAstring = "Hearts";
            }
            return SuitAstring;
        }

        public string Get_Value_nd_Suit() // returns value as string with suit as string
        {
            return Get_Value_aString() + " of " + Get_Suit_aString();
        }


    }
}
