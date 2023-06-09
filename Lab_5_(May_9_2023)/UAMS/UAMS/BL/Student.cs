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
        public int Ecat_marks;
        public List<Degree> Prefrences = new List<Degree>();
        public List<Subject> Registered_Subjects = new List<Subject>();
        public Degree Registered_Degree = null;

        // constructor 
        public Student(string name, int age,  int fscmarks, int ecatmarks, List<Degree> degrees)
        {
            Name = name;
            Age = age;
            FSC_marks = fscmarks;
            Ecat_marks = ecatmarks;
            Prefrences = degrees;
        }
)
        // methods
        public float Calculate_Merit()
        {
            float merit;
            merit = ((float)(FSC_marks / 1100) * 60) + ((float)(Ecat_marks / 400) * 40);
            return merit;
        }   

        public void Register_Degree(Degree d)
        {
            if (d != null)
            {
                Registered_Degree = d;
            }
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

        public bool Register_Subject(Subject subject)
        {
            if (Is_degree_Registered() && Registered_Degree.Does_Contains_Subject(subject) && (subject.credit_hours + Total_Credit_Hours()) <= 9)
            {
                Registered_Subjects.Add(subject);
                return true;
            }
            return false;
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

        public bool Is_degree_Registered()
        {
            bool IsRegistered = false;
            if (Registered_Degree != null)
            {
                IsRegistered = true;
            }
            return IsRegistered;
        }
        
    }

    
}
