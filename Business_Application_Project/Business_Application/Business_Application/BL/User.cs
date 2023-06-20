using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Application
{
    public class User
    {
        // attribute
        protected string Username;
        protected string password;
        // constructor
        public User(string  Username, string password)
        {
            this.Username = Username;
            this.password = password;
        }

        // returns the username of User
        public string Get_UserName()
        {
            return this.Username;
        }

        // returns the user type of user
        public virtual string Get_UserType()
        {
            return "Undefined";
        }

        public virtual bool Is_Function_Present(string fname)
        {
            return false;
        }

        // checks if credentials are valid
        public bool Is_Credentials_Valid(string username, string password)
        {
            bool Is_Valid = false;
            // if given arguments username and password matches user's username and password 
            if (this.Username == username && this.password == password)
            {
                // sets true meaning credentials are valid
                Is_Valid = true;
            }
            return Is_Valid;
        }

        // takes another user and checks if user credentials are valid
        public bool Is_Credentials_Valid(User user)
        {
            if (user.Is_Credentials_Valid(this.Username, this.password))
            {
                return true;
            }
            return false;
        }

        // changes password
        public bool Change_Password(string password)
        {
            if (this.password != password) 
            {
                this.password = password;
                return true;
            }
            return false;
        }

    }
}
