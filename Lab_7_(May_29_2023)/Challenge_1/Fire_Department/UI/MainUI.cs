using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fire_Department
{   // contains Driver Program functions like menu function etc
    class MainUI
    {
        static public char Main_Menu()
        {
            char option;
            Console.WriteLine("Enter The Following Option: ");
            Console.WriteLine("1. Add FireFighter");
            Console.WriteLine("2. Add Truck");
            option = char.Parse(Console.ReadLine());
            return option;
        }
        
        static public void Clear_Screen()
        {
            Console.WriteLine("Press Any Key to Clear");
            Console.ReadKey();
            Console.Clear();
        }


    }
}
