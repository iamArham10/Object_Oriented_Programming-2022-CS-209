﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAMS
{
    class Subject
    {
        // attributes
        public string subject_code;
        public int credit_hours;
        public string subject_type;
        public int subject_fee;

        // Constructor
        public Subject(string subjectcode, string subjecttype, int credithours, int subjectfees)
        {
            subject_code = subjectcode;
            subject_type = subjecttype;
            credit_hours = credithours;
            subject_fee = subjectfees;
        }
    }
}
