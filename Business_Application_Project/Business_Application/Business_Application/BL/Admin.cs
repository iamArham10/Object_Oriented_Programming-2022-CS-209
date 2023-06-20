using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Application
{
    /// <summary>
    /// Admin is inherited from class user
    /// Admin has alot of functions Admin can also 
    /// </summary>
    public class Admin : User
    {
        // contructor 
        public Admin(string username, string password) : base(username, password) 
        {

        }

        // returns the user type of user
        public override string Get_UserType()
        {
            return "Admin";
        }

        public override bool Is_Function_Present(string fname)
        {
            return true;
        }
    }



}
