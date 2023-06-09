using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point_Line
{
    class MyPoint
    {
        // attributes
        public int x;
        public int y;

        // constructor
        public MyPoint() {} // default constructor sets x and y point to 0
        public MyPoint(int point_x, int point_y) // sets x to pointx and y to point y
        {
            x = point_x;
            y = point_y;
        }

        // methods

        // returns coordinates of point
        public int GetX()
        {
            return x;
        }
        public int GetY()
        {
            return y;
        }

        // set coordinates
        public void SetX(int x)
        {
            this.x = x;
        }
        public void SetY(int y)
        {
            this.y = y;
        }
        public void SetXY(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        // line methods
        public double Distance_With_Points(int point_x, int point_y) // returns the distance of coordinates with current point coordinates
        {
            double distance;
            double X_Cord_D = (point_x - this.x) * (point_x - this.x);
            double Y_Cord_D = (point_y - this.y) * (point_y - this.y);
            distance = X_Cord_D + Y_Cord_D;
            distance = Math.Sqrt(distance);
            return distance;
        }

        public double Distance_With_Object(MyPoint point)
        {
            double distance = Distance_With_Points(point.x, point.y); // coordinates of point given in parameter are used in this function parameter
            return distance;
        }

        public double Distance_From_Zero()
        {
            double distance = Distance_With_Points(0, 0); // returns the distance of current points from 0 , 0 points
            return distance;
        }
    }
}
