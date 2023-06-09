using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4
{
    public class RectangleUI
    {
        public static Rectangle Create_Rectangle()
        {
            double length;
            double width;
            Console.WriteLine("Rectangle");
            Console.Write("Enter Length : ");
            length = double.Parse(Console.ReadLine());
            Console.Write("Enter Width");
            width = double.Parse(Console.ReadLine());
            Rectangle rectangle = new Rectangle(length, width);
            return rectangle;
        }
    }
}
