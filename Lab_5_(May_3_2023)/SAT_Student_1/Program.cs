using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAT_Student_1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            input_users(students);
            print_students(students);
            Console.ReadKey();
        }
        static void input_users(List<Student> students)
        {
            for (int i = 0; i < 4; i++)
            {
                Student newstudent = Take_Input();
                float merit = newstudent.Calculate_Merit();
                newstudent.is_Taking_Scholarship = newstudent.IsEligibleForScholarship(merit);
                students.Add(newstudent);
            }
        }

        static void print_students(List<Student> students)
        {
            for (int i = 0; i < students.Count; i++)
            {
                print_student(students[i]);
            }
        }
        static Student Take_Input()
        {
            Console.WriteLine("Enter Student name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Student roll no: ");
            string rollno = Console.ReadLine();
            Console.WriteLine("Enter Student cgpa: ");
            float cgpa = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter Student matric marks: ");
            int matricmarks = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Student ecat marks: ");
            int ecatmarks = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Student fsc marks: ");
            int fscmarks = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Hometown : ");
            string hometown = Console.ReadLine();
            Console.WriteLine("Are you hostilite: ");
            string hostilite = Console.ReadLine();
            bool ishostilite;
            if (hostilite == "true")
            {
                 ishostilite = true;
            }
            else
            {
                 ishostilite = false;
            }
            Student newstudent = new Student(name, rollno, cgpa, matricmarks, fscmarks, ecatmarks, hometown, ishostilite);
            return newstudent;

        }
        static void print_student(Student student)
        {
            Console.WriteLine("Name : {0}",student.student_name);
            Console.WriteLine("rollno : {0}", student.student_rollno);
            Console.WriteLine("cgpa : {0}", student.student_cGPA);
            Console.WriteLine("matric marks : {0}", student.matric_marks);
            Console.WriteLine("fsc marks : {0}", student.fsc_marks);
            Console.WriteLine("Ecat marks : {0}", student.ecat_marks);
            Console.WriteLine("hometown : {0}", student.hometown);
            Console.WriteLine("hostilite : {0}", student.is_Hostilite);
            Console.WriteLine("Scholarship : {0}", student.is_Taking_Scholarship);
        }
    }
}
