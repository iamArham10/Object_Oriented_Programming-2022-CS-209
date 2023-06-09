using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4
{
    public class Circle : Shape
    {
        protected double radius;

        public Circle(double radius) 
        {
            this.radius = radius;
        } 

        public override double Get_Area()
        {
            return 3.14 * (this.radius * this.radius);
        }

        public override String Get_Name()
        {
            return "Circle";
        }
    }
}
