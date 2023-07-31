using System.Drawing;

namespace PACMAN.GL
{
    internal class PacmanPlayer : GameObject
    {
        public int Score = 0;
        public int Health = 3;
        public PacmanPlayer(Image DisplayImage, GameCell CurrentCell) : base(GameObjectType.PLAYER, DisplayImage)
        {
            this.CurrentCellGS = CurrentCell;
        }
        public GameCell Move(GameDirection direction)
        {
            GameCell currentCell = CurrentCellGS;
            GameCell nextCell = currentCell.Next_Cell(direction);
            if (nextCell.currentGameObject.gameObjectType == GameObjectType.REWARD)
                Score++;
            CurrentCellGS = nextCell;
            if (currentCell != nextCell)
                currentCell.SetGameObject(Game.Get_BlankGameObject());
            return nextCell;
        }
    }
}
