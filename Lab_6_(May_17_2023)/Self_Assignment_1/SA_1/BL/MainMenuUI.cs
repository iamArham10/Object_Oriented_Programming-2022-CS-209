using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SA_1
{
    class MainMenuUI
    {
        public static char MainMenu()
        {
            char option;
            Console.WriteLine("Enter Any Of The Options: ");
            Console.WriteLine("1. Add a Menu Item");
            Console.WriteLine("2. View the Cheapest Item In the Menu");
            Console.WriteLine("3. View The Drink's Menu");
            Console.WriteLine("4. View The Food's Menu");
            Console.WriteLine("5. Add Order");
            Console.WriteLine("6. FullFill The Order");
            Console.WriteLine("7. View the Order's List");
            Console.WriteLine("8. Total Payable Amount");
            Console.WriteLine("9. Exit");
            option = char.Parse(Console.ReadLine());
            return option;
        } 

        public static void End_Screen()
        {
            Console.WriteLine("Press Any Key To Continue..");
            Console.ReadKey();
            Console.Clear();
        }
        
        public static void Clear_Screen()
        {
            Console.Clear();
        }


    }
}
