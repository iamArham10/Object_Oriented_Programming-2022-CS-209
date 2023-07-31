using EZInput;
using PACMAN.GL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace PACMAN
{
    public partial class MainGame : Form
    {
        PacmanPlayer pacman;
        GameCell startCell;
/*        List<Ghost> ghosts = new List<Ghost>();*/
        public MainGame()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            GameGrid grid = new GameGrid("maze.txt", 17, 50);

            Image pacManImage = Game.Get_Game_Object_Image('P');
            startCell = grid.Get_Cell(10, 18);
            pacman = new PacmanPlayer(pacManImage, startCell);

            Image ghostHImage = Game.Get_Game_Object_Image('H');
            GameCell ghostHCell = grid.Get_Cell(9, 3);
            HorizontalGhost ghostH = new HorizontalGhost(ghostHImage, ghostHCell, GameDirection.RIGHT);

            Image ghostVImage = Game.Get_Game_Object_Image('V');
            GameCell ghostVCell = grid.Get_Cell(2, 17);
            VerticalGhost ghostV = new VerticalGhost(ghostVImage, ghostVCell, GameDirection.DOWN);

            Image ghostSImage = Game.Get_Game_Object_Image('S');
            GameCell ghostSCell = grid.Get_Cell(5, 5);
            SmartGhost ghostS = new SmartGhost(ghostSImage, ghostSCell, pacman);

            Image ghostRImage = Game.Get_Game_Object_Image('R');
            GameCell ghostRCell = grid.Get_Cell(10, 5);
            RandomGhost ghostR = new RandomGhost(ghostRImage, ghostRCell);

            GhostDL.Add_Ghost(ghostH);
            GhostDL.Add_Ghost(ghostV);
            GhostDL.Add_Ghost(ghostR);
            GhostDL.Add_Ghost(ghostS);
            PrintMaze(grid);

        }
        private void PrintMaze(GameGrid grid)
        {
            for (int x = 0; x < grid.Rows; x++)
            {
                for (int y = 0; y < grid.Columns; y++)
                {
                    GameCell cell = grid.Get_Cell(x, y);
                    Controls.Add(cell.PictureBox);
                }
            }
        }
        private void GameLoop_Tick(object sender, EventArgs e)
        {
            ScoreBox.Text = pacman.Score.ToString();
            LivesBox.Text = pacman.Health.ToString();
            if (Keyboard.IsKeyPressed(Key.LeftArrow))
            {
                pacman.Move(GameDirection.LEFT);
            }
            if (Keyboard.IsKeyPressed(Key.RightArrow))
            {
                pacman.Move(GameDirection.RIGHT);
            }
            if (Keyboard.IsKeyPressed(Key.UpArrow))
            {
                pacman.Move(GameDirection.UP);
            }
            if (Keyboard.IsKeyPressed(Key.DownArrow))
            {
                pacman.Move(GameDirection.DOWN);
            }
            Move_Ghost();
        }

        private void Move_Ghost()
        {
            foreach (Ghost ghost in GhostDL.ghosts)
            {
                ghost.Move();
                GameRunning(ghost);
            }
        }
        private void GameRunning(Ghost ghost)
        {
            if (CollisionClass.Check_Collision_Objects(pacman, ghost))
            {
                if (pacman.Health == 0)
                {
                    GameLoop.Enabled = false;
                    GameOverLabel.Visible = true;
                }
                else
                {
                    pacman.Health--;
                    GameLoop.Enabled = false;
                    pacman.currentCell = startCell;
                    MessageBox.Show("Collided" + " " +pacman.Health);
                    GameLoop.Enabled = true;
                }
            }
        }

        private void restartButton_Click(object sender, EventArgs e)
        {
            GameLoop.Enabled = false;
            Application.Restart();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void ScoreLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
