using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4
{
    public class SquareUI
    {
        public static Square Create_Square()
        {
            Console.WriteLine("Square : ");
            double side;
            Console.Write("Enter Square Side Length : ");
            side = double.Parse(Console.ReadLine());
            Square square = new Square(side);
            return square;
        }
    }
}
