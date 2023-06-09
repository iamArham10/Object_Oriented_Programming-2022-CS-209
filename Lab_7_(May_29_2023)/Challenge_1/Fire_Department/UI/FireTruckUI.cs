using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fire_Department
{
    /// <summary>
    /// Ui Class of FireTruck takes Firetruck related Data from user
    /// Prints Data related to FireTruck to commandline
    /// </summary>
    class FireTruckUI
    {
        static public FireTruck Create_Fire_Truck()
        {
            FireTruck firetruck = null;
            Console.WriteLine("Enter Length of Ladder : ");
            float length = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter Color of Ladder : ");
            string color = Console.ReadLine();
            Ladder ladder = new Ladder(length, color);
            firetruck = new FireTruck(ladder);
            return firetruck;
        }


        
    }
}
