using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2
{
    class Boundary
    {
        // attributes
        public Point TopLeft;
        public Point TopRight;
        public Point BottomLeft;
        public Point BottomRight;

        // Default Constructor
        public Boundary()
        {
            TopLeft = new Point(0, 0);
            TopRight = new Point(90 ,0);
            BottomLeft = new Point(0 , 90);
            BottomRight = new Point(90, 90);
        }
        // constructors
        public Boundary(Point TL, Point TR, Point BL, Point BR)
        {
            TopLeft = TL;
            TopRight = TR;
            BottomLeft = BL;
            BottomRight = BR;
        }

    }
}
