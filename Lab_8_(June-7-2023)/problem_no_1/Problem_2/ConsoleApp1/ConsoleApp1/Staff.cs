using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Staff : Person
    {
        // attributes 
        protected string school;
        protected double pay;

        // constructor 
        public Staff(string name, string adress, string sch , double p) : base(name, adress)
        {
            this.school = sch;
            this.pay = p;
        }

        // get set funcions
        public string Get_School()
        {
            return this.school;
        }
        public void Set_School(string school)
        {
            this.school = school; 
        }

        public double Get_Pay()
        {
            return this.pay;
        }

        public void Set_Pay(double pay)
        {
            this.pay = pay;
        }

        // returns the state of attributes of Staff object
        public override string To_String()
        {
            return $"Name : {Get_Name()} Adress : {Get_Adress()} School : {Get_School()} Pay : {Get_Pay()}";
        }
    }
}
