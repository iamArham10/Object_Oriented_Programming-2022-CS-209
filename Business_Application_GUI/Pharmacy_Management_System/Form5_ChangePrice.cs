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
    public partial class Form5_ChangePrice : Form
    {
        public Form5_ChangePrice()
        {
            InitializeComponent();
            var medicines = MedicineDL.medicines;
            dataGridView1_medicines.DataSource = medicines;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label5_sProductName_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_medicines_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var selected = dataGridView1_medicines.SelectedRows[0].DataBoundItem as Medicine;
            if (selected != null)
            {
                label5_sProductName.Text = Convert.ToString(selected.Name);
                label7_sProductPrice.Text = Convert.ToString(selected.Price) + "$";
                label6_sProductWeight.Text = Convert.ToString(selected.Weight) + "mg";
                label8_sProductQuantity.Text = $"{selected.Quantities}";
            }
        }

        private void button1_changePrice_Click(object sender, EventArgs e)
        {
            if (dataGridView1_medicines.SelectedRows.Count == 1)
            {
                if (string.IsNullOrEmpty(textBox1.Text) == false)
                {
                    if (Validation.Validate_Int_String(textBox1.Text))
                    {
                        var product = dataGridView1_medicines.SelectedRows[0].DataBoundItem as Medicine;
                        if (product != null)
                        {
                            if (product.Price != int.Parse(textBox1.Text))
                            {
                                DialogResult tochange = MessageBox.Show("Are You Sure?", "Change Price", MessageBoxButtons.YesNo);
                                if (tochange == DialogResult.Yes)
                                {
                                    product.Price = int.Parse(textBox1.Text);
                                    MessageBox.Show("Product Price Change");
                                    MedicineDL.Save_All_Medicines();
                                    dataGridView1_medicines.DataSource = null;
                                    dataGridView1_medicines.DataSource = MedicineDL.medicines;
                                }
                            }
                            else MessageBox.Show("Enter Different Price if you want to Change");
                        }
                    }
                    else MessageBox.Show("Enter Valid Price");
                }
                else MessageBox.Show("Enter Price");
            }
            else MessageBox.Show("Select Product");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!(Validation.Validate_Int_String(textBox1.Text)))
            {
                errorProvider1.SetError(textBox1, "Please Enter Valid Information (numbers greater than 0) only");
            }
            else
            {
                errorProvider1.SetError(textBox1, "");
            }
        }


        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_back_Click(object sender, EventArgs e)
        {
            User_Options_Menu.instance.frm_options.BringToFront();
        }
    }
}
