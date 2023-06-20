using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Application
{
    public class Employee : User
    /// <summary>
    /// Employee class extends user class 
    /// Employee class implements responsibilites of employee
    /// in pharmacy management system
    /// </summary>
    {
        // attributes
        // available functions list determines which functions Employee can use.
        private List<string> available_functions = new List<string>();
        // list of customers that employee has taken order
        // private List<Customer> customers = new List<Customer>();

        // constructor 
        public Employee(string username, string password, List<string> features) : base(username, password) 
        {
            this.available_functions = features; 
        }

        // functions
        public override string Get_UserType()
        {
            return "Employee";
        }

        // checks if Function is Present
        public override bool Is_Function_Present(string fname)
        {
            if (available_functions.Contains(fname)) return true;
            return false;
        }
    }
}
