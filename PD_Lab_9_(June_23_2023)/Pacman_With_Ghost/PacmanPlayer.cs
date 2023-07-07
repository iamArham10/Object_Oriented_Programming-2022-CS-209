using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman
{
    public class PacmanPlayer : GameObject
    {
        // contructor
        public PacmanPlayer( char displaycharacter, GameCell currentcell) : base(GameObjectType.PLAYER, displaycharacter)
        {
            this.currentcell = currentcell;
        }

        // functions
        // move function
        public GameCell move(GameDirection gd)
        {
            GameCell cell = currentcell.nextcell(gd);
            if (cell != null)
            {
                return cell;
            }
            return null;

        }

    }
}
