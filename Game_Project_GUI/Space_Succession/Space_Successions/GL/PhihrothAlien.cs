using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Successions.GL
{
    /// <summary>
    /// Alien that chases Player
    /// </summary>
    public class PhihrothAlien : Alien
    {
        GameObject Player;
        int moveSpeed = 0;
        public PhihrothAlien(Image image, GameCell CurrentCell, GameObject p) : base(GameObjectType.Enemy, image)
        {
            Player = p;
            this.CurrentCell_GS = CurrentCell;
        }
        public override GameCell Move()
        {
            moveSpeed++;
            if (moveSpeed < 3)
            {
                return CurrentCell_GS;
            }

            GameCell returnCell;
            GameCell currentCell = CurrentCell_GS;
            GameObjectType ot;
            GameCell upCell = currentCell.Next_Cell(GameObjectDirection.Up);
            GameCell downCell = currentCell.Next_Cell(GameObjectDirection.Down);
            GameCell leftCell = currentCell.Next_Cell(GameObjectDirection.Left);
            GameCell rightCell = currentCell.Next_Cell(GameObjectDirection.Right);

            double UpCD = GameGrid.Get_Distance_Between_Cells(upCell, Player.currentCell);
            double DownCD = GameGrid.Get_Distance_Between_Cells(downCell, Player.currentCell);
            double LeftCD = GameGrid.Get_Distance_Between_Cells(leftCell, Player.currentCell);
            double RightCD = GameGrid.Get_Distance_Between_Cells(rightCell, Player.currentCell);

            returnCell = rightCell;
            double shortest = RightCD;
            if (shortest > LeftCD)
            { returnCell = leftCell; shortest = LeftCD; }
            if (shortest > UpCD) { returnCell = upCell; shortest = UpCD; }
            if (shortest > DownCD) { returnCell = downCell; }

            if (Previous_Object == GameObjectType.None)
            {
                currentCell.Set_Game_Object(Game.Get_Blank_GameObject());
            }
            else if (Previous_Object == GameObjectType.Reward)
            {
                currentCell.Set_Game_Object(Game.Get_Pallet_GameObject());
            }

            if (returnCell.CurrentGameObject.gameObjectType == GameObjectType.None || returnCell.CurrentGameObject.gameObjectType == GameObjectType.Reward)
            {
                ot = returnCell.CurrentGameObject.gameObjectType;
                Previous_Object = ot;
            }
            CurrentCell_GS = returnCell;
            moveSpeed = 0;
            return returnCell;
        }
    }
}
