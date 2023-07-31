namespace Pharmacy_Management_System
{
    partial class Form4_RemoveProduct
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4_RemoveProduct));
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            button2_Delete = new Button();
            dataGridView1 = new DataGridView();
            button2_search = new Button();
            textBox1_product_Name = new TextBox();
            label2_productName = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            button1_Back = new Button();
            label1 = new Label();
            toolTip1 = new ToolTip(components);
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 88.8888855F));
            tableLayoutPanel1.Size = new Size(1272, 612);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(button2_Delete);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(button2_search);
            panel1.Controls.Add(textBox1_product_Name);
            panel1.Controls.Add(label2_productName);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 70);
            panel1.Name = "panel1";
            panel1.Size = new Size(1266, 539);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // button2_Delete
            // 
            button2_Delete.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button2_Delete.BackColor = Color.Transparent;
            button2_Delete.BackgroundImage = (Image)resources.GetObject("button2_Delete.BackgroundImage");
            button2_Delete.BackgroundImageLayout = ImageLayout.Zoom;
            button2_Delete.Cursor = Cursors.Hand;
            button2_Delete.FlatAppearance.BorderSize = 0;
            button2_Delete.FlatStyle = FlatStyle.Flat;
            button2_Delete.Location = new Point(963, 398);
            button2_Delete.Name = "button2_Delete";
            button2_Delete.Size = new Size(72, 51);
            button2_Delete.TabIndex = 4;
            button2_Delete.UseVisualStyleBackColor = false;
            button2_Delete.Click += button2_Delete_Click;
            button2_Delete.MouseMove += button2_Delete_MouseMove;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = Color.White;
            dataGridView1.Location = new Point(201, 133);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(834, 244);
            dataGridView1.TabIndex = 3;
            // 
            // button2_search
            // 
            button2_search.Anchor = AnchorStyles.None;
            button2_search.BackgroundImage = Properties.Resources.Search;
            button2_search.BackgroundImageLayout = ImageLayout.Stretch;
            button2_search.FlatAppearance.BorderSize = 0;
            button2_search.FlatStyle = FlatStyle.Flat;
            button2_search.Location = new Point(934, 51);
            button2_search.Name = "button2_search";
            button2_search.Size = new Size(40, 34);
            button2_search.TabIndex = 2;
            button2_search.UseVisualStyleBackColor = true;
            button2_search.Click += button2_search_Click;
            // 
            // textBox1_product_Name
            // 
            textBox1_product_Name.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox1_product_Name.BackColor = Color.White;
            textBox1_product_Name.Cursor = Cursors.Hand;
            textBox1_product_Name.Location = new Point(359, 50);
            textBox1_product_Name.Name = "textBox1_product_Name";
            textBox1_product_Name.Size = new Size(569, 31);
            textBox1_product_Name.TabIndex = 1;
            // 
            // label2_productName
            // 
            label2_productName.Anchor = AnchorStyles.None;
            label2_productName.AutoSize = true;
            label2_productName.BackColor = Color.FromArgb(29, 93, 155);
            label2_productName.ForeColor = Color.White;
            label2_productName.Location = new Point(201, 53);
            label2_productName.Name = "label2_productName";
            label2_productName.Size = new Size(140, 25);
            label2_productName.TabIndex = 0;
            label2_productName.Text = "Product Name : ";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 4.81832552F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 95.18167F));
            tableLayoutPanel2.Controls.Add(button1_Back, 0, 0);
            tableLayoutPanel2.Controls.Add(label1, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(1266, 61);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // button1_Back
            // 
            button1_Back.BackColor = Color.Transparent;
            button1_Back.BackgroundImage = Properties.Resources.Left_2;
            button1_Back.BackgroundImageLayout = ImageLayout.Zoom;
            button1_Back.Dock = DockStyle.Fill;
            button1_Back.FlatAppearance.BorderSize = 0;
            button1_Back.FlatStyle = FlatStyle.Flat;
            button1_Back.Location = new Point(3, 3);
            button1_Back.Name = "button1_Back";
            button1_Back.Size = new Size(55, 55);
            button1_Back.TabIndex = 0;
            button1_Back.UseVisualStyleBackColor = false;
            button1_Back.Click += button1_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Leelawadee UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(541, 8);
            label1.Name = "label1";
            label1.Size = new Size(244, 45);
            label1.TabIndex = 1;
            label1.Text = "Delete Product";
            // 
            // Form4_RemoveProduct
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1272, 612);
            ControlBox = false;
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form4_RemoveProduct";
            StartPosition = FormStartPosition.CenterScreen;
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Button button1_Back;
        private Label label1;
        private Button button2_search;
        private TextBox textBox1_product_Name;
        private Label label2_productName;
        private Button button2_Delete;
        private DataGridView dataGridView1;
        private ToolTip toolTip1;
    }
}