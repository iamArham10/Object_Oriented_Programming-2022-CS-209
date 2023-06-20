using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Business_Application
{
    public class UserDL
    /// <summary>
    /// Stores data of all users
    /// </summary>
    { 
        // list of users
        static List<User> users = new List<User>();

        // add user to list function
        public static bool Add_User(User user)
        {
            // checks if user isn't null and users list doesn't already contains user
            if (user != null && !(users.Contains(user)))
            { 
                users.Add(user);
                return true;
            }
            return false;
        }


        //get user from username
        public static bool Remove_User(string Name)
        {
            User Requ_user = null;
            foreach (User user in users)
            {
                if (user.Get_UserName() == Name && user.Get_UserType() != "Admin")
                {
                    Requ_user = user;
                    break;
                }
            }
            if (Requ_user != null)
            {
                Remove_User(Requ_user);
                return true;

            }
            return false;
        }
        // remove speified user from list
        public static bool Remove_User(User specified_user)
        {
            // checks each user from list
            User user = Varify_User(specified_user);
            if (user != null)
            {
                users.Remove(user);
                return true;
            }
            // returns false if no user's credentials matches specified user credentials
            // to make sure no user is removed.
            return false;
        }

        // Varifies user
        public static User Varify_User(User specified_user)
        {
            foreach (User user in users) // selects each user from list
            {
                if (specified_user.Is_Credentials_Valid(user)) // if specified user is valid
                {
                    return user;
                }
            }
            // returns null 
            return null;       
        }

        public static bool Load_Users()
        {
            string users_path = @"C:\Users\Win 10\Documents\GitHub\Object_Oriented_Programming-2022-CS-209\Business_Application_Project\Business_Application\Business_Application\Files\User_Credentials.txt";
            if (File.Exists(users_path))
            {
                // creating a file reading variable
                StreamReader FileVar = new StreamReader(users_path);
                // creating an empty string
                string line = "";
                // reads the first line of file
                line = FileVar.ReadLine();
                // separates the first line by comma
                string[] separate_data = line.Split(',');
                string username = separate_data[0];
                string userpassword = separate_data[1];
                string usertype = separate_data[2];
                if (usertype == "Admin")
                {
                    // creating an admin
                    Admin admin = new Admin(username, userpassword);
                    // adding admin to userlist 
                    Add_User(admin);
                }
                
                while ((line = FileVar.ReadLine()) != null) 
                {
                    // splits the line through comma character
                    separate_data = line.Split(',');
                    username = separate_data[0];
                    userpassword = separate_data[1];
                    usertype = separate_data[2];

                    if (usertype == "Employee")
                    {
                        // creating Employee
                        Employee employee = new Employee(username, userpassword,new List<string>());
                        // adding employee to list
                        Add_User(employee);
                    }
                }
                return true;
            }
            return false;
        }

    }
}
