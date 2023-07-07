using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignInSignUp
{
    public class UserDL
    {
        // list containing all users
        public static List<User> users = new List<User> ();
        
        // adds the user to list of users
        public static bool Add_User(User user)
        {
            if (Get_User(user) == null)
            {
                users.Add(user);
                return true;
            }
            return false;
        }

        // returns user with specified user credentials else returns null
        public static User SignIn(User user)
        {
            return Get_User(user);
        }

        // returns the required user
        private static User Get_User(User specifieduser)
        {
            foreach(User storeduser in users)
            {
                if (storeduser.Get_Username() == specifieduser.Get_Username() && storeduser.Get_UserPassword() == specifieduser.Get_UserPassword())
                {
                    return storeduser;
                }
            }
            return null;
        }

        // returns the required field between separated by comma from string
        public static string Parse_Data(string record, int field)
        {
            int comma = 1;
            string item = "";
            for (int x = 0; x < record.Length; x++)
            {
                if (record[x] == ',') comma++;
                else if (comma == field) item += record[x];
            }
            return item;
        }

        // Read User Data from File
        public static bool Read_Data_From_File(string path)
        {
            if (File.Exists(path))
            {
                StreamReader Var = new StreamReader(path);
                string line;
                while ((line = Var.ReadLine()) != null) 
                {
                    if (line == "") continue;
                    string username = Parse_Data(line, 1);
                    string password = Parse_Data(line, 2);
                    string userrole = Parse_Data(line, 3);
                    User user = new User(username, password, userrole);
                    Add_User(user);
                }
                Var.Close();
                return true;
            }
            return false;
        }

        // stores user data in file
        public static void Store_User_In_File(User user, string path)
        {
            StreamWriter Var = new StreamWriter(path, true);
            Var.WriteLine($"{user.Get_Username()},{user.Get_UserPassword()},{user.Get_Userrole()}");
            Var.Flush();
            Var.Close();
        }
    }
}
