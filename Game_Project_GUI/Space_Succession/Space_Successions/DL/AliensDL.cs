using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Successions
{
    public static class AliensDL
    {
        public static List<Alien> Aliens = new List<Alien>();

        public static void Add_Alien(Alien Alien)
        {
            if (!Aliens.Contains(Alien))
            {
                Aliens.Add(Alien);
            }
        }

        public static bool IsAllAlienDead()
        {
            if (Aliens.Count == 0) 
            {
                return true;
            }
            return false;
        }

        public static void Clear_Dead_Aliens()
        {
            List<Alien> DeadAlines = new();
            foreach(Alien Alien in Aliens)
            {
                if (Alien.Health == 0)
                {
                    DeadAlines.Add(Alien);
                }
            }
            foreach(Alien deadalien in DeadAlines)
            {
                Aliens.Remove(deadalien);
            }
        }
    }
}
