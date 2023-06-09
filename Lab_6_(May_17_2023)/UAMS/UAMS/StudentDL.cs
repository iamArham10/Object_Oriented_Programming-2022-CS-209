using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace UAMS
{
    class StudentDL
    {
        static public List<Student> students = new List<Student>();

        static public void Add_Student(Student s) // add student to a list
        {
            if (s != null)
            {
                students.Add(s);
            }
        }

        static public Student Is_Student_Present(string name)
        {
            foreach (Student s in students)
            {
                if (s.Name == name)
                {
                    return s;
                }
            }
            return null;
        }

        static public void Sort_students() // this program sorts the student in the list with student with highest merit on the zero index and so on
        {
            students = students.OrderByDescending(o => o.Calculate_Merit()).ToList();
        }

        static public void Assign_Degrees()
        {
            foreach (Student s in students)
            {
                foreach (Degree degree in s.Prefrences)
                {
                    if (degree.Available_Seats != 0 && (s.Is_degree_Registered() == false))
                    {
                        s.Register_Degree(degree);
                        degree.Available_Seats--;
                    }
                }
            }
        }

        public static void Store_Into_File(string path, Student s)
        {
            StreamWriter filevar = new StreamWriter(path, true);
            string DegreeName = "";
            for (int Degreeno = 0; Degreeno < s.Prefrences.Count - 1; Degreeno++)
            {
                DegreeName += s.Prefrences[Degreeno].Title + ";";
            }
            DegreeName += s.Prefrences[s.Prefrences.Count - 1].Title;
            filevar.WriteLine(s.Name + "," + s.Age + "," + s.FSC_marks + "," + s.Ecat_marks + "," + DegreeName);
            filevar.Flush();
            filevar.Close();
        }

        public static bool Read_Data_From_File(string path)
        {
            StreamReader filevar = new StreamReader(path);
            string record;
            if (File.Exists(path))
            {
                while ((record = filevar.ReadLine()) != null)
                {
                    string[] SplittedRecord = record.Split(',');
                    string name = SplittedRecord[0];
                    int age = int.Parse(SplittedRecord[1]);
                    int fscmarks = int.Parse(SplittedRecord[2]);
                    int ecatmarks = int.Parse(SplittedRecord[3]);
                    string[] splittedpreferences = SplittedRecord[4].Split(';');
                    List<Degree> preferences = new List<Degree>();
                    for (int x = 0; x < splittedpreferences.Length; x++)
                    {
                        Degree d = DegreeDL.Is_Degree_Exists(splittedpreferences[x]);
                        if (d != null)
                        {
                            if (!(preferences.Contains(d)))
                            {
                                preferences.Add(d);
                            }
                        }
                    }
                    Student s = new Student(name, age, fscmarks, ecatmarks, preferences);
                    students.Add(s);
                }
                filevar.Close();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
