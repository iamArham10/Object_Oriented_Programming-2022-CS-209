using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clock_Type
{
    class Program
    {
        static void Main(string[] args)
        {
            ClockType EmtpyClock = new ClockType(); // Declaring an empty clock object with name Emptyclock
            Console.WriteLine("Empty Time: ");
            EmtpyClock.Print_time();

            // Declaring an hour time clock
            ClockType HourClock = new ClockType(8);
            Console.WriteLine("Hour Time: ");
            HourClock.Print_time();

            // Declaring an Minute Time clock
            ClockType MinuteClock = new ClockType(8, 10);
            Console.WriteLine("Hour and Minute Time clock: ");
            MinuteClock.Print_time();

            // Declaring an Full Time clock
            ClockType FullTime = new ClockType(8, 10, 10);
            Console.WriteLine("Full time clock ");
            FullTime.Print_time();

            // Incrementing hour
            FullTime.Increment_hour();
            Console.WriteLine("Time After Incrementing Hour: ");
            FullTime.Print_time();

            // Incrementing Minute;
            FullTime.Increment_minute();
            Console.WriteLine("Time After Incrementing Minute: ");
            FullTime.Print_time();

            // Incrementing Second;
            FullTime.Increment_Second();
            Console.WriteLine("Time After Incrementing Second: ");
            FullTime.Print_time();

            // To check if entered time is equal to the current full time
            bool isequal = FullTime.Is_equal(9, 11, 11);
            Console.WriteLine("Is Entered time Equal");
            if  (isequal)
            {
                Console.Write("True");
            }
            else
            {
                Console.WriteLine("False");
            }

            ClockType checktime = new ClockType(9,11,11);
            isequal = checktime.Is_equal(FullTime);
            if (isequal)
            {
                Console.Write("True");
            }
            else
            {
                Console.WriteLine("False");
            }

            Console.ReadKey();

        }
    }
}
