using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1
{
    public class Circle
    {
        // attributes
        private double radius;
        private string color;

        // contructor
        public Circle() 
        {
        }
        public Circle(double radius)
        {
            this.radius = radius;
        }
        public Circle(double radius, string color) 
        {
            this.color = color;
            this.radius = radius;
        }

        // get set function
        public double Get_Radius()
        {
            return this.radius;
        }

        public void Set_Radius(double radius)
        {
            this.radius = radius;
        }

        public string Get_Color()
        {
            return this.color;
        }

        public void Set_Color(string color)
        {
            this.color = color;
        }

        public double Get_Area()
        {
            return (double)3.14*(this.radius*this.radius);
        }

        public string To_String()
        {
            return $"Circle[Radius : {this.radius} Color {this.color}]";
        }
    }
}
