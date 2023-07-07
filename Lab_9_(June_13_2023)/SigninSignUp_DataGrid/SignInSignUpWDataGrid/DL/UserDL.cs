using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignInSignUpWDataGrid
{
    public class UserDL
    {
        private static List<User> UserList = new List<User>();

        internal static List<User> userList { get => UserList; set => UserList = value; }

        public static bool Add_User(User user)
        {
            if (Is_User_Available(user) == null)
            {
                return true;
            }
            return false;
        }

        public static User SignIn(User user)
        {
            return Is_User_Available(user);
        }

        public static User Is_User_Available(User user)
        {
            foreach(User saveduser in UserList)
            {
                if (saveduser.UserRole == user.UserRole) return saveduser;
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
            Var.WriteLine($"{user.Username},{user.Password},{user.UserRole}");
            Var.Flush();
            Var.Close();
        }

    }
}
