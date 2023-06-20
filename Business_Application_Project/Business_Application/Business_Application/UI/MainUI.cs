using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Application
{
    /// <summary>
    /// MainUI contains all of the menu related functions
    /// </summary>
    public class MainUI
    {

        // prints header on console
        public static void Print_Header()
        {
            // header file path
            string header_path = @"C:\Users\Win 10\Documents\GitHub\Object_Oriented_Programming-2022-CS-209\Business_Application_Project\Business_Application\Business_Application\Files\Header.txt";
            Print_File(header_path, 0 , 0);
        }

        // prints specified file data on console
        // Xcord and Ycord represents console coordinate where data will be printed
        public static void Print_File(string path, int X_cord, int Y_cord) 
        {
            StreamReader FileVariable = new StreamReader(path);
            string line;
            while ((line = FileVariable.ReadLine()) != null) 
            {
                Console.SetCursorPosition(X_cord, Y_cord);
                string Line_Verbatum = @line;
                Console.WriteLine(Line_Verbatum);
                Y_cord++;
            }
        }

        // prints the Main menu on console
        public static char Main_Menu(int X_cord, int Y_cord)
        {
            string Main_Menu_path = @"C:\Users\Win 10\Documents\GitHub\Object_Oriented_Programming-2022-CS-209\Business_Application_Project\Business_Application\Business_Application\Files\Main_Menu.txt";
            Print_File(Main_Menu_path, X_cord, Y_cord);
            char option = Console.ReadKey(true).KeyChar;
            return option;
        }

        // prints the main menu optinos
        public static char Main_Menu_Options(int Cord_X, int Cord_Y)
        {
            string Main_Menu_Option_Path = @"C:\Users\Win 10\Documents\GitHub\Object_Oriented_Programming-2022-CS-209\Business_Application_Project\Business_Application\Business_Application\Files\Application_Options.txt";
            Print_File(Main_Menu_Option_Path, Cord_X, Cord_Y);
            char option = Console.ReadKey(true).KeyChar;
            return option;
        }

        // prints add menu options
           
        // get's password from user prints * instead of password characters
        public static string Get_Password()
        {
            string password = "";
            char c = ' ';
            int intc = c;
            while(true)
            {
                c = Console.ReadKey(true).KeyChar;
                intc = c;
                if (intc == 13)
                {
                    break;
                }
                Console.Write('*');
                password += c;
            }
            return password;
        }

        // clears the console screen
        public static void Clear_Screen()
        {
            Console.Clear();
        }

        // prints the remove medicine options and inputs option from user
        public static char Print_Remove_Medicine_Option(int X_cord, int Y_Cord)
        {
            string Remove_Medicine_Option_Path = @"C:\Users\Win 10\Documents\GitHub\Object_Oriented_Programming-2022-CS-209\Business_Application_Project\Business_Application\Business_Application\Files\Remove_Medicine_Option.txt";
            Print_File(Remove_Medicine_Option_Path, X_cord, Y_Cord);
            char option = Console.ReadKey(true).KeyChar;
            return option;
        }

        // prints message on console at specified coordinates
        public static void Write_Message(string message , int cord_x, int cord_y)
        {
            Console.SetCursorPosition(cord_x , cord_y);
            Console.Write(message);
        }

        // gets valid string from user 
        public static string Get_String_Input(string message, int cord_x, int cord_y)
        {
            Console.SetCursorPosition(cord_x + message.Length, cord_y);
            string name = Console.ReadLine();
            while (ValidationUI.Is_String_Valid(name) == false)
            {
                ValidationUI.Erase_String(name, cord_x + message.Length, cord_y);
                Console.SetCursorPosition(cord_x + message.Length, cord_y);
                name = Console.ReadLine();
            }
            return name;
        }

        // takes  valid integer user input from user
        public static string Take_Integer_Input(string message, int cord_x, int cord_y)
        {

            string integer = "-1";
            while ((ValidationUI.Validate_Int_String(integer) == false))
            {
                ValidationUI.Erase_String(integer, cord_x + message.Length, cord_y);
                Console.SetCursorPosition(cord_x + message.Length, cord_y);
                integer = Console.ReadLine();
            }
            return integer;
        }





    }

}
