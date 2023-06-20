using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3
{
    public class CatUI
    {
        static public Cat Create_Cat()
        {
            Console.WriteLine("Enter Cat Name : ");
            string name = Console.ReadLine();
            Cat cat = new Cat(name);
            return cat;
        }

    }
}
