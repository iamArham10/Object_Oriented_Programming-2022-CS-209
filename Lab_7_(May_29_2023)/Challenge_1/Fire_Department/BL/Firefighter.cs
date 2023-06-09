using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fire_Department
{
    class Firefighter
    {
        /// <summary>
        /// Firefighter class implements Firefighter having name and methods driving truck and putting fire
        /// </summary>
        // attributes
        public string name;

        // constructor
        public Firefighter(string name)
        {
            this.name = name;
        }

        // methods
        public void Drive_Truck() // prints name of firefighter telling he's driving truck
        {
            Console.WriteLine($"FireFighter {name} is driving truck");
        }
        public void Put_Fire() // prints name of firefighter will telling he's putting fire
        {
            Console.WriteLine($"Firefighter {name} is putting fire");
        }
    }

}
