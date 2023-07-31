using Space_Successions;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Successions
{
    public class GameCell
    {
        private int x;
        private int y;
        private GameGrid grid;
        PictureBox pictureBox;
        private GameObject currentGameObject = null;
        const int width = 36;
        const int height = 36;

        public GameCell(int x, int y, GameGrid grid)
        {
            this.x = x;
            this.y = y;
            this.grid = grid;
            pictureBox = new PictureBox();
            pictureBox.Left = y * width;
            pictureBox.Top = x * height;
            pictureBox.Size = new Size(width, height);
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.BackColor = Color.Transparent;
        }

        public GameCell Next_Cell(GameObjectDirection gObjectDirection)
        {
            GameCell nextCell;
            if (gObjectDirection == GameObjectDirection.Right) nextCell = Grid.Get_GameCell(x, y + 1);
            else if (gObjectDirection == GameObjectDirection.Left) nextCell = Grid.Get_GameCell(x, y - 1);
            else if (gObjectDirection == GameObjectDirection.Up) nextCell = Grid.Get_GameCell(x - 1,y);
            else nextCell = Grid.Get_GameCell(x + 1,y);
            if (nextCell.CurrentGameObject.gameObjectType != GameObjectType.Wall) return nextCell;
            return this;
        }

        public void Set_Game_Object(GameObject gameObject)
        {
            currentGameObject = gameObject;
            pictureBox.Image = gameObject.Image;
        }

        public GameGrid Grid { get => grid; }
        public int X { get { return x; } set { this.x = value; } }
        public int Y { get { return y; } set { this.y = value; } }
        public GameObject CurrentGameObject { get { return currentGameObject; } }
        public PictureBox PictureBox { get { return pictureBox; } set => PictureBox = value; }

        public GameGrid Contains
        {
            get => default;
            set
            {
            }
        }

        public GameObject Has
        {
            get => default;
            set
            {
            }
        }
    }
}
