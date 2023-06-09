using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Challenge_1.DL
{
    class SubjectDL
    {
        public static List<Subject> subjects = new List<Subject>();

        public static void Add_Subject(Subject s)
        {
            if (s != null)
            {
                subjects.Add(s);
            }
        }
        public static bool Read_From_File(string path) // to read from file
        {
            StreamReader FileVar = new StreamReader(path);
            string record;
            if (File.Exists(path))
            {
                while ((record = FileVar.ReadLine()) != null)
                {
                    string[] separatedrecord = record.Split(','); // splits the record by comma into the list
                    string code = separatedrecord[0];
                    string type = separatedrecord[1];
                    int CreditHour = int.Parse(separatedrecord[2]);
                    int subjectfee = int.Parse(separatedrecord[3]);
                    Subject newsubject = new Subject(code, type, CreditHour, subjectfee);
                    Add_Subject(newsubject);
                }
                FileVar.Close();
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void Store_In_File(string path, Subject s)
        {
            StreamWriter FileVar = new StreamWriter(path, true);
            FileVar.WriteLine(s.subject_code + "," + s.subject_type + "," + s.credit_hours + "," + s.subject_fee);
            FileVar.Flush();
            FileVar.Close();
        }

        public static Subject Is_Subject_Exists(string subjecttype)
        {
            foreach(Subject subject in subjects)
            {
                if (subject.subject_type == subjecttype)
                {
                    return subject;
                }
            }
            return null;
        }
    }
}
