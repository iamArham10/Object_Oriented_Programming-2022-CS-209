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
    public partial class Form7_TakeOrder : Form
    {
        Order newOrder = new Order();
        public Form7_TakeOrder()
        {
            InitializeComponent();
            dgv_availableProducts.DataSource = MedicineDL.medicines;
            dgv_availableProducts.Columns[0].HeaderText = "Product Name";
            dgv_availableProducts.Columns[1].HeaderText = "Weight";
            dgv_availableProducts.Columns[2].HeaderText = "Available Quantities";
            dgv_availableProducts.Columns[3].HeaderText = "Price";
        }

        private void btn_checkout_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btn_checkout, "Buy");
        }

        private void lbl_productName_Click(object sender, EventArgs e)
        {

        }

        private void btn__MouseMove(object sender, MouseEventArgs e)
        {
            toolTip1.SetToolTip(btn_addtoCart, "Add To Cart");
        }

        private void dgv_availableProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_availableProducts.SelectedRows.Count != 1) return;
            var product = dgv_availableProducts.SelectedRows[0].DataBoundItem as BL.Medicine;
            if (product == null) return;
            Fill_Product_Labels(product);
        }

        private void Fill_Product_Labels(Medicine m)
        {
            lbl_sProductName.Text = m.Name;
            lbl_sProductPrice.Text = (m.Price).ToString();
            lbl_sProductWeight.Text = (m.Weight).ToString();
            trackb_productQuantities.Enabled = true;
            trackb_productQuantities.Value = trackb_productQuantities.Minimum;
            lbl_selectedQuantities.Text = trackb_productQuantities.Value.ToString();
            trackb_productQuantities.Maximum = m.Quantities;

        }

        private void trackb_productQuantities_Scroll(object sender, EventArgs e)
        {
            lbl_selectedQuantities.Text = trackb_productQuantities.Value.ToString();
        }

        private void tableLayoutPanel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_addtoCart_Click(object sender, EventArgs e)
        {
            DialogResult dialogresult = MessageBox.Show("Are you sure you want to Add?", "Add To Cart", MessageBoxButtons.YesNo);
            if (dialogresult == DialogResult.Yes)
            {
                Medicine medicine = new Medicine(lbl_sProductName.Text, int.Parse(lbl_sProductWeight.Text), int.Parse(lbl_sProductPrice.Text), trackb_productQuantities.Value);
                if (newOrder.Add_Product(medicine))
                {
                    MessageBox.Show("Product Added Succesfully");
                    dgv_selectedProducts.DataSource = null;
                    dgv_selectedProducts.DataSource = newOrder.Products;
                    lbl_sTotalPrice.Text = newOrder.Get_Total_Price().ToString();
                }
                else MessageBox.Show("Product Already Present");
            }
        }

        private void tableLayoutPanel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            if (dgv_selectedProducts.SelectedRows.Count == 1)
            {
                var product = dgv_selectedProducts.SelectedRows[0].DataBoundItem as Medicine;
                if (newOrder.Remove_Product(product))
                {
                    MessageBox.Show("Product Deleted");
                    dgv_selectedProducts.DataSource = null;
                    dgv_selectedProducts.DataSource = newOrder.Products;
                    lbl_sTotalPrice.Text = newOrder.Get_Total_Price().ToString();
                }
            }
            else MessageBox.Show("Please Select Product");
        }

        private void btn_checkout_Click(object sender, EventArgs e)
        {
            if (newOrder.products.Count > 0)
            {
                if (MedicineDL.Take_Order(newOrder))
                {
                    MessageBox.Show("Order Taken");
                    dgv_availableProducts.DataSource = null;
                    dgv_availableProducts.DataSource = MedicineDL.medicines;
                    dgv_selectedProducts.DataSource = null;
                    newOrder = new();
                    dgv_selectedProducts.DataSource = newOrder.Products;
                }
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Order Will Be Lost", "Exit", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                User_Options_Menu.instance.frm_options.BringToFront();
            }
        }
    }
}
