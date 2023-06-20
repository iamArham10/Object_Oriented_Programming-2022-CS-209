using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cards_Game
{
   
    public class Hand
    /// <summary>
    /// Hand class implements real functionality of hand in cards game
    /// we can add cards to hand object 
    /// </summary>
    {
        // attributes
        private List<Card> cards = new();

        // constructor 
        public Hand() { }

        // functions

        // clears the list of cards making hand empty
        public void Clear() 
        {
            cards = new List<Card>();
        }

        // adds card to cards list
        public void Add_Card(Card card)
        {
            if (card != null) 
            {
                if (!(cards.Contains(card)))
                {
                    cards.Add(card);
                }
            }
        }

        // to remove card from list
        public void Remove_Card(Card card)
        {
            if (cards.Contains(card))
            {
                cards.Remove(card);
            }
        }

        // remove the card in the specified position
        public void Remove_Card(int position)
        {
            cards.RemoveAt(position);     
        }

        // returns number of cards in the hand
        public int Get_Card_Count()
        {
            return cards.Count;
        }

        // returns the card at the specified position
        public Card Get_Card(int position)
        {
            return cards[position];
        }

        // sorts the cards by suit
        public void Sort_By_Suit()
        {
            cards = cards.OrderBy(o => o.Get_Suit()).ToList();
        }

        // sorts the cards by value
        public void Sort_By_Value()
        {
            cards = cards.OrderBy(o => o.Get_Value()).ToList();
        }
    }
}
