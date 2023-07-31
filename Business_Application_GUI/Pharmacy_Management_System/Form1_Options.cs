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
    public partial class Form1_Options : Form
    {
        public Form1_Options()
        {
            InitializeComponent();
        }

        private void button3_viewProduct_Click(object sender, EventArgs e)
        {
            if (Main_Menu.current_user.Is_Function_Present(BL.Functions.VIEW))
            {
                User_Options_Menu.instance.Show_View_Form();
            }
            else MessageBox.Show("Feature Not Available");
        }

        private void button2_addProduct_Click(object sender, EventArgs e)
        {
            if (Main_Menu.current_user.Is_Function_Present(BL.Functions.ADD))
            {
                User_Options_Menu.instance.Show_Add_Form();
            }
            else MessageBox.Show("Feature Not Available");
        }

        private void button6_removeProduct_Click(object sender, EventArgs e)
        {
            if (Main_Menu.current_user.Is_Function_Present(BL.Functions.REMOVE))
            {
                User_Options_Menu.instance.Show_Remove_Form();
            }
            else MessageBox.Show("Feature Not Available");
        }

        private void button4_changePrice_Click(object sender, EventArgs e)
        {
            if (Main_Menu.current_user.Is_Function_Present(BL.Functions.CHANGE))
            {
                User_Options_Menu.instance.Show_Price_Change_Form();
            }
            else MessageBox.Show("Feature Not Available");
        }

        private void button7_addStock_Click(object sender, EventArgs e)
        {
            if (Main_Menu.current_user.Is_Function_Present(BL.Functions.ADD))
            {
                User_Options_Menu.instance.Show_Add_Stock_Form();
            }
            else MessageBox.Show("Feature Not Avalable");
        }

        private void button1_takeOrder_Click(object sender, EventArgs e)
        {
            if (Main_Menu.current_user.Is_Function_Present(BL.Functions.ORDER))
            {
                User_Options_Menu.instance.Show_Take_Order_Form();
            }
            else MessageBox.Show("Feature Not Available");
        }
    }
}
