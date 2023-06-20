using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4
{
    public class ShapeUI
    {
        public static void Print_Shape(List<Shape> shapes)
        {
            foreach (Shape shape in shapes) 
            {
                Console.WriteLine($"Name {shape.Get_Name()} : Area : {shape.Get_Area()}");
            }
        }
    }
}
