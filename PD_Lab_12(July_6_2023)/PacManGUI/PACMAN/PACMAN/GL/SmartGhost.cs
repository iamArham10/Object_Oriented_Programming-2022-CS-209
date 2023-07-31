using System.Drawing;

namespace PACMAN.GL
{
    internal class SmartGhost : Ghost
    {
        GameObject Pacman;
        public SmartGhost(Image image, GameCell CurrentCell, GameObject p) : base(GameObjectType.ENEMY, image)
        {
            Pacman = p;
            this.CurrentCellGS = CurrentCell;
        }
        public override GameCell Move()
        {
            GameCell returnCell;
            GameCell currentCell = CurrentCellGS;
            GameCell upCell = currentCell.Next_Cell(GameDirection.UP);
            GameCell downCell = currentCell.Next_Cell(GameDirection.DOWN);
            GameCell leftCell = currentCell.Next_Cell(GameDirection.LEFT);
            GameCell rightCell = currentCell.Next_Cell(GameDirection.RIGHT);

            double UpCD = GameGrid.Get_Distance(upCell, Pacman.currentCell);
            double DownCD = GameGrid.Get_Distance(downCell, Pacman.currentCell);
            double LeftCD = GameGrid.Get_Distance(leftCell, Pacman.currentCell);
            double RightCD = GameGrid.Get_Distance(rightCell, Pacman.currentCell);

            if (RightCD < DownCD && RightCD < LeftCD && RightCD < UpCD)
            {
                returnCell = rightCell;
            }
            else if (DownCD < UpCD && DownCD < LeftCD && DownCD < RightCD)
            {
                returnCell = downCell;
            }
            else if (LeftCD < RightCD && LeftCD < UpCD && LeftCD < DownCD)
            {
                returnCell = leftCell;
            }
            else
            {
                returnCell = upCell;
            }
            GameObjectType type = returnCell.CurrentGameObject.GameObjectType;
            CurrentCellGS = returnCell;
            if (type == GameObjectType.REWARD)
                currentCell.SetGameObject(Game.Get_RewardGameObject());
            else if (type == GameObjectType.NONE)
                currentCell.SetGameObject(Game.Get_BlankGameObject());
            return returnCell;
        }
    }
}
