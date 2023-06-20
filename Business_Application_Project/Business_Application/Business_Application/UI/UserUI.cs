using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Application
{
    /// <summary>
    /// UserUI has User input and output related functions.
    /// </summary>
    public class UserUI
    {
        // inputs username and password from user
        public static User Get_User(int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine("Username : ");
            Console.SetCursorPosition(x + 11, y);
            string username = Console.ReadLine();
            Console.SetCursorPosition(x, y + 1);
            Console.WriteLine("Password : ");
            Console.SetCursorPosition(x + 11, y + 1);
            string password = MainUI.Get_Password();
            User user = new User(username, password);
            return user;
        }
        
        public static void Remove_Employee(int cord_x, int cord_y)
        {
            Console.SetCursorPosition(cord_x, cord_y); Console.Write("Enter Employee Name To Remove : ");
            cord_y++;
            string Employee_Name = Console.ReadLine();
            Console.SetCursorPosition(cord_x, cord_y);
            if (UserDL.Remove_User(Employee_Name))
            {
                Console.Write("Employee Deleted");
            }
            else
            {
                Console.Write("Employee is not Present");
            }

        }
        // prints the admin option employee management on screen and gets the input from suer
        public static char Print_Admin_Option_Employee(int cord_x, int cord_y)
        {
            string file_path = @"C:\Users\Win 10\Documents\GitHub\Object_Oriented_Programming-2022-CS-209\Business_Application_Project\Business_Application\Business_Application\Files\Admin_Option_Employee.txt";
            MainUI.Print_File(file_path, cord_x, cord_y);
            char option = Console.ReadKey(true).KeyChar;
            return option;
        }

        // asks user Employee name and passwords and creates a employee
        public static Employee Create_Employee(int cord_x, int cord_y)
        {
            bool Taking_Employee_Credentials = true;
            string Employee_Name = null;
            string Password = null;
            while (Taking_Employee_Credentials)
            {
                string message = "Enter Employee Name : ";
                Console.SetCursorPosition(cord_x, cord_y);
                Console.WriteLine(message);
                Employee_Name = MainUI.Get_String_Input(message , cord_x , cord_y);
                cord_y++;
                message = "Enter Employee Password : ";
                Console.SetCursorPosition(cord_x, cord_y);
                Console.Write(message);
                Console.SetCursorPosition(cord_x + message.Length, cord_y);
                Password = MainUI.Get_Password();
                Taking_Employee_Credentials = false;
            }
            MainUI.Clear_Screen();
            MainUI.Print_Header();
            Employee newEmployee = new Employee(Employee_Name, Password, Allowed_Features(5 , 10));
            return newEmployee;
        }

        // create Employee Allowed Options
        public static List<string> Allowed_Features(int cord_x, int cord_y)
        {
            List<string> features = new List<string>(); 
            Console.SetCursorPosition(cord_x, cord_y);cord_y++;
            Console.Write("TakeOrder");
            Console.SetCursorPosition(cord_x, cord_y); cord_y++;
            Console.Write("AddMedicine");
            Console.SetCursorPosition(cord_x, cord_y); cord_y++;
            Console.Write("ViewMedicine");
            Console.SetCursorPosition(cord_x, cord_y); cord_y++;
            Console.Write("RemoveMedicine");
            Console.SetCursorPosition(cord_x, cord_y); cord_y++;
            Console.Write("AddMedicineWeight");
            Console.SetCursorPosition(cord_x, cord_y); cord_y++;
            Console.Write("ChangePrice");
            Console.SetCursorPosition(cord_x, cord_y); cord_y++;
            Console.Write("AddStock");
            Console.SetCursorPosition(cord_x, cord_y); cord_y++;
            Console.Write("SeeSales");
            Console.SetCursorPosition(cord_x, cord_y); cord_y++;
            Console.Write("ManageEmployee");
            cord_y++;
            Console.SetCursorPosition(cord_x, cord_y);
            Console.Write("Enter The Number of Options between 1 and 9 : ");
            string numberofoption = Console.ReadLine();
            cord_y++;
            for (int i = 0; i < int.Parse(numberofoption);i++)
            {
                Console.SetCursorPosition(cord_x, cord_y);
                Console.Write("Enter Feature : ");
                string feature = Console.ReadLine();
                cord_y++;
                if (features.Contains(feature))
                {
                    Console.SetCursorPosition(cord_x, cord_y);
                    Console.Write("Feature Already Present");
                    i--;
                }
                else 
                {
                    features.Add(feature);
                }
                cord_y++;
            }
            return features;
        }
    }
}
