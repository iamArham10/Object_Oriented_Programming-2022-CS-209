using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shooting_Game
{
    class bullet
    {
        public int position_x;
        public int position_y;
        public bool Is_Active;

        public bullet(bullet oldbullet)
        {
            position_x = oldbullet.position_x;
            position_y = oldbullet.position_y;
            Is_Active = oldbullet.Is_Active;
        }
        public bullet(int x, int y)
        {
            position_x = x;
            position_y = y;
            Is_Active = true;
        }
        public bullet() { }

        public void Make_Bullet_InActive()
        {
            Is_Active = false;
        }

        public void Change_X_cord(int x)
        {
            position_x += x;
        }

        public void Change_Y_Cord(int y)
        {
            position_y += y;
        }

        public bool Is_Bullet_Active()
        {
            bool isactive = false;
            if (this.Is_Active == true)
            {
                isactive = true;
            }
            return isactive;
        }
    }
}
