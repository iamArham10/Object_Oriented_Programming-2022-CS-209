using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point_Line
{
    class MyLine
    {
        // attritubes
        public MyPoint begin = new MyPoint();
        public MyPoint end = new MyPoint();

        // constructor 
        public MyLine(MyPoint begin, MyPoint end)
        {
            this.begin = begin;
            this.end = end;
        }

        // methods

        //  begin and end point return function
        public MyPoint Get_Begin()
        {
            return begin;
        }

        public MyPoint Get_End()
        {
            return end;
        }

        // begin and end point set function

        public void Set_Begin(MyPoint begin)
        {
            this.begin = begin;
        }

        public void Set_End(MyPoint end)
        {
            this.end = end;
        }

        // line methods
        public double Get_Length()
        {
            double length;
            length = end.Distance_With_Object(begin);
            return length;
        }

        public double Get_Gradient()
        {
            double gradient;
            gradient = (double)(end.y - begin.y)/(end.x - begin.x);
            return gradient;
        }
    }
}
