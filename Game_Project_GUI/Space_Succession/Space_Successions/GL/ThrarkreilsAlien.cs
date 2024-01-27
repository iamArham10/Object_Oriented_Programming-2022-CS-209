using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Successions
{
    /// <summary>
    /// Moves Randomly 
    /// </summary>
    public class ThrarkreilsAlien : Alien
    {
        public ThrarkreilsAlien(Image image, GameCell CurrentCell) : base (GameObjectType.Enemy, image)
        {
            this.CurrentCell_GS = CurrentCell;
        }

        public override GameCell Move()
        {
            GameCell currentCell = CurrentCell_GS;
            GameObjectType ot = Previous_Object;
            GameCell nextCell = currentCell;
            while (nextCell == currentCell)
            {
                GameObjectDirection random = Get_Random_Direction();
                nextCell = currentCell.Next_Cell(random);
            }
            Previous_Object = nextCell.CurrentGameObject.GameObjectType;
            CurrentCell_GS = nextCell;

            if (ot == GameObjectType.Reward)
                currentCell.Set_Game_Object(Game.Get_Pallet_GameObject());
            if (ot == GameObjectType.None)
                currentCell.Set_Game_Object(Game.Get_Blank_GameObject());
            return nextCell;
        }
        private GameObjectDirection Get_Random_Direction()
        {
            Random rand = new Random();
            int number = rand.Next(0, 4);
            GameObjectDirection[] direction = { GameObjectDirection.Left, GameObjectDirection.Up, GameObjectDirection.Right, GameObjectDirection.Down};
            return direction[number];
        }
    }
}
