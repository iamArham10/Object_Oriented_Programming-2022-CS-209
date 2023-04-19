using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>();
            // Ask user ten times to add names
            for (int name = 0; name < 10; name++)
            {
                Console.WriteLine("Enter The Name no {0} : ", name + 1);
                string Name = Console.ReadLine();
                names.Add(Name);
            }

            // foreach loop prints each string present in names list
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            Console.ReadKey();
        }
    }
}
