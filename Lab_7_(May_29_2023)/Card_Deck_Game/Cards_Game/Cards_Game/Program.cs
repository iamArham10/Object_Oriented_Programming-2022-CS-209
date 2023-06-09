// See https://aka.ms/new-console-template for more information


using Cards_Game;
// printing the card game
char start_game;
do
{
    MainUI.Clear_Screen();
    // prints menu and get's input from user
    start_game = MainUI.Get_Menu(); 
    if (start_game == '1') 
    {
        // creates a new deck with 52 cards
        Deck newdeck = new Deck();
        int score = 0;
        // shuffles the cards
        newdeck.Shuffle();
        // player card
        Card player_card = newdeck.Deal_Card();
        // bool variable game runs while it's true
        bool game_running = true;
        while (game_running)
        {
            MainUI.Print_String("Your Current Card is ", player_card.Get_Value_nd_Suit());
            MainUI.Print_String("Remaining Cards Are ", $"{newdeck.Cards_Left()}");
            // inputs next card prediction from user
            char Prediction = MainUI.Card_Prediction_Menu();
            // get's a new card from deck object
            Card predicted_card = newdeck.Deal_Card();

            // conditions
            if (Prediction == 'h') // for prediction if next card is higher
            {
                if (predicted_card.Get_Value() >= player_card.Get_Value())
                {
                    MainUI.Print_String("Your Card : ", player_card.Get_Value_nd_Suit()); // prints user card
                    MainUI.Print_String("Predicted Card : ", predicted_card.Get_Value_nd_Suit()); // prints predicted card
                    score++;
                    // player card becomes user card
                    player_card = predicted_card;
                    MainUI.Clear_Screen();
                }
                else
                {
                    // if prediction is wrong game running variable will become false
                    game_running = false;
                }
            }

            else if (Prediction == 'l') // for prediction if next card is lower
            {
                if (predicted_card.Get_Value() <= player_card.Get_Value())
                {
                    MainUI.Print_String("Your Card : ", player_card.Get_Value_nd_Suit());
                    MainUI.Print_String("Predicted Card : ", predicted_card.Get_Value_nd_Suit());
                    score++;
                    // predicted card becomes player card
                    player_card = predicted_card;
                    MainUI.Clear_Screen();
                }
                else
                { 
                    game_running = false; // wrong prediction
                }
            }

            if (game_running == false)
            {
                MainUI.Print_String("Your Card : ", player_card.Get_Value_nd_Suit());
                MainUI.Print_String("Predicted Card : ", predicted_card.Get_Value_nd_Suit());
                MainUI.Print_Score(score);
                MainUI.Clear_Screen();
            }

            if (newdeck.Cards_Left() == 0 && predicted_card == null) // if deck card array is empty and predicted card will be null
            {
                Console.WriteLine("Congratulation You Scored The Maximum Score");
                break;
            }
        }
    }

}while (start_game != '0');

