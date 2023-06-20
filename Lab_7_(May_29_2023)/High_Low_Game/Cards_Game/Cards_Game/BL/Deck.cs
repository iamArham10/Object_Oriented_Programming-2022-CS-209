using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
namespace Cards_Game
{
    /// <summary>
    /// Deck class will contain 52 cards implementing deck of cards
    /// </summary>
    public class Deck
    {
        // a integer count represents number of cards remaining
        private int cardscount;
        // empty Card object array that'll contain 52 cards
        private Card[] deck = new Card[52];
        // constructor creates 52 cards
        public Deck() 
        {
            int CardNumber = 0; // index number to store in deck array
            for (int suit = 1; suit <= 4; suit++) // selects suit of card
            {
                for (int value = 1; value <=13; value++) // select value of card
                {
                    // creates card and stores in integer Cardnumber index value
                    deck[CardNumber] = new Card(value, suit);
                    // incredement index value of array
                    CardNumber++;
                }
            }
            this.cardscount = CardNumber;
        }   

        // shuffles the cards
        public void Shuffle()
        {
            System.Random random = new System.Random(); // creating a random variable object
            for (int current_card = 0; current_card < deck.Length; current_card++) 
            {
                // using random object method that'll return random number from 0 to deck.length
                int random_index = random.Next(deck.Length); 
                // stores current index card object in temporary variable
                Card temp = deck[current_card];
                // stores random index object in current card
                deck[current_card] = deck[random_index];
                // stores temporary object in random index
                deck[random_index] = temp; 
            }
        }

        // returns number of cards left
        public int Cards_Left()
        {
            return this.cardscount;
        }

        // deal card option returns one card at the last of the array aka top of the deck
        // and deletes it from the list
        public Card Deal_Card()
        {
            if (cardscount > 0) // checks if there is any card present
            { 
                this.cardscount--; // decrements the card_count
                // returns value that was at the last suppose 42 values were in array
                // 41 will be last index but after removing one 40 will be the last index
                // but there will be still 42 values.
                return this.deck[cardscount]; 
            }
            else // if no card present
            {
                return null; // returns null object
            }
        }

    }
}
