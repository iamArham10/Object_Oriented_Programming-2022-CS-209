    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Application
{
    // contains all functions of validations
    public class ValidationUI
    {

        // to check if entered string is valid
        // valid string will have only character
        public static bool Is_String_Valid(string s)
        {
            // selects each character from specified string s;
            foreach (char c in s)
            {
                // converting that character into ascii value
                int intchar = c;
                // checks if ascii is between 65 and 90 small characters or between 97 and 122 capital case characters
                if ((intchar >= 65 && intchar <= 90) || (intchar >= 97 && intchar <= 122))
                {
                    continue;
                }
                return false;
            }
            return true;

        }

        // prints whitespaces on console of given string length at specified coordinates x and y
        public static void Erase_String(string s, int Cord_X, int Cord_Y)
        {
            Console.SetCursorPosition(Cord_X, Cord_Y);
            foreach (char c in s)
            {
                Console.Write(' ');
            }
        }

        // valides integer if itcan be converted to integer
        public static bool Validate_Int_String(string s)
        {
            foreach (char c in s)
            {
                int intc = c;
                if (s.Length >= 1)
                {
                    if (s[0] == '0')
                    {
                        return false;
                    }
                }
                if (intc >= 48 && intc <= 57)
                {
                    continue;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }

    }
}
