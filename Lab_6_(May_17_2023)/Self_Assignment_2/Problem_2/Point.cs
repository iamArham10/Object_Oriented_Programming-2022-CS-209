using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2
{
    class Point
    {
        // atttributes
        public int x;
        public int y;

        // constructors

        public Point() { }
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        // methods
        // get x and y

        public int Get_X()
        {
            return x;
        }

        public int Get_Y()
        {
            return y;
        }
        // set x and y

        public void Set_X(int x)
        {
            this.x = x;
        }

        public void Set_Y(int y)
        {
            this.y = y;
        }

        public void Set_XY(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        
    }
}
