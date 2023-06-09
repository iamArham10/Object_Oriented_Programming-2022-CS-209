using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4
{
    public class Rectangle : Shape
    {
        protected double length;
        protected double width;

        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
        }

        public override string Get_Name()
        {
            return "Rectangle";
        }

        public override double Get_Area()
        {
            return length * width;
        }
    }
}
