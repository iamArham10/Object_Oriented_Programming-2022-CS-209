using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman
{
    class Cell
    {
        /// <summary>
        /// Cell Class contains integer x,y coordinate and character value to print on console
        /// </summary>
        
        // attributes
        // character value to print on screen
        private char Value;
        // xy coordinates
        private int row;
        private int column;

        // constructor
        public Cell(char value, int x, int y)
        {
            this.Value = value;
            this.column = x;
            this.row = y;
        }

        // Methods
        // returns Value character
        public char Get_Value() 
        {
            return Value;
        }

        // sets value character
        public void Set_Value(char c)
        {
            this.Value = c;
        }

        // int X and Y attributes returning functions
        public int Get_Row()
        {
            return this.row;
        }
        public int Get_Column()
        {
            return this.column;
        }

        // returns true if Value char is P
        public bool Is_Pacman_Present()
        {
            bool isPresent = false;
            if (this.Value == 'P')
            {
                isPresent = true;
            }
            return isPresent;
        }

        public bool Is_Ghost_Present(char C)
        {
            bool isPresent = false;
            if (this.Value == C)
            {
                isPresent = true;
            }
            return isPresent;
        }
    }
}
