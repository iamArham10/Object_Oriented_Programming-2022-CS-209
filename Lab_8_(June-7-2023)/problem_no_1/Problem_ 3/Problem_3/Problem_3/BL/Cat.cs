using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3
{
    public class Cat : Mammal
    {
        // constructor
        public Cat(string name) : base(name) { }   
        
        // functions
        public override void greets()
        {
            Console.WriteLine("Cat greets");
        }
    }
}
