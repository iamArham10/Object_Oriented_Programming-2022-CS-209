using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4
{
    public class CircleUI
    {
        public static Circle Create_Circle()
        {
            Console.WriteLine("Circle");
            Console.Write("Enter Radius : ");
            double radius = double.Parse(Console.ReadLine());
            Circle circle = new Circle(radius);
            return circle;
        }
    }
}
