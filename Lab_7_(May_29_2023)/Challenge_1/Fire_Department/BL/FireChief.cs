using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fire_Department
{
 
    class FireChief : Firefighter
    {
        /// <summary>
        /// inherited class of FireFighter 
        /// addition method of calling another firefighter
        /// </summary>

        // constructor
        public FireChief(string name) : base(name)
        {

        }
        // method
        public void Delegate_FireFighter(string name)
        {
            Console.WriteLine($"{name} Put Fire ");
        }
    }
}
