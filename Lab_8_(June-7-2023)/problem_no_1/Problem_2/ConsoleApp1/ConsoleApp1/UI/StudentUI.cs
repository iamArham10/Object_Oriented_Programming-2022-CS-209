using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class StudentUI
    {
        public static Student Get_Student()
        {
            Console.WriteLine("Enter Student Information");
            string name;string address;string program;int year; double fee;
            Console.Write("Enter Name ");
            name = Console.ReadLine();
            Console.Write("Enter Adress : ");
            address = Console.ReadLine();
            Console.Write("Enter Program : ");
            program = Console.ReadLine();
            Console.Write("Enter Year : ");
            year = int.Parse(Console.ReadLine());
            Console.Write("Enter Fee");
            fee = double.Parse(Console.ReadLine());
            Student newStudent = new Student(name, address, program, year, fee);
            return newStudent;
        }
    }

    
}
