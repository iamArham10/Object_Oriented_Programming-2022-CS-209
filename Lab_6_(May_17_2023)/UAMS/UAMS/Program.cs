using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAMS
{
    class Program
    {
        static void Main(string[] args)
        {
            string subject_path = @"C:\Users\Win 10\Documents\GitHub\Object_Oriented_Programming-2022-CS-209\Lab_6_(May_17_2023)\UAMS\UAMS\Files\Subjects.txt";
            string degree_path = @"C:\Users\Win 10\Documents\GitHub\Object_Oriented_Programming-2022-CS-209\Lab_6_(May_17_2023)\UAMS\UAMS\Files\Degrees.txt";
            string student_path = @"C:\Users\Win 10\Documents\GitHub\Object_Oriented_Programming-2022-CS-209\Lab_6_(May_17_2023)\UAMS\UAMS\Files\Students.txt";
            if (SubjectDL.Read_From_File(subject_path))
            {
                Console.WriteLine("Subjects Data Loaded Succesfully");
            }
            else
            {
                Console.WriteLine("Subjects Data Was Not Loaded");
            }
            if (DegreeDL.Read_From_File(degree_path))
            {
                Console.WriteLine("Degrees Data Loaded Succesfully");
            }
            else
            {
                Console.WriteLine("Degrees Data Was Not Loaded Succesfully");
            }
            if (StudentDL.Read_Data_From_File(student_path))
            {
                Console.WriteLine("Students Data Loaded Succesfully");
            }
            else
            {
                Console.WriteLine("Students Data Was Not Loaded Succesfully");
            }

            char option;
            do
            {
                MenuUI.Clear_Screen();
                option = MenuUI.Menu();
                if (option == '1')
                {
                    if (DegreeDL.Is_Degrees_Available())
                    {
                        Student newstudent = StudentUI.Take_Input_For_Student();
                        StudentDL.Add_Student(newstudent);
                        StudentDL.Store_Into_File(student_path, newstudent);
                    }
                    else
                    {
                        Console.WriteLine("No Degree Available: ");
                    }
                }
                else if (option == '2')
                {
                    Degree newdegree = DegreeUI.Take_Input_For_Degree();
                    if (!DegreeDL.Is_Degree_Exists(newdegree))
                    {
                        DegreeDL.Add_Degree_Into_List(newdegree);
                        DegreeDL.Store_Data_In_File(degree_path, newdegree);
                    }
                    else
                    {
                        Console.WriteLine("Degree Already Added");
                    }
                }
                else if (option == '3')
                {
                    StudentDL.Sort_students();
                    StudentDL.Assign_Degrees();
                    StudentUI.PrintStudents(StudentDL.students);
                }
                else if (option == '4')
                {
                    StudentUI.PrintStudents(StudentDL.students);
                }
                else if (option == '5')
                {
                    Console.WriteLine("Enter Degree Name: ");
                    String DegreeName = Console.ReadLine();
                    StudentUI.Print_Students_Of_Degree(DegreeName, StudentDL.students);
                }
                else if (option == '6')
                {
                    Console.WriteLine("Enter Student Name: ");
                    string Sname = Console.ReadLine();
                    Student student = StudentDL.Is_Student_Present(Sname);
                    if (student != null)
                    {
                        SubjectUI.View_Subjects(student);
                        SubjectUI.Register_Subject(student);
                    }
                }
                else if (option == '7')
                {
                    StudentUI.Student_Fees(StudentDL.students);
                }
                MenuUI.Clear_Screen();
                
            } while (option != '8');
        }
    }
}
