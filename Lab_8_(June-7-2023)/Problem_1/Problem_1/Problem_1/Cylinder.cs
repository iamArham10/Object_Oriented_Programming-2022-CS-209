using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1
{
    internal class Cylinder : Circle
    {
        // attributes
        private double height;

        // constructors 
        public Cylinder()
        {

        }
        public Cylinder(double radius) : base(radius) { }
        public Cylinder(double radius, double height) : base(radius) {
            this.height = height;
        }
        public Cylinder(double radius, double height, string color) : base(radius,color)
        {
            this.height = height;
        }

        // get set functions

        public double Get_Height()
        {
            return this.height;
        }

        public void Set_Height(double height)
        {
            this.height = height;
        }

        // area function

        public double Get_Cylinder_Area()
        {
            return Get_Radius() * Get_Height();
        }


    }
}
