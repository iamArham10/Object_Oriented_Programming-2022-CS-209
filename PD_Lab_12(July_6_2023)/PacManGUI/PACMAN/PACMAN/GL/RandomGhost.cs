using System;
using System.Drawing;

namespace PACMAN.GL
{
    internal class RandomGhost : Ghost
    {
        public RandomGhost(Image image, GameCell CurrentCell) : base(GameObjectType.ENEMY, image)
        {
            this.CurrentCellGS = CurrentCell;
        }

        public override GameCell Move()
        {
            GameCell currentCell = CurrentCellGS;
            GameCell nextCell = null;
            GameObjectType type = GameObjectType.NONE;
            while (nextCell == null)
            {
                GameDirection random = Get_Random_Direction();
                nextCell = currentCell.Next_Cell(random);
                type = nextCell.CurrentGameObject.GameObjectType;
                CurrentCellGS = nextCell;
                currentCell.SetGameObject(Game.Get_BlankGameObject());
            }
            if (type == GameObjectType.REWARD)
                currentCell.SetGameObject(Game.Get_RewardGameObject());
            else if (type == GameObjectType.NONE)
                currentCell.SetGameObject(Game.Get_BlankGameObject());
            return nextCell;
        }
        private GameDirection Get_Random_Direction()
        {
            GameDirection randomDirection;
            Random rand = new Random();
            int number = rand.Next(1, 5);
            if (number == 1)
                randomDirection = GameDirection.UP;
            else if (number == 2)
                randomDirection = GameDirection.DOWN;
            else if (number == 3)
                randomDirection = GameDirection.LEFT;
            else
                randomDirection = GameDirection.RIGHT;

            return randomDirection;
        }
    }
}
