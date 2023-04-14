using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.IO;
using EZInput;

namespace Business_APplication
{
    class Program
    {
        static int sleepSpeed = 800;  // Sleep Speed
        static void Main(string[] args)
        {
            // admin credential lists.
            List<User> Admin = new List<User>();
            string Admin_Credentials_Path = "C:\\Users\\Win 10\\Documents\\Visual Studio 2019\\Business Application\\Admin_Credentials.txt";
            Read_User_Data(Admin_Credentials_Path, Admin, "admin");
            // Medicines Data Lists
            List<Medicine> Medicines = new List<Medicine>();
            string Medicines_Data_Path = "C:\\Users\\Win 10\\Documents\\Visual Studio 2019\\Business Application\\Medicines_Data.txt";
            Read_Medicines_Data(Medicines_Data_Path, Medicines);
            while (true)
            {
                Console.Clear();
                Print_menu();
                int option_position_x = 25;
                int option_position_y = 3;
                Print_Menu_options(option_position_x, option_position_y);
                string option = Console.ReadLine();
                Console.WriteLine(option);
                if (option == "1")
                {
                    while (true)
                    {
                        Console.Clear();
                        Print_menu();
                        Print_admin_login_options(option_position_x, option_position_y);
                        option = Console.ReadLine();
                        if (option == "0")
                        {
                            break;
                        }
                        else if (option == "2")
                        {
                            bool Is_Admin_signup_menu_running = true;
                            while (Is_Admin_signup_menu_running)
                            {
                                Console.Clear();
                                Print_menu();
                                Print_admin_credential_options(option_position_x, option_position_y);
                                string new_admin_username = "";
                                string new_admin_password = "";
                                option = Console.ReadLine();
                                if (option == "1")
                                {
                                    Get_admin_credentials(ref new_admin_username, ref new_admin_password, option_position_x, option_position_y);
                                    User newAdmin = new User();
                                    newAdmin.username = new_admin_username;
                                    newAdmin.userpassword = new_admin_password;
                                    newAdmin.usertype = "Admin";
                                    Admin.Add(newAdmin);
                                    Save_Data(Admin_Credentials_Path, Admin);
                                    Console.WriteLine("Admin Created Successfully");
                                    Console.WriteLine("Press Any key");
                                    Console.ReadKey();
                                }
                                else if (option == "0")
                                {
                                    Is_Admin_signup_menu_running = false;
                                }
                                
                            }
                            
                        }
                        else if (option == "1")
                        {
                            bool Is_Admin_signin_menu_running = true;
                            while (Is_Admin_signin_menu_running)
                            {
                                Console.Clear();
                                Print_menu();
                                Print_admin_credential_options(option_position_x, option_position_y);
                                string entered_admin_username = "";
                                string entered_admin_password = "";
                                option = Console.ReadLine();
                                if (option == "1")
                                {
                                    Get_admin_credentials(ref entered_admin_username, ref entered_admin_password, option_position_x, option_position_y);
                                    if (Are_admin_credentials_valid(entered_admin_username, entered_admin_password, Admin))
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Admin Logged In Successfully");
                                        bool Is_Admin_options_running = true;
                                        while (Is_Admin_options_running)
                                        {
                                            Console.Clear();
                                            Print_admin_option(option_position_x, option_position_y);
                                            option = Console.ReadLine();
                                            if (option == "0")
                                            {
                                                Is_Admin_options_running = false;
                                            }
                                            else if (option == "1")
                                            {
                                                Console.Clear();
                                                Print_menu();
                                                Add_Medicine_function( Medicines, option_position_x, option_position_y);
                                                Save_Medicine_Data(Medicines_Data_Path, Medicines);
                                                Console.WriteLine("Medicine Added Succesfully");
                                            }
                                            else if (option == "2")
                                            { 
                                                Remove_Medicine_Option(Medicines, option_position_x, option_position_y);
                                                Save_Medicine_Data(Medicines_Data_Path, Medicines);
                                            }
                                            else if (option == "3")
                                            {
                                                Update_Medicine_Price_Option(Medicines_Data_Path,Medicines, option_position_x, option_position_y);
                                                Save_Medicine_Data(Medicines_Data_Path,  Medicines);
                                            }
                                            else if (option == "4")
                                            {
                                                Show_Medicines_Inventory(Medicines, option_position_x, option_position_y);
                                            }
                                        }
                                    }
                                    else
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Wrong Admin Credentials");
                                    }
                                }
                                
                                

                                else if (option == "0")
                                {
                                    Is_Admin_signin_menu_running = false;
                                }
                                
                            }
                            
                        }
                    }
                }
                else if (option == "0")
                {
                    break;
                }
            }
        }

        static void Print_menu()
        {
            string path = "C:\\Users\\Win 10\\Documents\\Visual Studio 2019\\Business Application\\main_menu.txt";
            Print_file(path, 0, 0);
        }

        static void Print_Menu_options(int x, int y)
        {
            string path = "C:\\Users\\Win 10\\Documents\\Visual Studio 2019\\Business Application\\main_menu_options.txt";
            Print_file(path, x, y);
        }

        static void Print_admin_login_options(int x, int y)
        {
            string path = "C:\\Users\\Win 10\\Documents\\Visual Studio 2019\\Business Application\\admin_menu_options.txt";
            Print_file(path, x, y);
        }
        
        static void Print_admin_credential_options(int x, int y)
        {
            string path = "C:\\Users\\Win 10\\Documents\\Visual Studio 2019\\Business Application\\Admin_credentials_menu.txt";
            Print_file(path, x, y);
        }
        // to Input Admin Credentials
        static void Get_admin_credentials(ref string username, ref string password, int x, int y)
        {
            Console.SetCursorPosition(x + 15, y + 2);
            username = Console.ReadLine();
            Console.SetCursorPosition(x + 19, y + 3);
            password = Console.ReadLine();
        }
        // To check if Admin Credentials are Valid
        static bool Are_admin_credentials_valid(string user_name, string password, List<User> admin)
        {
            bool isValid = false;
            for (int current_user = 0; current_user < admin.Count;current_user++)
            {
                if (admin[current_user].username == user_name)
                {
                    if (admin[current_user].userpassword == password)
                    {
                        isValid = true;
                    }
                }
            }
            return isValid;
        }
        // To Print Admin Options Menu
        static void Print_admin_option(int x, int y)
        {
            string path = "C:\\Users\\Win 10\\Documents\\Visual Studio 2019\\Business Application\\Admin_Options.txt";
            Print_file(path, x, y);
        }
        // To Read Admin Data
        static void Read_User_Data(string path, List<User> users, string usertype)
        {
            if (File.Exists(path))
            {
                StreamReader fileVariable = new StreamReader(path);
                string record;
                while ((record = fileVariable.ReadLine()) != null)
                {
                    if (record == "")
                    {
                        break;
                    }
                    User newuser = new User();
                    newuser.username = Separate_Data(record, 1);
                    newuser.userpassword = Separate_Data(record, 2);
                    newuser.usertype = usertype;
                    users.Add(newuser);
                }
                fileVariable.Close();
            }
        }
        // To save user name and passwords in a file
        static void Save_Data(string path, List<User> users)
        {
            StreamWriter fileVariable = new StreamWriter(path, false);
            for (int current_user = 0; current_user < users.Count; current_user++)
            {
                fileVariable.WriteLine(users[current_user].username + "," + users[current_user].userpassword + "," + users[current_user].usertype);
            }
            fileVariable.Flush();
            fileVariable.Close();
        }
        // Separate different values combined with comma
        static string Separate_Data(string line, int field_number)
        {
            string field = "";
            int current_field_number = 1;
            for (int index = 0; index < line.Length;index++)
            {
                if (line[index] == ',')
                {
                    current_field_number++;
                    if (current_field_number > field_number)
                    {
                        break;
                    }
                    continue;
                }
                if (current_field_number == field_number)
                {
                    field += line[index];
                }
            }
            return field;
        }
        // Prints The Data Stored in the File
        static void Print_file(string path, int x, int y)
        {
            StreamReader fileVariable = new StreamReader(path);
            string line;
            while ((line = fileVariable.ReadLine()) != null)
            {
                Console.SetCursorPosition(x, y);
                Console.WriteLine(line);
                y++;
            }
            fileVariable.Close();
        }
        // Reads medicines Data
        static void Read_Medicines_Data(String path, List<Medicine> Medicines)
        {
            if(File.Exists(path))
            {
                StreamReader fileVariable = new StreamReader(path);
                string record;
                while ((record = fileVariable.ReadLine()) != null)
                {
                    if (record == "")
                    {
                        break;
                    }

                    string Medicine_name = Separate_Data(record, 1);
                    string Medicine_price = Separate_Data(record, 2);
                    string Medicine_weight = Separate_Data(record, 3);
                    Medicines.Add(Add_Medicine(Medicine_name, Medicine_price, Medicine_weight));
                }
                fileVariable.Close();
            }
        }

        static void Save_Medicine_Data(string path,List<Medicine> Medicines)
        {
            StreamWriter fileVariable = new StreamWriter(path, false);
            for (int Current_Medicine = 0; Current_Medicine < Medicines.Count;Current_Medicine++)
            {
                fileVariable.WriteLine(Medicines[Current_Medicine].name + "," + Medicines[Current_Medicine].price + "," + Medicines[Current_Medicine].weight);
            }
            fileVariable.Flush();
            fileVariable.Close();
        }
        static void Print_Add_Medicine_option(int x, int y)
        {
            string path = "C:\\Users\\Win 10\\Documents\\Visual Studio 2019\\Business Application\\Add_Medicines_Menu.txt";
            Print_file(path, x, y);
        }

        static void Remove_Medicine_Option( List<Medicine> Medicines, int option_position_x, int option_position_y)
        {
            string remove_medicine_option_file = "C:\\Users\\Win 10\\Documents\\Visual Studio 2019\\Business Application\\Remove_Medicine_Menu.txt";
            
            bool Remove_Medicine_Running = true;
            while (Remove_Medicine_Running)
            {
                Console.Clear();
                Print_menu();
                Print_file(remove_medicine_option_file, option_position_x, option_position_y);
                Console.WriteLine("Enter 1 To Enter the Name or Any other key to exit: ");
                string option = Console.ReadLine();
                if (option == "1")
                {
                    Console.SetCursorPosition(option_position_x + 20, option_position_y + 2);
                    string Medicine_Name =  Console.ReadLine();
                    int Medicine_Index = Is_Medicine_Present(Medicines, Medicine_Name);
                    if (Medicine_Index != -1)
                    {
                        Remove_Medicine(Medicines, Medicine_Index);

                        Console.SetCursorPosition(option_position_x + 35, option_position_y + 2);
                        Console.WriteLine("Medicine Removed Succesfully");
                    }
                    else
                    {
                        Console.SetCursorPosition(option_position_x + 35, option_position_y + 2);
                        Console.WriteLine("Medicine Is Not Present");
                    }
                }
                else
                {
                    Remove_Medicine_Running = false;
                }
            }
        }

        static void Erase_word(string line, int x, int y)
        {
            Console.SetCursorPosition(x, y);
            for (int idx = 0; idx < line.Length;idx++)
            {
                Console.SetCursorPosition(x, y);
                Console.Write(" ");
                x++;
            }
        }

        static void Update_Medicine_Price_Option(string path, List<Medicine> Medicines, int option_position_x, int option_position_y)
        {
            string Update_Medicine_Price_file = "C:\\Users\\Win 10\\Documents\\Visual Studio 2019\\Business Application\\Update_Medicine_Price.txt";

            bool Remove_Medicine_Running = true;
            while (Remove_Medicine_Running)
            {
                Console.Clear();
                Print_menu();
                Print_file(Update_Medicine_Price_file, option_position_x, option_position_y);
                Console.WriteLine("Enter 1 To Enter the Name or Any other key to exit: ");
                string option = Console.ReadLine();
                if (option == "1")
                {
                    Console.SetCursorPosition(option_position_x + 20, option_position_y + 2);
                    string Medicine_Name = Console.ReadLine();
                    int Medicine_Index = Is_Medicine_Present(Medicines, Medicine_Name);
                    if (Medicine_Index != -1)
                    {
                        Console.SetCursorPosition(option_position_x + 20, option_position_y + 3);
                        string price = Console.ReadLine();
                        while (Validate_quantity(price) != true)
                        {
                            Erase_word(price, option_position_x + 20, option_position_y + 3);
                            Console.SetCursorPosition(option_position_x + 20, option_position_y + 3);
                            price = Console.ReadLine();
                        }
                        Update_Medicine_Price(Medicine_Index, Medicines, price);
                        
                        Console.SetCursorPosition(option_position_x + 35, option_position_y + 2);
                        Console.WriteLine("Medicine price Changed Succesfully");
                        Thread.Sleep(sleepSpeed);
                    }
                    else
                    {
                        Console.SetCursorPosition(option_position_x + 35, option_position_y + 2);
                        Console.WriteLine("Medicine Is Not Present");
                        Thread.Sleep(800);
                    }
                }
                else
                {
                    Remove_Medicine_Running = false;
                }
            }
        }

        static void Show_Medicines_Inventory(List<Medicine> Medicines, int option_position_x, int option_position_y)
        {
            Console.Clear();
            Print_menu();
            Console.SetCursorPosition(option_position_x, option_position_y);
            Console.WriteLine("-------------Inventory---------------");
            for (int Current_Medicine = 0; Current_Medicine < Medicines.Count ; Current_Medicine++)
            {

                Console.WriteLine("Medicine Number {0} : ", Current_Medicine + 1);
                Console.WriteLine("Medicine Name: {0}", Medicines[Current_Medicine].name);
                Console.WriteLine("Medicine Price: {0}", Medicines[Current_Medicine].price);
                Console.WriteLine("Medicine Weight: {0}", Medicines[Current_Medicine].weight);
                Console.WriteLine("");
        
            }
            Console.WriteLine("                                        ");
            Console.WriteLine("Press Any Key To Exit");
            Console.ReadKey();
        }

        static void Update_Medicine_Price(int Medicine_index, List<Medicine> Medicines, string Medicine_Price)
        {
            Medicines[Medicine_index].price = Medicine_Price;
        }

        // this function removes Medicine from an array
        static void Remove_Medicine (List<Medicine> Medicines, int index)
        {
            Medicines.RemoveAt(index);
        }

        // Returns Index of a Medicine if Medicine is Present if Medicine is not present it will return -1;
        static int Is_Medicine_Present(List<Medicine> Medicine,string Medicine_Name)
        { 
            for (int Current_Medicine = 0; Current_Medicine < Medicine.Count; Current_Medicine++)
            {
                if (Medicine[Current_Medicine].name == Medicine_Name)
                {
                    return Current_Medicine;
                }
            }
            return -1;
        }

        static void Add_Medicine_function(List<Medicine> Medicines,int x, int y)
        {
            bool Add_medicine_running = true;
            while (Add_medicine_running)
            {
                Console.Clear();
                Print_menu();
                Print_Add_Medicine_option(x, y);
                string Medicine_Name;
                string Medicine_Price;
                string Medicine_Weight;
                Console.SetCursorPosition(x + 23, y);
                Medicine_Name = Console.ReadLine();
                bool taking_medicine_name = true;
                while (taking_medicine_name)
                {
                    while (Validate_Name(Medicine_Name) != true)
                    {
                        Console.SetCursorPosition(x + 23, y);
                        Medicine_Name = Console.ReadLine();
                    }
                    if (Is_Medicine_Present(Medicines, Medicine_Name) == -1)
                    {
                        taking_medicine_name = false;
                    }
                    else
                    {
                        Console.SetCursorPosition(x + 40, y);
                        Console.WriteLine("Medicine is Already Present");
                        Console.SetCursorPosition(x + 23, y);
                        Medicine_Name = Console.ReadLine();
                    }
                }
                
                Console.SetCursorPosition(x + 23, y + 1);
                Medicine_Price = Console.ReadLine();
                while (Validate_quantity(Medicine_Price) != true)
                {
                    Console.SetCursorPosition(x + 23, y + 1);
                    Medicine_Price = Console.ReadLine();
                }
                Console.SetCursorPosition(x + 23, y + 2);
                Medicine_Weight = Console.ReadLine();
                while (Validate_quantity(Medicine_Weight) != true)
                {
                    Console.SetCursorPosition(x + 23, y + 2);
                    Medicine_Weight = Console.ReadLine();
                }
                Medicines.Add(Add_Medicine(Medicine_Name, Medicine_Price, Medicine_Weight));

                Console.WriteLine("Press 0 to exit or any other key to Add another Item");
                string option = Console.ReadLine();
                if (option == "0")
                {
                    Add_medicine_running = false;
                }
            }
        }
        // <-> Add medicine To inventory Function <->
        static Medicine Add_Medicine(string Medicine_name, string Medicine_price, string Medicine_weight)
        {
            Medicine TempMedicine = new Medicine();
            TempMedicine.name = Medicine_name;
            TempMedicine.price = Medicine_price;
            TempMedicine.weight = Medicine_weight;
            return TempMedicine;
        }
        

 

        static bool Validate_Name(string name)
        {
            bool Is_valid = true;
            for (int idx = 0; idx < name.Length;idx++)
            {
                int c = (int)name[idx];
                if ((c >= 65 && c <= 90) || (c >= 97 && c <= 122))
                {
                    continue;
                }
                else
                {
                    Is_valid = false;
                    break;
                }
            }
            return Is_valid;
        }

        static bool Validate_quantity(string quantity)
        {
            bool Is_valid = true;
            if (quantity[0] == '0')
            {
                Is_valid = false;
            }
            for (int character = 0; character < quantity.Length;character++)
            {
                
                int c = quantity[character];
                if (c < 48 || c > 58)
                { 
                    Is_valid = false;
                    break;
                }
            }
            return Is_valid;
        }  
    }
}
