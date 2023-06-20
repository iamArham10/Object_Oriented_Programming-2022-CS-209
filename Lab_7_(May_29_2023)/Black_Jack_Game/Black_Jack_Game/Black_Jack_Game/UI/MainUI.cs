using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Black_Jack_Game
{
    public class MainUI
    {
        // prints the main menu and takes option input from user
        public static char Main_Menu()
        {
            Console.WriteLine("Enter Any Of The Following Options : ");
            Console.WriteLine("1. Start The Game");
            Console.WriteLine("0. Exit");
            char option = char.Parse(Console.ReadLine());
            return option;
        }

        // prints  two strings first as meesage second as string
        public static void Print_String(string message, string str)
        {
            Console.Write(message + " : ");
            Console.WriteLine(str);
        }

        public static void Print_Cards(BlackJack hand)
        {
            for (int cardno = 0; cardno < hand.Get_Card_Count();cardno++)
            {
                Print_String($"The Card Number {cardno}", $"{hand.Get_Card(cardno)}");
            }
        }


    }
}
