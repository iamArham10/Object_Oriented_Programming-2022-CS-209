using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAMS
{
    class SubjectUI
    {
        static public Subject Add_Subject() // takes subject attributes from the user and creates a new subject and returns it
        {
            Console.WriteLine("Enter Subject Code: ");
            string subjectcode = Console.ReadLine();
            Console.WriteLine("Enter Subject Name: ");
            string Subjecttype = Console.ReadLine();
            Console.WriteLine("Enter Subject Credit Hours: ");
            int credit_hours = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Subject Fees: "); // attributes of subject
            int subjectfee = int.Parse(Console.ReadLine());
            Subject newsubject = new Subject(subjectcode, Subjecttype, credit_hours, subjectfee);
            return newsubject;
        }

        static public void View_Subjects(Student student)
        {
            if (!student.Is_degree_Registered())
            {
                int subject_number = 1;
                foreach (Subject subject in student.Registered_Degree.subjects)
                {
                    Console.WriteLine("Subject No : " + subject_number);
                    Console.WriteLine("Subject Code: " + subject.subject_code);
                    Console.WriteLine("Subject Type: " + subject.subject_type + "\n");
                }
            }
        }

        static public void Register_Subject(Student student)
        {
            Console.WriteLine("Enter How many subjects you want to Enter: ");
            int count = int.Parse(Console.ReadLine());
            int subjectno;
            for (subjectno = 0; subjectno < count; subjectno++)
            {
                Console.WriteLine("Enter Subject Code: ");
                string code = Console.ReadLine();
                bool issubjectregistered = false;
                foreach (Subject subject in student.Registered_Degree.subjects)
                {
                    if (subject.subject_code == code && !(student.Registered_Subjects.Contains(subject)))
                    {
                        if (student.Register_Subject(subject))
                        {
                            issubjectregistered = true;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("A Student cannot have more than 9 CH");
                            issubjectregistered = true;
                            break;
                        }
                    }
                }
                if (!issubjectregistered)
                {
                    Console.WriteLine("Enter Valid Subject: ");
                    subjectno--;
                }
            }
        }
    }
}
