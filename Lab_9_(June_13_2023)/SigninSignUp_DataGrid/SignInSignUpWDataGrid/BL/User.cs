using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace SignInSignUpWDataGrid
{
    public class User
    {
        private string username;
        private string password;
        private string usertype;

        // get set functions
        public string Username { get => username; set => username = value; }    
        public string Password { get => password; set => password = value; }
        public string UserRole {  get => usertype; set => usertype = value; }

        // contructors
        public User(string username, string password, string usertype)
        {
            this.username = username;
            this.password = password;
            this.usertype = usertype;
        }
        public User(string username, string password)
        {
            this.username  = username;
            this.password  = password;
            usertype = "NA";
        }

        // functions
        public bool IsAdmin()
        {
            if (this.usertype == "Admin")
            {
                return true;
            }
            return false;
        }
    }
}
