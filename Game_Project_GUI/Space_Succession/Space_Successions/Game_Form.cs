using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EZInput;
using Space_Successions.DL;
using Space_Successions.GL;

namespace Space_Successions
{
    public partial class Game_Form : Form
    {
        public static Game_Form? instance = null;
        public Player gamePlayer;
        GameCell PlayerStartCell;
        Alien A1;
        Alien A2;
        Alien A3;
        Alien A4;

        public Game_Form()
        {
            InitializeComponent();
            instance = this;
        }

        private void Game_Form_Load(object sender, EventArgs e)
        {
            GameGrid Grid = new GameGrid("maze.txt", 22, 44);
            Image PlayerImage = Game.Get_Game_Object_Image('P');
            PlayerStartCell = Grid.Get_GameCell(10, 18);
            gamePlayer = new(PlayerImage, PlayerStartCell);

            // Horizontal Alien
            Image HAlien_image = Game.Get_Game_Object_Image('H');
            GameCell AlienHCell = Grid.Get_GameCell(8, 12);
            GameObjectType PreviousObject = AlienHCell.CurrentGameObject.GameObjectType;
            SiriusAlien HAlien = new SiriusAlien(HAlien_image, AlienHCell, GameObjectDirection.Right);
            HAlien.Previous_Object = PreviousObject;
            A1 = HAlien;

            // Vertical Alie
            Image VAlien_image = Game.Get_Game_Object_Image('V');
            GameCell AlienVCell = Grid.Get_GameCell(1, 14);
            PreviousObject = AlienVCell.CurrentGameObject.GameObjectType;
            StrocridAlien VAlien = new StrocridAlien(VAlien_image, AlienVCell, GameObjectDirection.Down);
            VAlien.Previous_Object = PreviousObject;
            A2 = VAlien;

            // Random Alien
            Image RAlien_image = Game.Get_Game_Object_Image('R');
            GameCell AlienRCell = Grid.Get_GameCell(1, 18);
            PreviousObject = AlienRCell.CurrentGameObject.gameObjectType;
            ThrarkreilsAlien RAlien = new ThrarkreilsAlien(RAlien_image, AlienRCell);
            RAlien.Previous_Object = PreviousObject;
            A3 = RAlien;

            // Player Chasing Alien
            Image SAlien_image = Game.Get_Game_Object_Image('S');
            GameCell AlienSCell = Grid.Get_GameCell(6, 34);
            PreviousObject = AlienSCell.CurrentGameObject.GameObjectType;
            PhihrothAlien SAlien = new PhihrothAlien(SAlien_image, AlienSCell, gamePlayer);
            SAlien.Previous_Object = PreviousObject;
            A4 = SAlien;

            // addings Aliens to list
            AliensDL.Add_Alien(HAlien);
            AliensDL.Add_Alien(VAlien);
            AliensDL.Add_Alien(RAlien);
            AliensDL.Add_Alien(SAlien);

            PrintGrid(Grid);
        }

        private void PrintGrid(GameGrid grid)
        {
            for (int x = 0; x < grid.Rows; x++)
            {
                for (int y = 0; y < grid.Columns; y++)
                {
                    GameCell cell = grid.Get_GameCell(x, y);
                    this.Controls.Add(cell.PictureBox);
                }
            }
        }

        private void GameLoop_Tick(object sender, EventArgs e)
        {
            Move_Player();
            Move_Alien(AliensDL.Aliens);
            Show_Pacman_Labels();
            Generate_Bullets();
            Move_Bullets();
            AliensDL.Clear_Dead_Aliens();
            Show_AlienLabels();
            if (End_Game())
            {
                this.Hide();
                EndGame form = new EndGame();
                form.Show();
                GameLoop.Enabled = false;
            }
        }

        public void Show_Pacman_Labels()
        {
            lbl_SplayerScore.Text = gamePlayer.Score.ToString();
            lbl_sPlayerHealth.Text = gamePlayer.Health.ToString();
        }

        public void Move_Player()
        {
            if (Keyboard.IsKeyPressed(Key.LeftArrow))
            {
                gamePlayer.Move(GameObjectDirection.Left);
            }
            if (Keyboard.IsKeyPressed(Key.RightArrow))
            {
                gamePlayer.Move(GameObjectDirection.Right);
            }
            if (Keyboard.IsKeyPressed(Key.UpArrow))
            {
                gamePlayer.Move(GameObjectDirection.Up);
            }
            if (Keyboard.IsKeyPressed(Key.DownArrow))
            {
                gamePlayer.Move(GameObjectDirection.Down);
            }
        }

        public void Generate_Bullets()
        {
            bool isKeyPressed = false;
            GameObjectDirection direction = GameObjectDirection.Right;
            if (Keyboard.IsKeyPressed(Key.W))
            {
                direction = GameObjectDirection.Up;
                isKeyPressed = true;
            }
            if (Keyboard.IsKeyPressed(Key.A))
            {
                direction = GameObjectDirection.Left;
                isKeyPressed = true;
            }
            if (Keyboard.IsKeyPressed(Key.S))
            {
                direction = GameObjectDirection.Down;
                isKeyPressed = true;
            }
            if (Keyboard.IsKeyPressed(Key.D))
            {
                direction = GameObjectDirection.Right;
                isKeyPressed = true;
            }

            if (isKeyPressed == true)
            {
                Image fireImage = Properties.Resources.fire4;
                PlayerFire fire = new PlayerFire(fireImage, gamePlayer.CurrentCell_GS.Next_Cell(direction), direction);
                FireDL.Add_Fire(fire);
            }
        }

        public void Move_Bullets()
        {
            foreach (PlayerFire fire in FireDL.fires)
            {
                GameCell Cell = fire.CurrentCell_GS;
                GameCell nextCell = fire.Move();
                if (nextCell != Cell)
                {
                    fire.CurrentCell_GS = nextCell;
                    Cell.Set_Game_Object(Game.Get_Blank_GameObject());
                }
                if (nextCell == Cell)
                {
                    fire.isActive = false;
                }
            }
            FireDL.Clear_InactiveBullets();
        }
        public void Move_Alien(List<Alien> Aliens)
        {
            foreach (Alien alien in Aliens)
            {
                if (CollisionDetection.IsAlienCollideWithPacman(alien)) gamePlayer.Health--;
                if (CollisionDetection.isCollideWithbullet(alien))
                {
                    alien.Health--;
                    gamePlayer.Score += 10;
                }
                alien.Move();
            }
        }

        public bool End_Game()
        {
            if (gamePlayer.Health == 0 || AliensDL.IsAllAlienDead())
            {
                return true;
            }
            return false;
        }

        public void Show_AlienLabels()
        {
            lbl_SsiriousHealth.Text = A1.Health.ToString();
            lbl_SstrocridHealth.Text = A2.Health.ToString();
            lbl_SthrarkreilsHealth.Text = A3.Health.ToString();
            lbl_SphihrothHealth.Text = A4.Health.ToString();
        }
    }
}
