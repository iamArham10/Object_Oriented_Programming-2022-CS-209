using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SignInSignUp
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();

            // loading user data from file
            string path = "data.txt";
            if (UserDL.Read_Data_From_File(path))
            {
                MessageBox.Show("Data Loaded From File");
            }
            else
            {
                MessageBox.Show("Data Not Loaded");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form frm_SignIn = new SignIn();
            frm_SignIn.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form frm_signUp = new SignUp();
            frm_signUp.ShowDialog();
        }
    }
}
