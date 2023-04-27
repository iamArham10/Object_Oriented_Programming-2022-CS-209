using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Sign_In_Sign_Up
{
    class Program
    {
        static void Main(string[] args)
        {
            List<User> users = new List<User>();
            string path = "C:\\Users\\Win 10\\Documents\\GitHub\\Object_Oriented_Programming-2022-CS-209\\Lecture_3(April_27,2023)\\Signin_Signup_WithAppropriateBehavior\\Sign_In_Sign_Up\\Files\\credentials.txt";
            char option;
            bool check = Read_Data(path, users);
            if (check)
            {
                Console.Write("Data Recorded Successfulyy");
            }
            else
            {
                Console.WriteLine("No Data is Present");
            }
            Console.ReadKey();
            do
            {
                Console.Clear();
                option = Menu();
                Console.Clear();
                if (option == '1')
                {
                    User user = Take_Input_Without_Role();
                    if (user != null)
                    {
                        user = Sign_In(user, users);
                        if (user == null)
                        {
                            Console.WriteLine("Invalid User");
                        }
                        else if (user.IsAdmin())
                        {
                            Console.WriteLine("Admin Menu");
                        }
                        else
                        {
                            Console.WriteLine("User Menu");
                        }
                    }
                }
                else if (option == '2')
                {
                    User user = Take_Input_With_Role();
                    if (user != null)
                    {
                        Store_Data_In_File(user, path);
                        Store_Data_In_List(users, user);
                    }

                }
                Console.ReadKey();
            } while (option != '0');
        }
        static char Menu() // prints the main menu options takes input and returns it
        {
            char option;
            Console.WriteLine("Enter the following options: ");
            Console.WriteLine("1. Sign In");
            Console.WriteLine("2. Sign Up");
            Console.WriteLine("0. Exit");
            option = char.Parse(Console.ReadLine());
            return option;
        }

        static bool Read_Data(string path, List<User> users)
        {
            if (File.Exists(path))
            {
                StreamReader fileVariable = new StreamReader(path);
                string record;
                while ((record = fileVariable.ReadLine()) != null)
                {
                    string username = Parse_Data(record, 1);
                    string password = Parse_Data(record, 2);
                    string role = Parse_Data(record, 3);
                    User user = new User(username, password, role);
                    Store_Data_In_List(users, user);
                }
                fileVariable.Close();
                return true;
            }
            return false;
        }

        static string Parse_Data(string line, int field)
        {
            int current_field = 1;
            string record = "";
            for (int x = 0; x < line.Length;x++)
            {
                if (record[x] == ',')
                {
                    current_field++;
                }
                if (current_field > field)
                {
                    break;
                }
                else if (current_field == field)
                {
                    record += line[x];
                }
            }
            return record;
        }
        static void Store_Data_In_File(User user, string path) // To Store user credentials in a file
        {
            StreamWriter fileVariable = new StreamWriter(path, true);
            fileVariable.WriteLine("{0},{1},{2}", user.username, user.password, user.role);
            fileVariable.Flush();
            fileVariable.Close();
        }

        static void Store_Data_In_List(List<User> users, User user) // to store user credentials in the list of users
        {
            users.Add(user);
        }

        static User Take_Input_Without_Role() // for the purpose of sign we'll only ask user to enter his username and password and returns the user
        {
            Console.WriteLine("Enter Name: ");
            string username = Console.ReadLine();
            Console.WriteLine("Enter Password: ");
            string password = Console.ReadLine();
            if (username != null && password != null)
            {
                User user = new User(username, password);
                return user;
            }
            return null;
        }

        static User Take_Input_With_Role() // it'll take input from user and his role for signup purpose
        {
            Console.WriteLine("Enter Name: ");
            string username = Console.ReadLine();
            Console.WriteLine("Enter Password: ");
            string password = Console.ReadLine();
            Console.WriteLine("Enter Role: ");
            string role = Console.ReadLine();
            if (username != null && password != null && role != null)
            {
                User user = new User(username, password, role);
                return user;
            }
            return null;
        }

        static User Sign_In(User user, List<User> users) // returns user if entered user credentials are valid
        {
            foreach (User storedUser in users)
            {
                if (user.username == storedUser.username && user.password == storedUser.password)
                {
                    return storedUser;
                }
            }
            return null;
        }





    }
}
