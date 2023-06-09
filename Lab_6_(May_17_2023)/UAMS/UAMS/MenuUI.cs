using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAMS
{
    class MenuUI
    {
        public static void Header()
        {
            Console.WriteLine("*********************************");
            Console.WriteLine("*              UAMS             *");
            Console.WriteLine("*********************************");
        }

        public static char Menu()
        {
            Header();
            char option;
            Console.WriteLine("Enter Option: ");
            Console.WriteLine("1. Add Student.");
            Console.WriteLine("2. Add Degree Program.");
            Console.WriteLine("3. Generate Merit.");
            Console.WriteLine("4. View Registered Students.");
            Console.WriteLine("5. View Students of Specific Degree.");
            Console.WriteLine("6. Register Subject For Student.");
            Console.WriteLine("7. Calculate Fees for all Registered Students.");
            Console.WriteLine("8. Exit");
            option = char.Parse(Console.ReadLine());
            return option;
        }

        public static void Clear_Screen()
        {
            Console.WriteLine("Press Any Key to Exit..");
            Console.ReadKey();
            Console.Clear();

        }
    }
}
