using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cards_Game
{
    public class MainUI
    { 

        // prints the header of the game
        public static void Print_Header()
        {
            Console.WriteLine(".##.....##.####..######...##.....##....##........#######..##......##.....######.....###....########..########...######.");
            Console.WriteLine(".##.....##..##..##....##..##.....##....##.......##.....##.##..##..##....##....##...##.##...##.....##.##.....##.##....##");
            Console.WriteLine(".##.....##..##..##........##.....##....##.......##.....##.##..##..##....##........##...##..##.....##.##.....##.##......");
            Console.WriteLine(".#########..##..##...####.#########....##.......##.....##.##..##..##....##.......##.....##.########..##.....##..######.");
            Console.WriteLine(".##.....##..##..##....##..##.....##....##.......##.....##.##..##..##....##.......#########.##...##...##.....##.......##");
            Console.WriteLine(".##.....##..##..##....##..##.....##....##.......##.....##.##..##..##....##....##.##.....##.##....##..##.....##.##....##");
            Console.WriteLine(".##.....##.####..######...##.....##....########..#######...###..###......######..##.....##.##.....##.########...######.");
        }
        
        // prints the menu options to user and gets the input
        public static char Get_Menu()
        {
            Console.WriteLine("Enter The Following options : ");
            Console.WriteLine("1. Start The Game.");
            Console.WriteLine("0. Exit.");
            char option = char.Parse(Console.ReadLine());
            return option;
        }

        // clears the screen
        public static void Clear_Screen()
        {
            Console.WriteLine("Press Any key To Exit");
            Console.ReadKey();
            Console.Clear();
        }

        // get's next card prediction from user
        public static char Card_Prediction_Menu()
        {
            Console.WriteLine("Enter Your Preference : ");
            Console.WriteLine("h. Next Card Will Be Higher : ");
            Console.WriteLine("l. Next Card Will Be Lower : ");
            char pref = char.Parse(Console.ReadLine());
            return pref;
        }

        // prints specified strings to console
        public static void Print_String( string message ,string str)
        {
            Console.Write(message + " : ");
            Console.WriteLine(str);
        }

        // prints specified string to console
        public static void Print_String(string str)
        {
            Console.WriteLine(str);
        }

        // prints endgame Score
        public static void Print_Score(int score)
        {
            Console.WriteLine("Your Final Score Was " + score);
        }
        
        
    }
}
