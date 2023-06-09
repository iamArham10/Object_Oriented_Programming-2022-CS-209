using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bicycle
{
    class BicycleUI
    /// <summary>
    /// BicycleUI Class contains functions that'll input from user and prints bicycle related data to user
    /// </summary>
    {
        public static Bicycle Create_Bicycle()
        {
            Console.WriteLine("Enter Cadence of Bicycle : ");
            int cadence = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Gear : ");
            int gear = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter SPeed : ");
            int speed = int.Parse(Console.ReadLine());
            Bicycle bicycle = new Bicycle(cadence, gear, speed);
            return bicycle;
        }

        public static MountainBike Create_MountainBike()
        {
            Console.WriteLine("Enter Cadence of Bicycle : ");
            int cadence = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Gear : ");
            int gear = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter SPeed : ");
            int speed = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Seat Height : ");
            int seatheight = int.Parse(Console.ReadLine());
            MountainBike mountainbike = new MountainBike(seatheight, cadence, speed, gear);
            return mountainbike;
        }

        public static void Print_Bicycle_State(Bicycle bicycle)
        {
            Console.WriteLine($"Cadence of Bicycle : {bicycle.cadence}");
            Console.WriteLine($"Speed of Bicycle : {bicycle.speed}");
            Console.WriteLine($"Gear Of Bycycle : {bicycle.gear}");
            
        }

        
    }
}
