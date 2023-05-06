using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_APplication
{
    class User
    { 
        public string username;
        public string userpassword;
        public string usertype;
        public User(string username, string userpassword)
        {
            this.username = username;
            this.userpassword = userpassword;
        }
        public User(string username, string userpassword, string usertype)
        {
            this.username = username;
            this.userpassword = userpassword;
            this.usertype = usertype;
        }

        // To check if Admin Credentials are Valid
        public User Are_user_credentials_valid(List<User> users)
        {
            for (int current_user = 0; current_user < users.Count; current_user++)
            {
                if (users[current_user].username == username)
                {
                    if (users[current_user].userpassword == userpassword)
                    {
                        return users[current_user];
                    }
                }
            }
            return null;
        }
    }

}
