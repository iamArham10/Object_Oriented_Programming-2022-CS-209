using System.Drawing;

namespace PACMAN.GL
{
    internal class HorizontalGhost : Ghost
    {
        GameDirection direction;
        public HorizontalGhost(Image image, GameCell CurrentCell, GameDirection direction) : base(GameObjectType.ENEMY, image)
        {
            this.direction = direction;
            this.CurrentCellGS = CurrentCell;
        }
        public override GameCell Move()
        {
            GameCell currentCell = CurrentCellGS;
            GameCell nextCell = currentCell.Next_Cell(direction);
            GameObjectType type;
            CurrentCellGS = nextCell;
            if (nextCell == currentCell)
            {
                if (direction == GameDirection.RIGHT)
                    direction = GameDirection.LEFT;
                else
                    direction = GameDirection.RIGHT;

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
