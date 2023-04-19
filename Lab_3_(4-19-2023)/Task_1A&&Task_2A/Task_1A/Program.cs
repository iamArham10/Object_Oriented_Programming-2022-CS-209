using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1A
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student(); // creating Student 1 objects
            Student s2 = new Student(); // creating Student 2 objects

            // Printing Student number one attributes;
            Print_Student_Credentials(s1);
            Print_Student_Credentials(s2);
            Console.ReadKey();

        }
        static void Print_Student_Credentials(Student student)
        {
            Console.WriteLine(student.Name);
            Console.WriteLine(student.Roll_no);
            Console.WriteLine(student.Matric_Marks);
            Console.WriteLine(student.Fsc_Marks);
            Console.WriteLine(student.Aggregrate);
        }
    }
}
