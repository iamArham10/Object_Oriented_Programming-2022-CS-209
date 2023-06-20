using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3
{
    internal class AnimalDL
    {
        static List<Animal> animals = new List<Animal>();

        // add function
        static public void Add_Animal(Animal animal)
        {
            animals.Add(animal);
        }

        static public List<Animal> Get_Animals_List()
        {
            return animals;
        }
    }
}
