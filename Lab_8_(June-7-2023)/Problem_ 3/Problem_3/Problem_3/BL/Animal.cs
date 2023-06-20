using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3
{
    public class Animal
    {
        // attributes
        private string name;

        // constructor
        public Animal(string name)
        {
            this.name = name;
        }

        // greet function
        public virtual void greets()
        {
            Console.WriteLine("Animal Greets");    
        }
        // returns the state of attributes
        public string To_String()
        {
            return $"Name : {this.name}";
        }

    }
}
