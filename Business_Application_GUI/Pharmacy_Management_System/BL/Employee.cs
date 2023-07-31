using Pharmacy_Management_System.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy_Management_System
{
    internal class Employee : User
    {
        // attributes
        // available functions list determines which functions Employee can use.
        private List<Functions> available_functions;
        // list of customers that employee has taken order
        // private List<Customer> customers = new List<Customer>();

        // constructor 
        public Employee(string username, string password, List<Functions> features) : base(username, password)
        {
            this.available_functions = features;
        }

        public List<Functions> Functions_List { get => available_functions; set => available_functions = value; }
        // functions
        public override string Get_UserType()
        {
            return "Employee";
        }

        // checks if Function is Present
        public override bool Is_Function_Present(Functions function)
        {
            if (available_functions == null) return false;
            if (available_functions.Contains(function)) return true;
            return false;
        }

        public static List<Functions> Get_Enum_Functions_List(string[] functions)
        {
            List<Functions> functions1 = new List<Functions>();
            foreach (string function in functions)
            {
                if (function == "O") functions1.Add(Functions.ORDER);
                else if (function == "A") functions1.Add(Functions.ADD);
                else if (function == "V") functions1.Add(Functions.VIEW);
                else if (function == "R") functions1.Add(Functions.REMOVE);
                else if (function == "C") functions1.Add(Functions.CHANGE);
                else if (function == "S") functions1.Add(Functions.SALES);
                else if (function == "E") functions1.Add(Functions.EMPLOYEE);
            }
            return functions1;
        }

        public static string[] Get_String_Functions_List(List<Functions> functions)
        {
            if (functions != null)
            {
                string[] string_functions = new string[functions.Count];
                for (int i = 0; i < functions.Count; i++)
                {
                    string Letter = null;
                    if (functions[i] == Functions.ORDER) Letter = "O";
                    else if (functions[i] == Functions.ADD) Letter = "A";
                    else if (functions[i] == Functions.CHANGE) Letter = "C";
                    else if (functions[i] == Functions.EMPLOYEE) Letter = "E";
                    else if (functions[i] == Functions.SALES) Letter = "S";
                    else if (functions[i] == Functions.VIEW) Letter = "V";
                    if (Letter != null) string_functions[i] = Letter;
                }
            }
            
            return null;
        }
    }
}
