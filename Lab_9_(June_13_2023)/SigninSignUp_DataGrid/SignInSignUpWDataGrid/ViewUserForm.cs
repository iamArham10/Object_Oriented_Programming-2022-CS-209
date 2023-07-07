using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SignInSignUpWDataGrid
{
    public partial class ViewUserForm : Form
    {
        private string path = @"C:\Users\Win 10\Documents\GitHub\Object_Oriented_Programming-2022-CS-209\Lab_9_(June_13_2023)\SigninSignUp_DataGrid\SignInSignUpWDataGrid\files\users.txt";

        public ViewUserForm()
        {
            InitializeComponent();
        }
        public void Form1_Load(object sender, EventArgs e)
        {
            UserDL.Read_Data_From_File(path);
            dataGridView1.DataSource = UserDL.userList;
        }

        public void dataBind()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = UserDL.userList;
            dataGridView1.Refresh();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ViewUserForm_Load(object sender, EventArgs e)
        {

        }
    }
}
