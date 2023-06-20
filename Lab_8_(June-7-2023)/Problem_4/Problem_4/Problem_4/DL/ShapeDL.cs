using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4
{
    public class ShapeDL
    {
        private static List<Shape> shapes = new List<Shape>();

        // add shape
        public static void Add_Shape(Shape s)
        {
            shapes.Add(s);
        }

        public static List<Shape> Get_Shapes()
        {
            return shapes;
        }
    }
}
