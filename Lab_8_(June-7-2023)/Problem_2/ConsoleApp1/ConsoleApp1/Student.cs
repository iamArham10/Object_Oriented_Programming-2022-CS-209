using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Student : Person
    {
        // attributes 
        protected string program;
        protected int year;
        protected double fee;

        // constructor 
        public Student(string name, string address, string program, int year, double fee): base(name, address)
        {
            this.program = program;
            this.year = year;
            this.fee = fee;
        }

        // get set functions
        public string Get_Program()
        {
            return this.program;
        }

        public void Set_Program(string program)
        {
            this.program = program;
        }

        public int Get_year()
        {
            return this.year;
        }

        public void Set_year(int year)
        {
            this.year = year; 
        }

        public double Get_Fee()
        {
            return this.fee;
        }

        public void Set_Fee(double fee)
        {
            this.fee = fee;
        }

        // returns the state of all attributes of this class
        public override string To_String()
        {
            return $"Name : {Get_Name()} Adress : {Get_Adress()} Program : {Get_Program()} Year : {Get_year()} Fee : {Get_Fee()}";
        }

        

    }
}
