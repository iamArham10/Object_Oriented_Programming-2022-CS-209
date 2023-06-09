using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3
{
    public class AnimalUI
    {
        static public Animal Create_Animal()
        {
            string animal_name;
            Console.WriteLine("Enter Animal Name : ");
            animal_name = Console.ReadLine();
            Animal animal = new Animal(animal_name);
            return animal;
        }

        static public void Print_Animal(List<Animal> animals)
        {
            foreach(Animal animal in animals)
            {
                animal.greets();
                animal.To_String();
            }
        }
    }
}
