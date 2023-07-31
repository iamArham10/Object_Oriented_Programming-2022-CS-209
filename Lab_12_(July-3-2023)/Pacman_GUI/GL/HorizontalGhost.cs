using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman
{
    
    public class HorizontalGhost : Ghost
    /// <summary>
    /// Horizontal Ghost is inherited from Ghost 
    /// Horizontal Ghost moves character horizontal
    /// </summary>
    {
        // creating an attributes for direction
        // Creating a contructor of Horizontal Ghost
        GameDirection gd;
        public HorizontalGhost(GameObjectType ot, char displaycharacter, GameDirection gd) : base(ot, displaycharacter) { this.gd = gd; }

        // functions

        public override GameCell Move()
        {
            // returns the next cell of specified position 
            // if it is a wall changes direction and returns that directon object
            GameCell Next_Cell = currentcell.nextcell(gd);
            if (Next_Cell == currentcell)
            {
                if (gd == GameDirection.RIGHT) gd = GameDirection.LEFT;
                else if (gd == GameDirection.LEFT) gd = GameDirection.RIGHT;
                Next_Cell = currentcell.nextcell(gd);
            }
            return Next_Cell;
        }
    }
}
