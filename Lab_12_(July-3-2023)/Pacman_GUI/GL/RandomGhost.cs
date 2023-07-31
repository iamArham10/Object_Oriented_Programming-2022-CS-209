using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman
///<summary>
/// RandomGhost moves randomly to any cell
/// </summary>
{
    public class RandomGhost : Ghost
    {
        // contructory
        public RandomGhost(GameObjectType ot, char displaycharacter) : base(ot, displaycharacter) { }

        // functions
        // move function returns any random cell that is not null
        public override GameCell Move()
        {
            GameCell nextcell = null;
            while (nextcell == null)
            {
                GameDirection random = Get_Random_Direction();
                nextcell = currentcell.nextcell(random);
            }
            return nextcell;
        }

        // returns a random move direction 
        private GameDirection Get_Random_Direction()
        {
            GameDirection randomdirection;
            Random rand = new Random();
            int number = rand.Next(1, 5);
            if (number == 1) randomdirection = GameDirection.UP;
            else if (number == 2) randomdirection = GameDirection.DOWN;
            else if (number == 3) randomdirection = GameDirection.LEFT;
            else randomdirection = GameDirection.RIGHT;
            return randomdirection;
        }

    }
}
