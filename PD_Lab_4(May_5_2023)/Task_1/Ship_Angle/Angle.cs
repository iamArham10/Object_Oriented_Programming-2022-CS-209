using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ship_Angle
{
    class Angle
    {
        // attributes
        public int Degree;
        public float Minutes;
        public char Direction;

        // constructor
        public Angle(int degree, float minutes, char direction)
        {
            Degree = degree;
            Minutes = minutes;
            Direction = direction;
        }

        public void Change_Angle(int degree, float minutes, char direction)
        {
            Degree = degree;
            Minutes = minutes;
            Direction = direction;
        }

        public string return_Location()
        {
            string location = $"{Degree} {Minutes}' {Direction}";
            return location;
        }
    }
}
