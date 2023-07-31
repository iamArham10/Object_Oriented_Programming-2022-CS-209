using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Successions
{
    /// <summary>
    /// Sirious Alien is a game object that moves in horizontal direction
    /// </summary>
    public class SiriusAlien : Alien
    {
        GameObjectDirection Direction;
        public SiriusAlien(Image image, GameCell currentcell, GameObjectDirection direction) : base (GameObjectType.Enemy, image)
        {
            this.Direction = direction;
            this.CurrentCell_GS = currentcell;
        }

        public override GameCell Move()
        {
            GameCell currentCell = CurrentCell_GS;
            GameCell nextCell = currentCell.Next_Cell(Direction);
            GameObjectType ot;
            ot = nextCell.CurrentGameObject.GameObjectType;
            CurrentCell_GS = nextCell;
            if (nextCell == currentCell)
            {
                if (Direction == GameObjectDirection.Right)
                    Direction = GameObjectDirection.Left;
                else
                    Direction = GameObjectDirection.Right;

                nextCell = currentCell.Next_Cell(Direction);
                if (nextCell.CurrentGameObject.gameObjectType == GameObjectType.None || nextCell.CurrentGameObject.gameObjectType == GameObjectType.Reward)
                {
                    ot = nextCell.CurrentGameObject.GameObjectType;
                }
                CurrentCell_GS = nextCell;
            }

            if (Previous_Object == GameObjectType.Reward)
            {
                currentCell.Set_Game_Object(Game.Get_Pallet_GameObject());
            }
            if (Previous_Object == GameObjectType.None)
            {
                currentCell.Set_Game_Object(Game.Get_Blank_GameObject());
            }
            Previous_Object = ot;
            return nextCell;
        }
    }
}
