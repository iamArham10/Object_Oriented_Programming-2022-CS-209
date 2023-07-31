using Pharmacy_Management_System.BL;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace Pharmacy_Management_System
{
    internal class UserDL
    {
        // list of users
        static List<User> users = new List<User>();
        static string users_path = @"C:\Users\Win 10\Documents\GitHub\Object_Oriented_Programming-2022-CS-209\Business_Application_Project\Business_Application\Business_Application\Files\User_Credentials.txt";
        // add user to list function
        public static bool Add_User(User user)
        {
            // checks if user isn't null and users list doesn't already contains user
            if (user != null && !(Contains_User(user)))
            {
                users.Add(user);
                return true;
            }
            return false;
        }

        public static bool Contains_User(User user)
        {
            foreach (User storeduser in users)
            {
                if (storeduser.Get_UserName() == user.Get_UserName())
                {
                    return true;
                }
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
                    string[] strfunctions = (separate_data[3]).Split('@');
                    if (usertype == "Employee")
                    {
                        // creating Employee
                        Employee employee = new Employee(username, userpassword, Employee.Get_Enum_Functions_List(strfunctions));
                        // adding employee to list
                        Add_User(employee);
                    }
                }
                FileVar.Close();
                return true;
            }
            return false;
        }

        public static void Save_User(Employee user)
        {
            StreamWriter fileVar = new StreamWriter(users_path, true);
            string line = "";
            line += user.Get_UserName() + ',' + user.Get_UserPassword() + ',' + "Employee" + ',';
            string[] list = Employee.Get_String_Functions_List(user.Functions_List);
            if (list != null)
            {
                foreach (string str in list)
                {
                    line += str + '@';
                }
            }
            fileVar.WriteLine(line);
            fileVar.Flush();
            fileVar.Close();
        }
    }
}
