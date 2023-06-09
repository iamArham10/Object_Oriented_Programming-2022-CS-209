using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Departmental_Store
{
    class User
    {
        public string username;
        public string passcode;
        public char usertype;
        // constructor
        public User(string username, string passcord)
        {
            this.username = username;
            this.passcode = passcord;
        }
        public User(string username, string passcode, char usertype)
        {
            this.username = username;
            this.passcode = passcode;
            this.usertype = usertype;
        }
        // methods
        public bool Is_Admin()
        {
            bool isAdmin = false;
            if (usertype == 'A')
            {
                isAdmin = true;
            }
            return isAdmin;
        }

    }
}
