using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAT_Student_1
{
    class Student
    {
        public string student_name;
        public string student_rollno;
        public float student_cGPA;
        public int matric_marks;
        public int fsc_marks;
        public int ecat_marks;
        public string hometown;
        public bool is_Hostilite;
        public bool is_Taking_Scholarship;

        public Student(string name, string rollno, float cgpa, int matric_marks, int fsc_marks, int ecat_marks, string hometown, bool ishostilite)
        {
            student_name = name;
            student_rollno = rollno;
            student_cGPA = cgpa;
            this.matric_marks = matric_marks;
            this.fsc_marks = fsc_marks;
            this.ecat_marks = ecat_marks;
            this.hometown = hometown;
            is_Hostilite = ishostilite;

        }

        public float Calculate_Merit()
        {
            float merit;
            merit = ((fsc_marks/1100) * 100) + ((ecat_marks / 400) * 100);
            return merit;
        }
        public bool IsEligibleForScholarship(float merit)
        {
            bool isEligible = false;
            if (merit > 80 && is_Hostilite)
            {
                isEligible = true;
            }
            return isEligible;

        }
    }
}
