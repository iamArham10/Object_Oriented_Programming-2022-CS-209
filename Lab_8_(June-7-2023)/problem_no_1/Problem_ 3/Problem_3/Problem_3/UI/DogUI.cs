using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3
{
    public class DogUI
    {
        static public Dog Create_Dog()
        {
            Console.WriteLine("Enter Dog Name : ");
            string name = Console.ReadLine();
            Dog newdog = new Dog(name);
            return newdog;
        }
    }
}
