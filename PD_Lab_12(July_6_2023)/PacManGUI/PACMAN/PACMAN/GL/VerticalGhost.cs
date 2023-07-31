using System.Drawing;

namespace PACMAN.GL
{
    internal class VerticalGhost : Ghost
    {
        GameDirection direction;
        public VerticalGhost(Image image, GameCell CurentCell, GameDirection direction) : base(GameObjectType.ENEMY, image)
        {
            this.direction = direction;
            this.CurrentCellGS = CurentCell;
        }
        public override GameCell Move()
        {
            GameCell currentCell = CurrentCellGS;
            GameCell nextCell = currentCell.Next_Cell(direction);
            GameObjectType type = nextCell.CurrentGameObject.GameObjectType;
            CurrentCellGS = nextCell;
            if (nextCell == currentCell)
            {
                if (direction == GameDirection.UP)
                    direction = GameDirection.DOWN;
                else
                    direction = GameDirection.UP;

                nextCell = currentCell.Next_Cell(direction);
                CurrentCellGS = nextCell;
            }
            type = nextCell.CurrentGameObject.GameObjectType;
            if (type == GameObjectType.REWARD)
                currentCell.SetGameObject(Game.Get_RewardGameObject());
            else if (type == GameObjectType.NONE)
                currentCell.SetGameObject(Game.Get_BlankGameObject());

            return nextCell;
        }
    }
}
