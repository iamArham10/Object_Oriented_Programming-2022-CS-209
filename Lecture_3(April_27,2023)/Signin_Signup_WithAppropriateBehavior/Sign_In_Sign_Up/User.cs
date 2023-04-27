using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sign_In_Sign_Up
{
    class User
    {
        public string username;
        public string password;
        public string role;

        public User(string username, string password) // Constructor creates an object if username and password is given in parameter
        {
            this.username = username;
            this.password = password;
        }

        public User(string username, string password, string role) // Constructor creates an object if username, password and role is given in admin
        {
            this.username = username;
            this.password = password;
            this.role = role;
        }
        public bool IsAdmin()
        {
            bool isAdmin = false;
            if (role == "Admin")
            {
                isAdmin = true;
            }
            return isAdmin;
        }


    }
}
