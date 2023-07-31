using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_Management_System
{
    public partial class Main_Menu : Form
    {
        public static Main_Menu instance;
        public static User current_user = null;
        public Main_Menu()
        {
            instance = this;
            InitializeComponent();
        }
        private void Main_Menu_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_signin_Click(object sender, EventArgs e)
        {
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_instruction_MouseHover(object sender, EventArgs e)
        {
        }

        private void btn_instruction_MouseLeave(object sender, EventArgs e)
        {
        }

        private void btn_instruction_MouseMove(object sender, MouseEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btn_forgetpassword_MouseMove(object sender, MouseEventArgs e)
        {
        }

        private void btn_forgetpassword_MouseLeave(object sender, EventArgs e)
        {
        }

        private void btn_forgetpassword_MouseHover(object sender, EventArgs e)
        {
        }

        private void btn_SignUp_Click(object sender, EventArgs e)
        {
        }

        private void btn_signIn_MouseMove(object sender, MouseEventArgs e)
        {
            toolTip1.SetToolTip(btn_signIn, "Sign In");
        }

        private void btn_SignUp_Click_1(object sender, EventArgs e)
        {
            Sign_Up frm_Sign_Up = new();
            this.Hide();
            frm_Sign_Up.ShowDialog();
        }

        private void btn_signIn_Click_1(object sender, EventArgs e)
        {
            User user;
            if ((user = UserDL.Varify_User(new User(tb_username.Text, tb_password.Text))) != null)
            {
                Main_Menu.current_user = user;
                tb_username.Text = null;
                tb_password.Text = null;
                this.Hide();
                User_Options_Menu uom = new User_Options_Menu();
                uom.Show();
            }
            else
            {
                MessageBox.Show("User not Present with that Credentials");
            }
        }
    }

}
