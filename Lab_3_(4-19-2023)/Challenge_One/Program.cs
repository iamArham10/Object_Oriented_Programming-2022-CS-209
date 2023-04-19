using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_One
{
    class Program
    {
        static void Main(string[] args)
        {
            ClockType Full_Clock = new ClockType(8, 11, 11);
            Full_Clock = Full_Clock.Remaining_Time();
            Full_Clock.Print_time();
            Console.ReadKey();
        }
    }
}
