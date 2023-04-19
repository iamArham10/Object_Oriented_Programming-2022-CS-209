
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_01
{
    class Program
    {
        static void Main(string[] args)
        {
            student s1 = new student();
            Console.WriteLine(s1.name);
            Console.WriteLine(s1.matric_marks);
            Console.WriteLine(s1.fsc_marks);
            Console.WriteLine(s1.ecat_marks);
            Console.WriteLine(s1.aggregrate);
            Console.Read();
        }
    }
}
