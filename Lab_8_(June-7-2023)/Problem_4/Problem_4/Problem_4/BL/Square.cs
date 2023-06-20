using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4
{
    public class Square : Shape
    {
        double sidelength;
        public Square(double sidelength)        
        {
            this.sidelength = sidelength;
        }   

        public override double Get_Area()
        {
            return this.sidelength * this.sidelength;
        }

        public override string Get_Name()
        {
            return "Square";
        }
    }
}
