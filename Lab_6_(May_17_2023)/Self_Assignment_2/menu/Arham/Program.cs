using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arham
{
    class Menu
    {
        List<int> options;
        int option_position;
        public Menu(List<int> options)
        {
            this.options = options;
            option_position = 0;
        }
        public void Move_Right()
        {
            if (option_position == (options.Count - 1))
            {
                option_position = 0;
            }
            else
            {
                option_position++;
            }
        }

        public string Display()
        {
            string totallist = "";
            totallist += "[";
            for(int x = 0; x < options.Count; x++)
            {
                if (x == option_position)
                {
                    totallist += $"[{options[x]}],";
                }
                else
                {
                    totallist += $"{options[x]},";
                }
            }
            totallist += "]";
            return totallist;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int numberofoptions;
            Console.WriteLine("Enter Number Of Menu Options: ");
            numberofoptions = int.Parse(Console.ReadLine());
            List<int> options = new List<int>();

            for (int x = 0; x < numberofoptions; x++)
            {
                options.Add(int.Parse(Console.ReadLine()));
            }

            Menu newmenu = new Menu(options);
            Console.WriteLine("Enter How many times you want to move: ");
            int xy = int.Parse(Console.ReadLine());
            int y = 0;
            while (y < xy)
            {
                newmenu.Move_Right();
                y++;
            }
            Console.WriteLine(newmenu.Display());
            Console.ReadKey();
        }
    }
}
