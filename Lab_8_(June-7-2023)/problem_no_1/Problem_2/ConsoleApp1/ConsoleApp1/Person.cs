using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Person
    {
        // attributes
        protected string name;
        protected string address;

        // constructors
        public Person(string name, string address)
        {
            this.name = name;
            this.address = address; 
        }

        // get set functions
        public string Get_Name()
        {
            return this.name;
        }

        public string Get_Adress()
        {
            return this.address;
        }

        public void Set_Address(string address)
        {
            this.address = address;
        }

        // returns state of all attributes as string

        public virtual string To_String()
        {
            return $"Name : {Get_Name()} Adress : {Get_Adress()}";
        }
    }
}
