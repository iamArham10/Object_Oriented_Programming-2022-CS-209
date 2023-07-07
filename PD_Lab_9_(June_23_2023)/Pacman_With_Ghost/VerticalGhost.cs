using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Pacman
{

    public class VerticalGhost : Ghost
    /// <summary>
    /// VerticalGhost is a ghost that moves vertically on console
    /// </summary>
    {
        private GameDirection gd;
        // constructor
        public VerticalGhost(GameObjectType ot, char displaycharacter,GameDirection gd) : base(ot, displaycharacter) 
        {
            
            this.gd = gd;
        }

        // move function of vertical ghost
        public override GameCell Move()
        {
            // returns the cell of game direction if it faces a wall changes direction
            GameCell next_cell = currentcell.nextcell(gd);
            if (next_cell == currentcell) 
            {
                if (gd == GameDirection.UP) { gd = GameDirection.DOWN; }
                else { gd = GameDirection.UP; }
                next_cell = currentcell.nextcell(gd);
            }
            return next_cell;
        }
    }
}
