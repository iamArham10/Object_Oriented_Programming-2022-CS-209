using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class PersonDL
    {
        // list contains all of the Person objects and their Inherited objects
        static private List<Person> Persons = new List<Person>(); 

        // to add person to list

        static public void Add_Person(Person person)
        {
            if (!(Persons.Contains(person)))
            {
                Persons.Add(person);
            }
        }

        static public List<Person> Get_Person_List()
        {
            return Persons;
        }


        

    }
}
