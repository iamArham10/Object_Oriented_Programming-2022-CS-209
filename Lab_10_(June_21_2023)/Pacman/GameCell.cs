using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman
{
    public class GameCell
    /// <summary>
    /// Game Cell is object containing x and y coordinates and game object 
    /// </summary>
    {
        // attributes
        // x and y coordinates
        public int x;
        public int y;
        // Current GameObject
        public GameObject current_game_object;
        // Grid object which contains cell
        GameGrid gamegrid;

        // contructor
        public GameCell(int x, int y, GameGrid grid)
        {
            this.x = x;
            this.y = y;
            this.gamegrid = grid;
        }

        // returns the left right up or down cell that is specified of this cell
        public GameCell nextcell(GameDirection gd)
        {
            GameCell reqcell;
            if (gd == GameDirection.UP) reqcell = gamegrid.getCell(this.x - 1, this.y);
            else if (gd == GameDirection.DOWN) reqcell = gamegrid.getCell(this.x + 1, this.y);
            else if (gd == GameDirection.LEFT) reqcell = gamegrid.getCell(this.x, this.y - 1);
            else reqcell = gamegrid.getCell(this.x, this.y + 1);
            if (reqcell.current_game_object.gameobjecttype == GameObjectType.WALL)
            {
                return null;
            }
            return reqcell;
        }


    }
}
