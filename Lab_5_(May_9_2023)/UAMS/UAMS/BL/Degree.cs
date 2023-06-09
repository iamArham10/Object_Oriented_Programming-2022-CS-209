using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_1
{
    class Degree
    {
        // attributes
        public string Title;
        public int Duration;
        public int Available_Seats;
        public List<Subject> subjects = new List<Subject>();
        
        // constructor
        public Degree(string title, int duration, int seats)
        {
            Title = title;
            Duration = duration;
            Available_Seats = seats;
        }
        // methods
        // to add subject to a degree
        public bool AddSubject(Subject subject)
        {
            int credithours = Calculate_Total_CH();
            if (credithours + subject.credit_hours <= 20) 
            { 
                subjects.Add(subject);
                return true;
            }
            return true;
        }

        public bool Does_Contains_Subject(Subject subject)
        {
            foreach(Subject addedsubject in subjects)
            {
                if (subject.subject_code == addedsubject.subject_code)
                {
                    return true;
                }
            }
            return false;
        }

        public int Calculate_Total_CH()
        {
            int Total_CH = 0;
            foreach(Subject subject in subjects)
            {
                Total_CH += subject.credit_hours;
            }
            return Total_CH;
        }
    }
    
}
