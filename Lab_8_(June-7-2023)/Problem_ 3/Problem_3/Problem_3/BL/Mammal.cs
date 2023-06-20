using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3
{
    public class Mammal : Animal
    {
        // constructor 
        public Mammal(string name) : base(name) { }

        // greet function
        // whats the reason 
        public override void greets()
        {
            Console.WriteLine("Mammal Greets");
        }
    }
}
