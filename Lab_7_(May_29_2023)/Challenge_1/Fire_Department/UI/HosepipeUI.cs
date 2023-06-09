using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fire_Department
{
    class HosepipeUI
    {
        // takes input from Hosepipe and returns Hosepipe object
        static public Hosepipe Create_Hosepipe()
        {
            string material, shape; float diameter, flowrate;
            Console.WriteLine("Enter Hosepipe Material Type 'Synthetic Rubber' or 'Soft Plastic' : ");
            material = Console.ReadLine();
            Console.WriteLine("Enter Shape Of Pipe 'Cylindrical' or 'Circular' : ");
            shape = Console.ReadLine();
            Console.WriteLine("Enter Diameter of Pipe : ");
            diameter = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter Flowrate of Pipe : ");
            flowrate = float.Parse(Console.ReadLine());
            Hosepipe newhosepipe = new Hosepipe(material, shape, diameter, flowrate);
            return newhosepipe;
        }
    }
}
