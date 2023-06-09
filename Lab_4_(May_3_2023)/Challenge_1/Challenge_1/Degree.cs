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

        // to add subject to a degree
        public void AddSubject(Subject subject)
        {
            subjects.Add(subject);
        }
    }
    
}
