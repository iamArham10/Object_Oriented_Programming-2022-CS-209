using System.Security.Principal;
using System.Windows.Forms.VisualStyles;

namespace Challange_1
{
    public partial class Form1 : Form
    {
        // textbox color list
        public Color[] colors = {Color.Red,Color.Green,Color.Blue};
        // textbox current color position
        public int index = 0;

        public Form1()
        {
            InitializeComponent();
            textBox1.BackColor = colors[index];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BackWard();
            textBox1.BackColor = colors[index];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Forward();
            textBox1.BackColor = colors[index];
        }

        private void Forward()
        {
            if (index == 2) index = 0;
            else index++;
        }
        private void BackWard()
        {
            if (index == 0) index = 2;
            else index--;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {     
        }
    }
}