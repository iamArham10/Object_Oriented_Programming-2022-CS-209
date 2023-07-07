namespace SA_Task_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            FRM_HelloWorld helloworldform = new FRM_HelloWorld();
            helloworldform.ShowDialog();
        }
    }
}