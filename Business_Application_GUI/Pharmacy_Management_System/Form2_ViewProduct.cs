using Pharmacy_Management_System.DL;
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
    public partial class Form2_ViewProduct : Form
    {
        public Form2_ViewProduct()
        {
            InitializeComponent();
            dataGridView1_Products.DataSource = MedicineDL.medicines;
            dataGridView1_Products.Columns[0].HeaderText = "Medicine Name";
        }

        public void Form2_ViewProduct_Load(object sender, EventArgs e)
        {
        }

        private void medicineBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            User_Options_Menu.instance.frm_options.BringToFront();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_Products_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
