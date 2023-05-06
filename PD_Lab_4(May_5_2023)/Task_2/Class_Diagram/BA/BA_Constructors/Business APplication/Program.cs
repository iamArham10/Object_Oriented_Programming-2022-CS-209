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
            List<User> Admins = new List<User>();
            
            string Admin_Credentials_Path = "C:\\Users\\Win 10\\Documents\\Visual Studio 2019\\Business Application\\Admin_Credentials.txt";
            Read_User_Data(Admin_Credentials_Path, Admins, "admin");
            // Medicines Data Lists
            List<Medicine> Medicines = new List<Medicine>();

            // Reading medicine data from file and storing in medicines list
            string Medicines_Data_Path = "C:\\Users\\Win 10\\Documents\\Visual Studio 2019\\Business Application\\Medicines_Data.txt";
            Read_Medicines_Data(Medicines_Data_Path, Medicines);

            while (true)
            {
                Console.Clear();
                Print_menu();
                // coordinate position of menus and options
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
                                    User newAdmin = new User(new_admin_username,new_admin_password,"Admin");
                                    Admins.Add(newAdmin);
                                    Save_Data(Admin_Credentials_Path, Admins);
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
                                    User user = new User(entered_admin_username, entered_admin_password);
                                    user = user.Are_user_credentials_valid(Admins);
                                    if (user != null)
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
        // to print the title bar
        static void Print_menu()
        {
            string path = "C:\\Users\\Win 10\\Documents\\Visual Studio 2019\\Business Application\\main_menu.txt";
            Print_file(path, 0, 0);
        }
        // to print main menu options
        static void Print_Menu_options(int x, int y)
        {
            string path = "C:\\Users\\Win 10\\Documents\\Visual Studio 2019\\Business Application\\main_menu_options.txt";
            Print_file(path, x, y);
        }
        // print admin login options
        static void Print_admin_login_options(int x, int y)
        {
            string path = "C:\\Users\\Win 10\\Documents\\Visual Studio 2019\\Business Application\\admin_menu_options.txt";
            Print_file(path, x, y);
        }
        // prints admin credentials options menu
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
        
        // To Print Admin Options Menu
        static void Print_admin_option(int x, int y)
        {
            string path = "C:\\Users\\Win 10\\Documents\\Visual Studio 2019\\Business Application\\Admin_Options.txt";
            Print_file(path, x, y);
        }
        // to print add medicine options
        static void Print_Add_Medicine_option(int x, int y)
        {
            string path = "C:\\Users\\Win 10\\Documents\\Visual Studio 2019\\Business Application\\Add_Medicines_Menu.txt";
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
                    string username = Separate_Data(record, 1);
                    string userpassword = Separate_Data(record, 2);
                    User newuser = new User(username, userpassword, usertype);
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
                    Medicine NewMedicine = new Medicine(Medicine_name, Medicine_price, Medicine_weight);
                    Medicines.Add(NewMedicine);
                }
                fileVariable.Close();
            }
        }
        // saves medicine data in the file
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
        
        // remove any medicine from the list 
        static void Remove_Medicine_Option( List<Medicine> medicines, int option_position_x, int option_position_y)
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
                    Medicine newmedicine = new Medicine(Medicine_Name);
                    if (newmedicine.Is_Medicine_Present(medicines))
                    {
                        medicines =  newmedicine.Remove_Medicine(medicines);
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
        // this function erases the word written on the console by printing whitespace in its place
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
        // update medicine price option function
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
                    Medicine newmedicine = new Medicine(Medicine_Name);
                    int Medicine_Index = newmedicine.Get_Medicine_index(Medicines);
                    if (Medicine_Index != -1)
                    {
                        Console.SetCursorPosition(option_position_x + 20, option_position_y + 3);
                        newmedicine.price = Console.ReadLine();
                        while (newmedicine.Validate_quantity(newmedicine.price) != true)
                        {
                            Erase_word(newmedicine.price, option_position_x + 20, option_position_y + 3);
                            Console.SetCursorPosition(option_position_x + 20, option_position_y + 3);
                            newmedicine.price = Console.ReadLine();
                        }
                        Update_Medicine_Price(Medicine_Index, Medicines, newmedicine.price);              
                        Console.SetCursorPosition(option_position_x + 35, option_position_y + 2);
                        Console.WriteLine("Medicine price Changed Succesfully");
                        Thread.Sleep(sleepSpeed);
                    }
                    else
                    {
                        Console.SetCursorPosition(option_position_x + 35, option_position_y + 2);
                        Console.WriteLine("Medicine Is Not Present");
                        Thread.Sleep(sleepSpeed);
                    }
                }
                else
                {
                    Remove_Medicine_Running = false;
                }
            }
        }
        // this function prints the whole items present in the list
        static void Show_Medicines_Inventory(List<Medicine> Medicines, int option_position_x, int option_position_y)
        {
            Console.Clear();
            Print_menu();
            Console.SetCursorPosition(option_position_x, option_position_y);
            Console.WriteLine("-------------Inventory---------------");
            int Current_Medicine = 0;
            foreach (Medicine medicine in Medicines)
            {
                Console.WriteLine("Medicine Number {0} : ", Current_Medicine + 1);
                Console.WriteLine("Medicine Name: {0}", medicine.name);
                Console.WriteLine("Medicine Price: {0}", medicine.price);
                Console.WriteLine("Medicine Weight: {0}", medicine.weight);
                Console.WriteLine("");
                Current_Medicine++;
            }
            Console.WriteLine("                                        ");
            Console.WriteLine("Press Any Key To Exit");
            Console.ReadKey();
        }
        // updates price attribute of the item stored in list at a given index
        static void Update_Medicine_Price(int Medicine_index, List<Medicine> Medicines, string Medicine_Price)
        {
            Medicines[Medicine_index].Update_Medicine_Price(Medicine_Price);
        }

        // add medicine function
        static void Add_Medicine_function(List<Medicine> Medicines, int x, int y)
        {
            bool Add_medicine_running = true;
            while (Add_medicine_running)
            {
                Console.Clear();
                Print_menu();
                Print_Add_Medicine_option(x, y);
                string Medicine_Name;
                Console.SetCursorPosition(x + 23, y);
                Medicine_Name = Console.ReadLine();
                bool taking_medicine_name = true;
                Medicine newmedicine = new Medicine(Medicine_Name);
                while (taking_medicine_name)
                {
                    while (newmedicine.Validate_Name() != true)
                    {
                        Console.SetCursorPosition(x + 23, y);
                        newmedicine.name = Console.ReadLine();
                    }

                    if (newmedicine.Is_Medicine_Present(Medicines))
                    {
                        Console.SetCursorPosition(x + 40, y);
                        Console.WriteLine("Medicine is Already Present");
                        Console.SetCursorPosition(x + 23, y);
                        newmedicine.name = Console.ReadLine();
                    }
                    else
                    {
                        taking_medicine_name = false;
                    }
                }

                Console.SetCursorPosition(x + 23, y + 1);
                newmedicine.price = Console.ReadLine();
                while (newmedicine.Validate_quantity(newmedicine.price) != true)
                {
                    Console.SetCursorPosition(x + 23, y + 1);
                    newmedicine.price = Console.ReadLine();
                }
                Console.SetCursorPosition(x + 23, y + 2);
                newmedicine.weight = Console.ReadLine();
                while (newmedicine.Validate_quantity(newmedicine.weight) != true)
                {
                    Console.SetCursorPosition(x + 23, y + 2);
                    newmedicine.weight = Console.ReadLine();
                }

                Medicines = newmedicine.Add_Medicine(Medicines); // Adds the following medicine to the list
                Console.WriteLine("Press 0 to exit or any other key to Add another Item");
                string option = Console.ReadLine();
                if (option == "0")
                {
                    Add_medicine_running = false;
                }
            }
        }
    }
}
