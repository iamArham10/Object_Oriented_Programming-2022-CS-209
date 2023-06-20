// main program
// start

using Black_Jack_Game;
using System.Net.Sockets;

char option;
do
{
    option = MainUI.Main_Menu();
    if (option == '1')
    {
        // boolean variable determines if game is running or not
        bool Game_Starting = true;
        // creates a deck of cards
        Deck newdeck = new Deck(); 
        // shuffling the cards
        newdeck.Shuffle();
        // creating Dealer BlackJack Hand
        BlackJack Dealer = new BlackJack();
        // creating Player BlackJack Hand
        BlackJack Player = new BlackJack();
        // adding two cards to dealer's hand from deck
        Dealer.Add_Card(newdeck.Deal_Card());
        Dealer.Add_Card(newdeck.Deal_Card());
        // addings cards to player's hand from deck
        Player.Add_Card(newdeck.Deal_Card());
        Player.Add_Card(newdeck.Deal_Card());

        // starting the game
        // 
        while (Game_Starting)
        {
            // checks if player is dealt with 21 that means he got BlackJack from start 
            // only possible if two cards are Ace and 10.
            if (Player.Get_BlackJack_Value() == 21)  
            {
                Game_Starting = false;
                break;
            }
            // prints the upper Dealer card
            MainUI.Print_String("Dealer's Upper Card", $"{Dealer.Get_Card(Dealer.Get_Card_Count() - 1)}");
            // prints player's all cards
            MainUI.Print_Cards(Player);

            
        }
    }
}while(option != '0');