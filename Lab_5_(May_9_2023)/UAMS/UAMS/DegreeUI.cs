using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_1
{
    class DegreeUI
    {
        public static Degree Take_Input_For_Degree()
        {
            Console.WriteLine("Enter Degree Name: ");
            string dname = Console.ReadLine();
            Console.WriteLine("Enter Degree Duration: ");
            int duration = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Available Seats for Degree: ");
            int seats = int.Parse(Console.ReadLine());
            Degree newdegree = new Degree(dname, duration, seats);
            Console.WriteLine("How many subjects You Want to Register: ");
            int subjectcount = int.Parse(Console.ReadLine());
            for (int subject_no = 0; subject_no < subjectcount; subject_no++)
            {
                Subject newsubject = SubjectUI.Add_Subject();
                if (newdegree.AddSubject(newsubject))
                {
                    if (!(SubjectDL.subjects.Contains(newsubject)))
                    {
                        SubjectDL.
                    }
                }
            }
        }
    }
}
}
