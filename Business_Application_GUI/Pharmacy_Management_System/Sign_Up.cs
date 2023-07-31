using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_Management_System
{
    public partial class Sign_Up : Form
    {
        public Sign_Up()
        {
            InitializeComponent();
        }

        private void Sign_Up_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_SignUp_Click(object sender, EventArgs e)
        {
            string username = tb_Username.Text;
            string password = tb_Password.Text;
            Employee newEmployee = new(username, password, null);
            User user = newEmployee;
            if (UserDL.Contains_User(user))
            {
                MessageBox.Show("User Already Present With That Name");
                return;
            }
            else
            {
                UserDL.Add_User(newEmployee);
                UserDL.Save_User(newEmployee);
                MessageBox.Show("Signed Up Succesfully");
            }
            return;
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main_Menu.instance.Show();
        }
    }
}
