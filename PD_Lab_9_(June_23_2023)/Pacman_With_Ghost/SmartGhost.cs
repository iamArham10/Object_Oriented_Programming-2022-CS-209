using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman
{
    
    public class SmartGhost : Ghost
    ///<summary>
    /// SmartGhost is Ghost that returns the cell that is closest to player object
    /// </summary>
    {
        // pacmancell attributes contains information about PacmanCell
        public GameObject Pacman;
        // constructor
        public SmartGhost(GameObjectType ot, char displaycharacter, GameObject pacman) : base(ot, displaycharacter) {this.Pacman = pacman ; }

        // move function
        public override GameCell Move()
        {
            // getting left right up and down cell of ghost
            GameCell upcell = currentcell.nextcell(GameDirection.UP);
            GameCell downcell = currentcell.nextcell(GameDirection.DOWN);
            GameCell leftcell = currentcell.nextcell(GameDirection.LEFT);
            GameCell rightcell = currentcell.nextcell(GameDirection.RIGHT);
            // gettting thier distances from pacman
            double UpCD = GameGrid.Get_Distance(upcell, Pacman.currentcell);
            double DownCD = GameGrid.Get_Distance(downcell, Pacman.currentcell);
            double LeftCD = GameGrid.Get_Distance(leftcell, Pacman.currentcell);
            double RightCD = GameGrid.Get_Distance(rightcell, Pacman.currentcell);

            // returning the cell whose distance is lesser
            if (RightCD < DownCD && RightCD < LeftCD && RightCD < UpCD) return rightcell;
            else if (DownCD < UpCD && DownCD < LeftCD && DownCD < RightCD) return downcell;
            else if (LeftCD < RightCD && LeftCD < UpCD && LeftCD < DownCD) return leftcell;
            else return upcell;
        }

    }
}
