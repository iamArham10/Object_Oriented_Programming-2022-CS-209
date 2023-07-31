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
    public partial class Form3_AddProduct : Form
    {
        public Form3_AddProduct()
        {
            InitializeComponent();
            dgv_products.DataSource = MedicineDL.medicines;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (!(BL.Validation.Validate_Int_String(textBox2_ProductWeight.Text)))
            {
                errorProvider1_.SetError(textBox2_ProductWeight, "can only contain number greater than 0");
            }
            else
            {
                errorProvider1_.SetError(textBox2_ProductWeight, "");
            }
        }

        private void button1_Add_Click(object sender, EventArgs e)
        {
            string name = textBox1_productName.Text;
            string weight = textBox2_ProductWeight.Text;
            string price = textBox3_productPrice.Text;
            string quantity = textBox4_productQuantities.Text;
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(weight) || string.IsNullOrEmpty(price) || string.IsNullOrEmpty(quantity))
            {
                MessageBox.Show("Please enter missing information");
                return;
            }
            if (BL.Validation.Is_String_Valid(name) && BL.Validation.Validate_Int_String(weight) && BL.Validation.Validate_Int_String(price) && BL.Validation.Validate_Int_String(quantity))
            {
                Medicine newmedicine = new Medicine(name, int.Parse((weight)), int.Parse(price), int.Parse(quantity));
                if (MedicineDL.Check_Medicine_Object(newmedicine) == false)
                {
                    MedicineDL.Add_Medicine(newmedicine);
                    MedicineDL.Save_Single_Medicine(newmedicine);
                    MessageBox.Show("Product Added Succesfully");
                    dgv_products.DataSource = null;
                    dgv_products.DataSource = MedicineDL.medicines;
                }
                else
                {
                    MessageBox.Show("Product is Already Present");
                }
            }
            else
            {
                MessageBox.Show("Enter Valid Information");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (BL.Validation.Is_String_Valid(textBox1_productName.Text) == false)
            {
                errorProvider1_.SetError(textBox1_productName, "Product can only contain alphabets");
            }
            else
            {
                errorProvider1_.SetError(textBox1_productName, "");
            }
        }

        private void textBox3_productPrice_TextChanged(object sender, EventArgs e)
        {
            if (BL.Validation.Validate_Int_String(textBox3_productPrice.Text) == false)
            {
                errorProvider1_.SetError(textBox3_productPrice, "Can only contain number greater than 0");
            }
            else
            {
                errorProvider1_.SetError(textBox3_productPrice, "");
            }
        }

        private void textBox4_productQuantities_TextChanged(object sender, EventArgs e)
        {
            if (BL.Validation.Validate_Int_String(textBox4_productQuantities.Text) == false)
            {
                errorProvider1_.SetError(textBox4_productQuantities, "Can only number greater than 0");
            }
            else
            {
                errorProvider1_.SetError(textBox4_productQuantities, "");
            }
        }

        private void button1_back_Click(object sender, EventArgs e)
        {
            User_Options_Menu.instance.frm_options.BringToFront();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
