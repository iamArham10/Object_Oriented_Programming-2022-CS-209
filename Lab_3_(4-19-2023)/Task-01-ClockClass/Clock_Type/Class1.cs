using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clock_Type
{
    class ClockType
    {
        // Declaring Object attributes
        public int hour;
        public int minute;
        public int second;

        // Declaring an empty constructor
        public ClockType()
        {
            hour = 0;
            minute = 0;
            second = 0;
        }

        // Takes only hour parameter and changes only hour
        public ClockType(int h)
        {
            hour = h;
        }
        
        // Takes only Hour and Minutes Parameter and changes them
        public ClockType(int h, int m)
        {
            hour = h;
            minute = m;
        }

        // Takes hour minute and second all attributes of object and changes them
        public ClockType(int h, int m , int s)
        {
            hour = h;
            minute = m;
            second = s;
        }

        // Increments Seconds
        public void Increment_Second()
        {
            second++;
        }

        // Increments Minutes
        public void Increment_minute()
        {
            minute++;
        }

        // Incrememts Hour
        public void Increment_hour()
        {
            hour++;
        }

        // To Print all attributes of the Object
        public void Print_time()
        {
            Console.Write("{0} : {1} : {2}", hour, minute, second);
        }

        // To check if given time is equal to the object time
        public bool Is_equal(int h, int m , int s)
        {
            bool isEqual = false;
            if (h == hour && m == minute && s == second)
            {
                isEqual = true;
            }
            return isEqual;
        }

        // To check if passed object time is equal to this object time
        public bool Is_equal(ClockType temp)
        {
            bool isEqual = false;
            if (temp.hour == hour && temp.minute == minute && temp.second == second)
            {
                isEqual = true;
            }
            return isEqual;
        }
        
    }
}
