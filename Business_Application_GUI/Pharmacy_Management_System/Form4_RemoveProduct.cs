using Pharmacy_Management_System.BL;
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
    public partial class Form4_RemoveProduct : Form
    {
        public Form4_RemoveProduct()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_search_Click(object sender, EventArgs e)
        {
            ReFill_DataGrid();
            if (dataGridView1.DataSource == null)
            {
                MessageBox.Show("Product Not Present");
            }
        }

        private void button2_Delete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                var selected = dataGridView1.SelectedRows[0].DataBoundItem as Medicine;
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to Remove?", "Remove", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    if (MedicineDL.Remove_Medicine(selected))
                    {
                        MedicineDL.Save_All_Medicines();
                        MessageBox.Show("Product Removed");
                        ReFill_DataGrid();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please Select a Product");
            }
        }

        private void ReFill_DataGrid()
        {
            string productName = textBox1_product_Name.Text;
            List<Medicine> reqMedicines;
            reqMedicines = MedicineDL.Get_Req_Medicine_List(productName);
            if (reqMedicines.Count == 0)
            {
                dataGridView1.DataSource = null;
                return;
            }
            dataGridView1.DataSource = reqMedicines;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User_Options_Menu.instance.frm_options.BringToFront();
        }

        private void button2_Delete_MouseMove(object sender, MouseEventArgs e)
        {
            toolTip1.SetToolTip(button2_Delete, "Delete The Selected Product");
        }
    }
}
