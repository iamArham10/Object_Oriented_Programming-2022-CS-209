using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Challenge_1.DL
{
    class DegreeDL
    {
        // attributes
        public static List<Degree> degrees = new List<Degree>();

        // methods
        public static void Add_Degree_Into_List(Degree d)
        {
            if (d != null)
            {
                degrees.Add(d);
            }
        }

        public static Degree Is_Degree_Exists(string D_Name) // returns degree if degree exists
        {
            foreach(Degree degree in degrees)
            {
                if (degree.Title == D_Name)
                {
                    return degree;
                }
            }
            return null;
        }

        public static void Store_Data_In_File(string path, Degree degree) // stores degree data on file
        {
            StreamWriter FileVar = new StreamWriter(path, true);
            if (File.Exists(path))
            {
                string subject_names = "";
                for(int subject_no = 0; subject_no < degree.subjects.Count - 1; subject_no++)
                {
                    subject_names += degree.subjects[subject_no].subject_code + ";";
                }
                subject_names += degree.subjects[degree.subjects.Count - 1].subject_code;
                FileVar.WriteLine(degree.Title + "," + degree.Duration + "," + degree.Available_Seats + "," + subject_names);
                FileVar.Flush();
                FileVar.Close();
            }

        }

        public static bool Read_From_File(string path)
        {
            StreamReader FileVar = new StreamReader(path);
            if (File.Exists(path))
            {
                string record = "";
                while ((record = FileVar.ReadLine()) != null)
                {
                    string[] Separated_Record = record.Split(','); // splits the string by , in an array
                    string degree_title = Separated_Record[0];
                    int duration = int.Parse(Separated_Record[1]);
                    int seats = int.Parse(Separated_Record[2]);
                    string[] subject_names = Separated_Record[3].Split(';');
                    Degree degree = new Degree(degree_title, duration, seats);
                    foreach(string name in subject_names)
                    {
                        Subject subject = SubjectDL.Is_Subject_Exists(name);
                        if (subject != null)
                        {
                            degree.AddSubject(subject);
                        }
                    }
                    Add_Degree_Into_List(degree);
                }
                FileVar.Close();
                return true;
            }
            return false;
        }
    }
}
