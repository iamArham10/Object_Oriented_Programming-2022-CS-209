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
    public partial class Form6_ChangeStock : Form
    {
        public Form6_ChangeStock()
        {
            InitializeComponent();
            Refresh_GridView();
        }

        private void tableLayoutPanel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                Refresh_GridView();
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) == false)
            {
                dgv_products.DataSource = MedicineDL.Get_Req_Medicine_List(textBox1.Text);
            }
        }

        private void dgv_products_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_products.SelectedRows.Count == 1)
            {
                var product = dgv_products.SelectedRows[0].DataBoundItem as Medicine;
                if (product != null)
                {
                    Set_Product_Labels(product);
                }
            }
        }

        private void Set_Product_Labels(Medicine m)
        {
            lbl_SproductName.Text = m.Name;
            lbl_SproductWeight.Text = m.Weight.ToString();
            lbl_SproductPrice.Text = m.Price.ToString();
            lbl_SproductQuantities.Text = m.Quantities.ToString();
        }

        private void tb_quantities_TextChanged(object sender, EventArgs e)
        {
            if (!(Validation.Validate_Int_String(tb_quantities.Text)))
            {
                errorProvider1.SetError(tb_quantities, "Please Enter Valid Information only numbers greater than 0");
            }
            else
            {
                errorProvider1.SetError(tb_quantities, "");
            }
        }

        private void btn_addQuantity_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tb_quantities.Text))
            {
                MessageBox.Show("Please Enter Quantity");
                return;
            }
            if (dgv_products.SelectedRows.Count == 1)
            {
                var product = dgv_products.SelectedRows[0].DataBoundItem as Medicine;
                if (product != null)
                {
                    if (Validation.Validate_Int_String(tb_quantities.Text))
                    {
                        if (product.Add_Quantities(int.Parse(tb_quantities.Text)))
                        {
                            MedicineDL.Save_All_Medicines();
                            MessageBox.Show("Quantities Added");
                            Refresh_GridView();
                            Set_Product_Labels(product);
                            tb_quantities.Text = null;
                        }
                    }
                    else MessageBox.Show("Please Enter Valid Input");
                }
            }
            else MessageBox.Show("Please Select Product To Change Quantities");
        }

        private void Refresh_GridView()
        {
            dgv_products.DataSource = null;
            dgv_products.DataSource = MedicineDL.medicines;
        }

        private void btn_removeQuantity_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tb_quantities.Text))
            {
                MessageBox.Show("Please Enter Quantity");
                return;
            }
            if (dgv_products.SelectedRows.Count == 1)
            {
                var product = dgv_products.SelectedRows[0].DataBoundItem as Medicine;
                if (product != null)
                {
                    if (Validation.Validate_Int_String(tb_quantities.Text))
                    {
                        if (product.Add_Quantities(int.Parse(tb_quantities.Text) * -1))
                        {
                            MedicineDL.Save_All_Medicines();
                            MessageBox.Show("Quantities Removed");
                            Refresh_GridView();
                            Set_Product_Labels(product);
                            tb_quantities.Text = null;
                        }
                        else MessageBox.Show("Quantities Cannot Be Removed");
                    }
                    else MessageBox.Show("Please Enter Valid Input");
                }
            }
            else MessageBox.Show("Please Select Product To Change Quantities");
        }

        private void btn_setQuantity_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tb_quantities.Text))
            {
                MessageBox.Show("Please Enter Quantity");
                return;
            }
            if (dgv_products.SelectedRows.Count == 1)
            {
                var product = dgv_products.SelectedRows[0].DataBoundItem as Medicine;
                if (product != null)
                {
                    if (Validation.Validate_Int_String(tb_quantities.Text))
                    {
                        product.Quantities = int.Parse(tb_quantities.Text);
                        MedicineDL.Save_All_Medicines();
                        MessageBox.Show("Quantities are Set Succesfully");
                        Refresh_GridView();
                        Set_Product_Labels(product);
                        tb_quantities.Text = null;
                    }
                    else MessageBox.Show("Please Enter Valid Input");
                }
            }
            else MessageBox.Show("Please Select Product To Change Quantities");
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            User_Options_Menu.instance.frm_options.BringToFront();
        }
    }
}
