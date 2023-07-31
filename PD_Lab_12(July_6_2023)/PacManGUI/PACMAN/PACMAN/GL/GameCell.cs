using System.Drawing;
using System.Windows.Forms;

namespace PACMAN.GL
{
    internal class GameCell
    {
        // x and y coordinates of gamecell
        public int x;
        public int y;
        // Cell containing GameObject
        public GameObject currentGameObject;
        public GameGrid Grid;
        public PictureBox Picture_Box;
        const int width = 20;
        const int height = 20;

        public GameCell(int x, int y, GameGrid Grid)
        {
            this.x = x;
            this.y = y;
            Picture_Box = new PictureBox();
            Picture_Box.Left = y * width;
            Picture_Box.Top = x * height;
            Picture_Box.Size = new Size(width, height);
            Picture_Box.SizeMode = PictureBoxSizeMode.Zoom;
            Picture_Box.BackColor = Color.Transparent;
            this.Grid = Grid;
        }

        public void SetGameObject(GameObject gameObject)
        {
            currentGameObject = gameObject;
            Picture_Box.Image = gameObject.Image;

        }

        public GameCell Next_Cell(GameDirection direction)
        {
            GameCell nextcell;
            if (direction == GameDirection.UP) nextcell = Grid.Get_Cell(x - 1, y);
            else if (direction == GameDirection.DOWN) nextcell = Grid.Get_Cell(x + 1, y);
            else if (direction == GameDirection.LEFT) nextcell = Grid.Get_Cell(x, y - 1);
            else nextcell = Grid.Get_Cell(x, y + 1);
            if (nextcell.CurrentGameObject.GameObjectType == GameObjectType.WALL) return this;
            return nextcell;
        }

        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }
        public GameObject CurrentGameObject { get => currentGameObject; }
        public PictureBox PictureBox { get => Picture_Box; set => Picture_Box = value; }
    }
}
