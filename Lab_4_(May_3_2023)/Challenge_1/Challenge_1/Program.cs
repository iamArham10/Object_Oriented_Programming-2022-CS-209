using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Degree> degrees = new List<Degree>(); // list of all of the degrees currently available
            List<Student> students = new List<Student>(); // list of all of the students that are added through option one
            char option;
            do
            {
                Console.Clear();
                option = MainMenu();
                if (option == '1')
                {
                    Console.Clear();
                    if (degrees.Count != 0)
                    {
                        Student newstudent = Add_Student_Option(degrees);
                        students.Add(newstudent);
                        Console.WriteLine("Press Any Key to Continue...");
                        Console.ReadKey();
                    }
                    

                }
                else if (option == '2')
                {
                    Console.Clear();
                    Degree newdegree = Add_Degree();
                    if (newdegree != null)
                    {
                        degrees.Add(newdegree);
                    }
                }
                else if (option == '3')
                {
                    Console.Clear();
                    Sort_students(students);
                    Console.WriteLine(students[0]);
                    Assign_program_to_students(students, degrees);
                    Print_Merit_List(students);
                    Console.ReadKey();
                }
                else if (option == '4')
                {
                    Console.Clear();
                    Print_Registered_Students(students);
                    Console.ReadKey(); 
                }
                else if (option == '5')
                {
                    Console.Clear();
                    View_Students_Of_Degree(students);
                }
                else if (option == '6')
                {
                    Console.Clear();
                    Register_Subjects(students);
                }
                else if (option == '7')
                {
                    Console.Clear();
                    Generate_Fee(students);
                    Console.ReadKey();
                }

            }while (option != 8);
        }

        static char MainMenu() // main Menu of the program 
        {
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. Add Degeree Program");
            Console.WriteLine("3. Generate Merit List");
            Console.WriteLine("4. View Registered Students");
            Console.WriteLine("5. View Students Of Specific Programs");
            Console.WriteLine("6. Register Students");
            Console.WriteLine("7. Calculate Fee for all registered Students");
            Console.WriteLine("0. Exit");
            char option = char.Parse(Console.ReadLine());
            return option;
        }

        static Student Add_Student() // inputs student information and returns that student
        {
            Console.WriteLine("Enter Name of Student: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Age: ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Matric Marks: ");
            int matricmarks = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter FSC Marks: ");
            int fscmarks = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Ecat Marks");
            int ecatmarks = int.Parse(Console.ReadLine());
            Student newstudent = new Student(name, age, matricmarks, fscmarks, ecatmarks);
            return newstudent;
        }

        static Student Add_Student_Option(List<Degree> degrees) // to Add a new student and store it in a list
        {
            Student student = Add_Student();
            Show_Available_Degree_Programs(degrees);
            Console.WriteLine("Enter How Many Preferences To Enter: ");
            int noofpreferences = int.Parse(Console.ReadLine());
            Get_Preferences(noofpreferences, student.Prefrences);
            return student;
        }

        static void Show_Available_Degree_Programs(List<Degree> degrees) // shows available degree programs
        {
            Console.WriteLine("Available Degree Programs");
            foreach(Degree degree in degrees)
            {
                Console.WriteLine(degree.Title);
            }
        }

        static void Get_Preferences(int n , List<string> preferences) // to get preference of a student
        {
            for(int preference = 0; preference < n; preference++)
            {
                preferences.Add(Console.ReadLine());
            }
        }

        static void Print_Merit_List(List<Student> students)
        {
            foreach(Student student in students)
            {
                if (student.Registered_Degree == null)
                {
                    Console.WriteLine("{0} Got Admission in Nothing.", student.Name);
                }
                else
                {
                    Console.WriteLine("{0} Got Admission in degree {1}", student.Name, student.Registered_Degree.Title);
                }
            }
        }

        static Degree Add_Degree() // Add Degree Option
        {
            Console.WriteLine("Enter Degree Title: ");
            string degreetitle = Console.ReadLine();
            Console.WriteLine("Enter Degree Duration: ");
            int degreeduration = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Seats for Degree: ");
            int seats = int.Parse(Console.ReadLine());
            Degree newdegree = new Degree(degreetitle, degreeduration, seats);
            Console.WriteLine("Enter How many Subjects You want to Enter: ");
            int noofsubjects = int.Parse(Console.ReadLine());
            int totalcredithours = 0;
            for (int totalsubjects = 0; totalsubjects < noofsubjects; totalsubjects++)
            {
                Subject subject = Add_Subject();
                totalcredithours += subject.credit_hours;
                if (totalcredithours <= 20)
                {
                    newdegree.AddSubject(subject); // Adds subject to the degree list subjects
                }
            }
            return newdegree;      
        }

        static Subject Add_Subject() // takes subject attributes from the user and creates a new subject and returns it
        {
            Console.WriteLine("Enter Subject Code: ");
            string subjectcode = Console.ReadLine();
            Console.WriteLine("Enter Subject Name: ");
            string Subjecttype = Console.ReadLine();
            Console.WriteLine("Enter Subject Credit Hours: ");
            int credit_hours = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Subject Fees: ");
            int subjectfee = int.Parse(Console.ReadLine());
            Subject newsubject = new Subject(subjectcode, Subjecttype, credit_hours, subjectfee);
            return newsubject;
        }        

        static void Assign_program_to_students(List<Student> students, List<Degree> degrees) // this program assigns degrees to the students with according to thier preference list and merit.
        {
            foreach (Student student in students) // selects every student from added student list
            {
                foreach(string degreetitle in student.Prefrences) // selects every degree title from student degree preferences
                {
                    bool isdegreegiven = false;
                    foreach (Degree degree in degrees) // selects every degree from created degree lists
                    {
                        if (degreetitle == degree.Title) // if current preference degree is equal to current loop selected degree
                        {
                            if (degree.Available_Seats != 0) // if there are some available seats in the degree program
                            {
                                student.Registered_Degree = degree; // degree object will be added to the student attribute
                                degree.Available_Seats--; // one seat will be deducted as one student is added
                                isdegreegiven = true; // as one student is added we need to break the previous loop also 
                                break;
                            }
                        }
                    }
                    if (isdegreegiven) // breaks the loop when a student is added
                    {
                        break;
                    }
                }
            }
        }

        static void Print_Registered_Students(List<Student> students)
        {
            foreach(Student student in students)
            {
                if (student.Registered_Degree != null)
                {
                    Print_student(student);
                }
            }
        }

        static void Print_student(Student student)
        {
            Console.WriteLine("\nName: {0}", student.Name);
            Console.WriteLine("FSc: {0}", student.FSC_marks);
            Console.WriteLine("Ecat: {0}", student.Ecat_marks);
            Console.WriteLine("Age: {0}", student.Age);
        }

        static void View_Students_Of_Degree(List<Student> students)
        {
            Console.WriteLine("Enter Degree Name: ");
            string degreename = Console.ReadLine();
            foreach (Student student in students)
            {
                if (student.Registered_Degree == null)
                {
                    continue;
                }
                else if (student.Registered_Degree.Title == degreename)
                {
                    Print_student(student);
                }
            }
        }

        static void Sort_students(List<Student> students) // this program sorts the student in the list with student with highest merit on the zero index and so on
        {
            float highest_merit = 0F;
            for (int student = 0; student < students.Count - 1; student++)
            {
                highest_merit = students[student].Calculate_Merit();
                for (int nextstudent = student + 1; nextstudent < students.Count; nextstudent++)
                {
                    float next_merit = students[nextstudent].Calculate_Merit();
                    if (next_merit > highest_merit)
                    {
                        Student tempStudent = students[student];
                        students[student] = students[nextstudent];
                        students[nextstudent] = tempStudent;
                    }
                }
            }
        }

        static void Register_Subjects(List<Student> students) // registers subject for the student
        {
            Console.WriteLine("Enter student Subject Name");
            string student_name = Console.ReadLine();
            foreach (Student student in students)
            {
                if (student_name == student.Name)
                {
                    Console.WriteLine("Enter Subject Code: ");
                    string subject_code = Console.ReadLine();
                    foreach (Subject subject in student.Registered_Degree.subjects)
                    {
                        if (subject_code == subject.subject_code)
                        {
                            if ((subject.credit_hours + student.Total_Credit_Hours()) <= 9)
                            {
                                student.Registered_Subjects.Add(subject);
                            }
                        }
                    }          
                }
            }
        }

        static void Generate_Fee(List<Student> students) // prints fees of each students 
        {
            foreach (Student student in students)
            {
                int total_fee = student.Calculate_Fee();
                Console.WriteLine("{0} has total fee of {1}", student.Name, total_fee);
            }
        }
    }
}
