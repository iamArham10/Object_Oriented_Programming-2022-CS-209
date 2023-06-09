using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_1
{
    class Student
    {
        // attributes
        public string Name;
        public int Age;
        public int FSC_marks;
        public int Matric_marks;
        public int Ecat_marks;
        public List<string> Prefrences = new List<string>();
        public List<Subject> Registered_Subjects = new List<Subject>();
        public Degree Registered_Degree = null;

        // constructor 
        public Student(string name, int age, int matricmarks, int fscmarks, int ecatmarks)
        {
            Name = name;
            Age = age;
            FSC_marks = fscmarks;
            Matric_marks = matricmarks;
            Ecat_marks = ecatmarks;
        }

        public float Calculate_Merit()
        {
            float merit = 0F;
            merit = ((float)(FSC_marks / 1100) * 60) + ((float)(Ecat_marks / 400) * 40);
            return merit;
        }

        public void Add_Subject(Subject subject)
        {
            Registered_Subjects.Add(subject);
        }

        public int Calculate_Fee()
        {
            int fee = 0;
            foreach (Subject subject in Registered_Subjects)
            {
                fee += subject.subject_fee;
            }
            return fee;
        }

        public int Total_Credit_Hours()
        {
            int TCH = 0;
            foreach(Subject subject in Registered_Subjects)
            {
                TCH += subject.credit_hours;
            }
            return TCH;
        }
        
    }

    
}
