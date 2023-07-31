using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman
{
    class Ghost
    {
        /// Ghost Class contains Ghost Object Printing on cmd

        // attributes
        private int row;
        private int column;
        private string ghost_direction;
        private char ghost_character;
        private float speed;
        private char previous_item;
        private float delta_change;
        private Grid maze_grid;

        // constructor
        public Ghost(int row, int column, char GC, string direction, float speed, char previousitem, Grid mazegrid)
        {
            this.row = row;
            this.column = column;
            this.ghost_character = GC;
            this.speed = speed;
            this.previous_item = previousitem;
            this.maze_grid = mazegrid;
        }

        public void Set_Direction(string ghostdirection)
        {
            this.ghost_direction = ghostdirection;
        }

        public string Get_Direction()
        {
            return ghost_direction;
        }

        public void remove()
        {
            Console.SetCursorPosition(column, row);
            Console.Write(previous_item);
        }

        public void draw()
        {
            Console.SetCursorPosition(column, row);
            Console.Write(ghost_character);
        }

        public char Get_Character()
        {
            return ghost_character;
        }

        public void Set_Delta_Zero()
        {
            delta_change = 0;
        }

        public float Get_Delta()
        {
            return delta_change;
        }

        public void Change_Delta()
        {
            delta_change += speed;
        }

        public void move()
        {

        }

        public void Move_Horizontal()
        {
                    }
        


    }
}
