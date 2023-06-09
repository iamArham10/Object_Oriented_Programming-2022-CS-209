using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class PersonUI
    {
        // a function that takes person input and return person object
        static public Person Input_Person()
        {
            Console.WriteLine("Enter Person Information : ");
            string name;
            string address;
            Console.Write("Enter Name : ");
            name = Console.ReadLine();
            Console.Write("Enter Adress : ");
            address = Console.ReadLine();
            Person person = new Person(name, address);
            return person;
        }

        // Print Persons
        static public void Print_Person_Info(List<Person> persons)
        {
            foreach (Person person in persons) 
            {
                Console.WriteLine(person.To_String());
            }
        }
    }
}
