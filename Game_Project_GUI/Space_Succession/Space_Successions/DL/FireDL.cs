using Space_Successions.GL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Successions.DL
{
    public static class FireDL
    {
        public static List<PlayerFire> fires = new();

        public static void Add_Fire(PlayerFire fire) 
        {
            fires.Add(fire);
        }

        public static void Remove_Fire(PlayerFire fire)
        {
            fires.Remove(fire); 
        }

        public static void Clear_InactiveBullets()
        {
            List<PlayerFire> InactiveFire = new();
            foreach (var bullet in fires)
            {
                if (bullet.isActive == false)
                {
                    InactiveFire.Add(bullet);
                }
            }
            foreach(var bullet in InactiveFire)
            {
                GameCell currentCell = bullet.CurrentCell_GS;
                fires.Remove(bullet);
                currentCell.Set_Game_Object(Game.Get_Blank_GameObject());
            }
        }
    }
}
