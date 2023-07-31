using PACMAN.GL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PACMAN
{
    internal class GhostDL
    {
        public static List<Ghost> ghosts = new List<Ghost>();

        public static void Add_Ghost(Ghost g)
        {
            ghosts.Add(g);
        }
    }
}
