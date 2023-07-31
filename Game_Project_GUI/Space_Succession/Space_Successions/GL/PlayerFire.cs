using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Successions.GL
{
    public class PlayerFire : GameObject,Fire
    {
        public bool isActive;
        GameObjectDirection direction;
        public PlayerFire(Image image, GameCell currentCell, GameObjectDirection direction) : base(GameObjectType.Bullet, image)
        {
            this.direction = direction;
            this.currentCell = currentCell;
            isActive = true;
        }

        public GameCell Move()
        {
            GameCell currentCell = this.CurrentCell_GS;
            GameCell nextCell = currentCell.Next_Cell(direction);
            return nextCell;
        }
    }
}
