namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                checkBox1.Checked = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.ForeColor = default;
            if (checkBox1.Checked)
            {
                label1.Text = "Male Selected";
            }
            if (checkBox2.Checked)
            {
                if (checkBox1.Checked)
                {
                    label1.ForeColor = Color.Red;
                    label1.Text = "Select One Gender Only";
                }
                else label1.Text = "Female Selected";

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox1.Checked== true)
            {
                checkBox2.Checked = false;
            }

        }
    }
}