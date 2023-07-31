using Space_Successions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Successions
{
    public class Player : GameObject
    {
        public int Score = 0;
        public int Health = 10;

        public Player(Image DisplayImage, GameCell CurrentCell) : base(GameObjectType.Player, DisplayImage)
        {
            this.CurrentCell_GS = CurrentCell;
        }
        public GameCell Move(GameObjectDirection direction)
        {
            GameCell currentCell = CurrentCell_GS;
            GameCell nextCell = currentCell.Next_Cell(direction);
            GameCell returnCell = nextCell;
            if (nextCell.CurrentGameObject.gameObjectType == GameObjectType.Reward)
                Score++;
            CurrentCell_GS = nextCell;
            if (currentCell != nextCell)
                currentCell.Set_Game_Object(Game.Get_Blank_GameObject());
            return returnCell;
        }
    }
}
