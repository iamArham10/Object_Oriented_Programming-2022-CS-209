using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<User> users = new List<User>(); // creating a list of User Objects
            int User_Count = 0;
            string name = "hello";
            name[2] = 't';
            string Credentials_path = "C:\\Users\\Win 10\\Documents\\Visual Studio 2019\\Lab_2_(13-4-2023)\\Challenge_2_SigninSingup\\Req_Files\\Users.txt";
            Read_Data(Credentials_path, users, ref User_Count);
            Char option;
            do
            {
                Console.Clear();
                option = Main_Menu();
                if (option == '1')
                {
                    Console.Clear();
                    Console.WriteLine("Enter Name: ");
                    string name = Console.ReadLine();
                    Console.WriteLine("Enter Password: ");
                    string password = Console.ReadLine();
                    Store_Data(Credentials_path, name, password);
                    Sign_Up(ref User_Count, users, name, password);   
                }
                else if (option == '2')
                {
                    Console.Clear();
                    Console.WriteLine("Enter Name: ");
                    string name = Console.ReadLine();
                    Console.WriteLine("Enter Password: ");
                    string password = Console.ReadLine();
                    Sign_in(User_Count, users, name, password);

                }
            } while (option != '0');
            
        }

        static char Main_Menu() // Prints the Main Menu and takes the input from user
        {
            char option;
            Console.WriteLine("Enter The Following Options: ");
            Console.WriteLine("1. Sign UP");
            Console.WriteLine("2. Sign IN");
            Console.WriteLine("0. Exit");
            option = char.Parse(Console.ReadLine());
            return option;
        }

        static void Read_Data(string path , List<User> users, ref int count)
        {
            if (File.Exists(path))
            {
                StreamReader fileVariable = new StreamReader(path);
                string record;
                while ((record = fileVariable.ReadLine()) !=  null)
                {
                    User tempUser = new User();
                    tempUser.username = ParseData(record, 1);
                    tempUser.password = ParseData(record, 2);
                    users.Add(tempUser);
                    count++;
                }
                fileVariable.Close();
            }
            
        }

        static void Store_Data(string path,string User_name, string Password)
        {
            if (File.Exists(path))
            {
                StreamWriter file = new StreamWriter(path, true);
                file.WriteLine(User_name + "," + Password);
                file.Flush();
                file.Close();
            }
            
        }

        static User Add_User(string user_name, string password) // this function returns the temporary object admin.
        {
            User admin = new User();
            admin.username = user_name;
            admin.password = password;
            return admin;
        }

        static string ParseData(string record, int field)
        {
            int comma = 1;
            string item = "";
            for (int x = 0; x < record.Length; x++)
            {
                if (record == "")
                {
                    break;
                }
                if (record[x] == ',')
                {
                    comma++;
                }
                else if (comma == field)
                {
                    item += record[x];
                }
            }
            return item;
        }

        static void Sign_Up(ref int count, List<User> user, string name, string password)
        {
            
            user.Add(Add_User(name, password));
            count++;
        }

        static void Sign_in(int count, List<User> user, string name, string password)
        {
            bool is_Valid = false;
            for (int admin = 0; admin < count; admin++)
            {
                if (name == user[admin].username && password == user[admin].password)
                {
                    is_Valid = true;
                    break;
                }
            }
            if (is_Valid)
            {
                Console.Clear();
                Console.WriteLine("Sign Up Succesful");
                Console.WriteLine("Press Any key to Coninue");
                Console.ReadKey();
            }
        }
    }
}
