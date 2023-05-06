using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shooting_Game
{
    class spaceship
    {
        public int position_x;
        public int position_y;
        public char[,] structure = new char[3, 2];
        public int health;
        public spaceship(int x, int y, int health)
        {
            position_x = x;
            position_y = y;
            this.health = health;
        }

        public void Change_X_cord(int x)
        {
            position_x += x;
        }

        public void Change_Y_Cord(int y)
        {
            position_y += y;
        }

        public void Create_Spaceship(int x, int y)
        {
            position_x = x;
            position_y = y;
            char left_wall = '(';
            char right_gun = '>';
            char circle = ')';
            char left_gun = '<';
            structure[0, 0] = left_wall;
            structure[1, 0] = left_gun;
            structure[2, 0] = left_wall;
            structure[0, 1] = circle;
            structure[1, 1] = right_gun;
            structure[2, 1] = circle;
        }

    }
}
