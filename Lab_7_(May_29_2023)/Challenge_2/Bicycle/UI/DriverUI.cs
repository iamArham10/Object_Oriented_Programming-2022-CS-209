using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bicycle
{
    class DriverUI
    {
        public static char Main_Menu()
        {
            char option;
            Console.WriteLine("Enter Any Of The Following Options");
            Console.WriteLine("1 Create a Bicycle");
            Console.WriteLine("2 Set Cadence");
            Console.WriteLine("3 Set Gear");
            Console.WriteLine("4 Apply Break");
            Console.WriteLine("5 Increase Speed");
            Console.WriteLine("6 See Bicycle State");
            option = char.Parse(Console.ReadLine());
            return option;
        }

        public static void Clear_Screen()
        {
            Console.WriteLine("Press Any key to Continue...");
            Console.ReadKey();
            Console.Clear();
        }

        public static String Get_String(string message)
        {
            Console.WriteLine(message + " : ");
            string var = Console.ReadLine();
            return var;
        }

        public static int Get_Integer(string message)
        {
            Console.WriteLine(message + " : ");
            int integer = int.Parse(Console.ReadLine());
            return integer;
        }

    }
}
