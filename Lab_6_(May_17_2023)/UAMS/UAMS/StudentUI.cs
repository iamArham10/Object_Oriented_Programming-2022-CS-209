using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAMS
{
    class StudentUI
    {
        public static void PrintStudents(List<Student> students)
        {
            foreach (Student student in students)
            {
                if (student.Is_degree_Registered())
                {
                    Console.WriteLine("{0} Got Admission In {2}", student.Name, student.Registered_Degree.Title);
                }
                else
                {
                    Console.WriteLine("{0} Did not Got Admission", student.Name);
                }
            }
        }

        public static Student Take_Input_For_Student()
        {
            Console.WriteLine("Enter Student Name: ");
            string sname = Console.ReadLine();
            Console.WriteLine("Enter Student Age: ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Student Fsc Marks: ");
            int fscmarks = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Ecat Marks:");
            int ecatmarks = int.Parse(Console.ReadLine());
            Console.WriteLine("Avalable Degree Programs: ");
            DegreeUI.ViewDegreeProgram(DegreeDL.degrees);
            Console.WriteLine("Enter How Many Preferences You Want to Enter: ");
            List<Degree> preferences = new List<Degree>();
            int no_Preferences = int.Parse(Console.ReadLine());
            for (int currentpreference = 0; currentpreference < no_Preferences; currentpreference++)
            {
                string preference = Console.ReadLine();
                bool isPrefAdded = false;
                Degree degree = DegreeDL.Is_Degree_Exists(preference);
                if (degree != null)
                {
                    if (!(DegreeDL.Is_Degree_Exists(degree)))
                    {
                        preferences.Add(degree);
                        isPrefAdded = true;
                    }
                }
                if (isPrefAdded == false)
                {
                    currentpreference--;
                }
            }
            Student newstudent = new Student(sname, age, fscmarks, ecatmarks, preferences);
            return newstudent;
        }

        public static void Student_Fees(List<Student> students)
        {
            foreach(Student student in students)
            {
                if (student.Is_degree_Registered())
                {
                    Console.WriteLine("Student {0} has {1} fees", student.Name, student.Calculate_Fee());
                }
            }
        }

        public static void Print_Students_Of_Degree(string Dname, List<Student> students)
        {
            foreach(Student student in students)
            {
                if (student.Registered_Degree.Title == Dname)
                {
                    Console.WriteLine("Student Name : " + student.Name);
                }
            }
        }

    }
}
