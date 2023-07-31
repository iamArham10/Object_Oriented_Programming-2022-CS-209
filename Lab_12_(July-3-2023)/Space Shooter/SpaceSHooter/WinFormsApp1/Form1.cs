
using EZInput;
namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        PictureBox enemyBlack;
        PictureBox enemyBlue;
        Random rand = new Random();
        List<PictureBox> PlayerFires = new List<PictureBox>();
        List<PictureBox> EnemyFires = new List<PictureBox>();
        int EnemyBlackLastTimeToFire = 1;
        int EnemyBlueLastTimeToFire = 0;
        public Form1()
        {
            InitializeComponent();

        }
    /*    private void Form1_Load_1(object sender, EventArgs e)
        {
            // creating two enemies
            enemyBlack = Create_Enemy(WinFormsApp1.Properties.Resources.monster);
            enemyBlue = Create_Enemy(WinFormsApp1.Properties.Resources.monster);
            this.Controls.Add(enemyBlack);
            this.Controls.Add(enemyBlue);
        }
*/
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // checks if right key is pressed
            if (Keyboard.IsKeyPressed(Key.RightArrow))
            {
                // moves pb player to right or moves away from left 25 pixels
                pbPlayerShip.Left += 25;
            }
            if (Keyboard.IsKeyPressed(Key.LeftArrow))
            {
                // moves player to left by reducing left distance
                pbPlayerShip.Left -= 25;
            }
            // to fire a bullet
            if (Keyboard.IsKeyPressed(Key.Space))
            {
                // creating a image object that contains image of fire to show 
                Image fireImage = WinFormsApp1.Properties.Resources.fire;
                // creating a player fire picture box from create fire function
                PictureBox pbplayerfire = Create_Fire(fireImage, pbPlayerShip);
                // adding player fire to idk what that is
                PlayerFires.Add(pbplayerfire);
                this.Controls.Add(pbplayerfire);
            }

            // to move bullet we're decrementing the anchor position from top
            foreach (PictureBox bullet in PlayerFires)
            {
                bullet.Top = bullet.Top - 20;
            }

            // to remove the fires that are out of display location
            for (int idx = 0; idx < PlayerFires.Count; idx++)
            {
                if (PlayerFires[idx].Bottom < 0) PlayerFires.Remove(PlayerFires[idx]);
            }

            EnemyBlackLastTimeToFire++;
            EnemyBlueLastTimeToFire++;
            if (EnemyBlueLastTimeToFire > EnemyBlackLastTimeToFire)
            {
                Image fireImage = WinFormsApp1.Properties.Resources.fire;
                PictureBox pbFire = Create_Fire(fireImage, enemyBlue);
                EnemyFires.Add(pbFire);
                this.Controls.Add(pbFire);
                EnemyBlueLastTimeToFire = 0;

            }
            if (EnemyBlackLastTimeToFire > EnemyBlueLastTimeToFire)
            {
                Image fireImage = WinFormsApp1.Properties.Resources.fire;
                PictureBox pbFire = Create_Fire(fireImage, enemyBlack);
                EnemyFires.Add(pbFire);
                this.Controls.Add(pbFire);
                EnemyBlackLastTimeToFire = 0;
            }
            // to remove fires outside from the width of the screen
            for (int idx = 0; idx < EnemyFires.Count; idx++)
            {
                if (EnemyFires[idx].Top > this.Height)
                {
                    EnemyFires.Remove(EnemyFires[idx]);
                }
            }

        }
        // to create multiple enemy
        private PictureBox Create_Enemy(Image img)
        {
            // creating a picture box of enemy
            PictureBox pbEnemy = new PictureBox();
            // creating and setting left and top position of enemey 
            Random rand = new Random();
            int Left = rand.Next(30, this.Width);
            int Top = rand.Next(5, this.Height + 20);
            pbEnemy.Left = Left;
            pbEnemy.Top = Top;
            // setting enemey picture box image height and width
            pbEnemy.Height = img.Height;
            pbEnemy.Width = img.Width;
            // sets the background of image transparent
            pbEnemy.BackColor = Color.Transparent;
            // setting picturebox image to image specified in argument
            pbEnemy.Image = img;
            return pbEnemy;
        }

        // a function to move enemy
        // takes picture box and direction to move
        private void Move_Enemey(PictureBox enemy, ref string EnemyDirection)
        {
            // moves the enemy picture to left and right
            if (EnemyDirection == "MovingRight") enemy.Left += 10;
            if (EnemyDirection == "MovingLeft") enemy.Left -= 10;
            // changes enemy direction to left if it's position increases than form size
            if ((enemy.Left + enemy.Width) > this.Width) EnemyDirection = "MovingLeft";
            // changes enemy direction to right if it's position is less than 2 from form
            if (enemy.Left <= 2) EnemyDirection = "MovingRight";
        }

        // function for creating a fire from source
        private PictureBox Create_Fire(Image fireimage, PictureBox Source)
        {
            // new picture box of fire
            PictureBox pbFire = new PictureBox();
            // setting image given in argument to picture box pb fire
            pbFire.Image = fireimage;
            // sets width and height of picture box to the provided image respectively
            pbFire.Width = fireimage.Width;
            pbFire.Height = fireimage.Height;
            pbFire.BackColor = Color.Transparent;
            System.Drawing.Point firelocation;
            firelocation = new System.Drawing.Point();
            firelocation.X = Source.Left + (Source.Width / 2) - 5;
            firelocation.Y = Source.Top;
            pbFire.Location = firelocation;
            return pbFire;
        }

        
    }


}

