using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3
{
    public class Dog : Mammal
    {
        public Dog(string name) : base(name) { }
        public override void greets()
        {
            Console.WriteLine(("Dog greets"));
        }
        public void greets(Dog d)
        {
            Console.WriteLine($"Wooof {d.To_String()}");
        }
    }
}
