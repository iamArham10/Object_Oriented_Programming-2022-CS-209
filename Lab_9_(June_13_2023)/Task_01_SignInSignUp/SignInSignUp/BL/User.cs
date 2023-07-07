using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignInSignUp
{
    public class User
    {
        private string userName;
        private string password;
        private string userRole;

        public User(string userName, string password, string userRole)
        {
            this.userName = userName;
            this.password = password;
            this.userRole = userRole;
        }

        public User(string userName, string password)
        {
            this.userName = userName;   
            this.password = password;
            this.userRole = "NA";
        }

        // get functions
        public string Get_Username()
        {
            return this.userName;
        }

        public string Get_UserPassword()
        {
            return this.password;
        }

        public string Get_Userrole()
        {
            return this.userRole;
        }

        // to check if user is admin
        public bool Is_Admin()
        {
            if (userRole == "Admin")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
