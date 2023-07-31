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
    public partial class User_Options_Menu : Form
    {
        // stores the instance of this form
        public static User_Options_Menu instance;
        // all forms
        public Form1_Options frm_options = new();
        public User_Options_Menu()
        {
            InitializeComponent();
            instance = this;
            label2_userName.Text = Main_Menu.current_user.Get_UserName();
            label4_userPassword.Text = Main_Menu.current_user.Get_UserPassword();
            frm_options.TopLevel = false;
            frm_options.Dock = DockStyle.Fill;
            panel4_formPanel.Controls.Add(frm_options);
            frm_options.BringToFront();
            frm_options.Show();
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void tlp_4_UserProfile_Paint(object sender, PaintEventArgs e)
        {
        }

        private void tlp_user_info_Paint(object sender, PaintEventArgs e)
        {
        }

        private void lbl_Username_Click(object sender, EventArgs e)
        {
        }

        private void lbl_userverify_Click(object sender, EventArgs e)
        {
        }

        private void lbl_useremail_Click(object sender, EventArgs e)
        {
        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void tableLayoutPanel5_Paint(object sender, PaintEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {
        }

        private void pb_userprofile_Click(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
        }

        private void button5_Click(object sender, EventArgs e)
        {
        }

        private void button5_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button1_back_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to exit?", "Log Out", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
                Main_Menu.instance.Show();
            }
        }
        public void Show_View_Form()
        {
            Form2_ViewProduct viewProduct = new Form2_ViewProduct();
            if (!panel4_formPanel.Contains(viewProduct))
            {
                viewProduct.Dock = DockStyle.Fill;
                viewProduct.TopLevel = false;
                panel4_formPanel.Controls.Add(viewProduct);
                viewProduct.BringToFront();
                viewProduct.Show();
            }
            else
            {
                viewProduct.BringToFront();
            }
        }

        public void Show_Add_Form()
        {
            Form3_AddProduct addProduct = new Form3_AddProduct();
            if (!panel4_formPanel.Contains(addProduct))
            {
                addProduct.Dock = DockStyle.Fill;
                addProduct.TopLevel = false;
                panel4_formPanel.Controls.Add(addProduct);
                addProduct.BringToFront();
                addProduct.Show();
            }
            else
            {
                addProduct.BringToFront();
            }
        }

        public void Show_Remove_Form()
        {
            Form4_RemoveProduct removeProduct = new();
            if (panel4_formPanel.Contains(removeProduct) == false)
            {
                removeProduct.Dock = DockStyle.Fill;
                removeProduct.TopLevel = false;
                panel4_formPanel.Controls.Add(removeProduct);
                removeProduct.BringToFront();
                removeProduct.Show();
            }
            else
            {
                removeProduct.BringToFront();
            }
        }

        public void Show_Price_Change_Form()
        {
            Form5_ChangePrice changePrice = new();
            if (panel4_formPanel.Contains(changePrice) == false)
            {
                changePrice.Dock = DockStyle.Fill;
                changePrice.TopLevel = false;
                panel4_formPanel.Controls.Add(changePrice);
                changePrice.BringToFront();
                changePrice.Show();
            }
            else
            {
                changePrice.BringToFront();
            }
        }

        public void Show_Add_Stock_Form()
        {
            Form6_ChangeStock changeStock = new();
            if (panel4_formPanel.Contains(changeStock) == false)
            {
                changeStock.Dock = DockStyle.Fill;
                changeStock.TopLevel = false;
                panel4_formPanel.Controls.Add(changeStock);
                changeStock.BringToFront();
                changeStock.Show();
            }
            else
            {
                changeStock.BringToFront();
            }
        }

        public void Show_Take_Order_Form()
        {
            Form7_TakeOrder frmOrder = new();
            if (panel4_formPanel.Controls.Contains(frmOrder)) panel4_formPanel.Controls.Remove(frmOrder);
            frmOrder.Dock = DockStyle.Fill;
            frmOrder.TopLevel = false;
            panel4_formPanel.Controls.Add(frmOrder);
            frmOrder.BringToFront();
            frmOrder.Show();
        }
    }
}
