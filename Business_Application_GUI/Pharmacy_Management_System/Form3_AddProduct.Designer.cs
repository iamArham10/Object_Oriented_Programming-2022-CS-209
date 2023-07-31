namespace Pharmacy_Management_System
{
    partial class Form3_AddProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3_AddProduct));
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            button1_back = new Button();
            panel2 = new Panel();
            tableLayoutPanel3 = new TableLayoutPanel();
            panel3 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            label3_Weight = new Label();
            label4_Price = new Label();
            label5_quantity = new Label();
            textBox1_productName = new TextBox();
            textBox2_ProductWeight = new TextBox();
            textBox3_productPrice = new TextBox();
            textBox4_productQuantities = new TextBox();
            button1_Add = new Button();
            label2_Name = new Label();
            dgv_products = new DataGridView();
            errorProvider1_ = new ErrorProvider(components);
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            panel3.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_products).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1_).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1270, 82);
            panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.White;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 1213F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1270, 82);
            tableLayoutPanel1.TabIndex = 0;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(578, 28);
            label1.Name = "label1";
            label1.Size = new Size(113, 25);
            label1.TabIndex = 1;
            label1.Text = "Add Product";
            label1.Click += label1_Click;
            // 
            // button1_back
            // 
            button1_back.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1_back.BackColor = Color.Transparent;
            button1_back.BackgroundImage = Properties.Resources.Left_21;
            button1_back.BackgroundImageLayout = ImageLayout.Zoom;
            button1_back.FlatAppearance.BorderSize = 0;
            button1_back.FlatStyle = FlatStyle.Flat;
            button1_back.Location = new Point(66, 459);
            button1_back.Name = "button1_back";
            button1_back.Size = new Size(53, 52);
            button1_back.TabIndex = 0;
            button1_back.UseVisualStyleBackColor = false;
            button1_back.Click += button1_back_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(tableLayoutPanel3);
            panel2.Controls.Add(button1_back);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 82);
            panel2.Name = "panel2";
            panel2.Size = new Size(1270, 523);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 39.1338577F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60.8661423F));
            tableLayoutPanel3.Controls.Add(panel3, 0, 0);
            tableLayoutPanel3.Controls.Add(dgv_products, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Top;
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(1270, 453);
            tableLayoutPanel3.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.None;
            panel3.Controls.Add(tableLayoutPanel2);
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(491, 447);
            panel3.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.29586F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 74.70414F));
            tableLayoutPanel2.Controls.Add(label3_Weight, 0, 1);
            tableLayoutPanel2.Controls.Add(label4_Price, 0, 2);
            tableLayoutPanel2.Controls.Add(label5_quantity, 0, 3);
            tableLayoutPanel2.Controls.Add(textBox1_productName, 1, 0);
            tableLayoutPanel2.Controls.Add(textBox2_ProductWeight, 1, 1);
            tableLayoutPanel2.Controls.Add(textBox3_productPrice, 1, 2);
            tableLayoutPanel2.Controls.Add(textBox4_productQuantities, 1, 3);
            tableLayoutPanel2.Controls.Add(button1_Add, 1, 4);
            tableLayoutPanel2.Controls.Add(label2_Name, 0, 0);
            tableLayoutPanel2.Location = new Point(39, 41);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 5;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.Size = new Size(423, 360);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // label3_Weight
            // 
            label3_Weight.Anchor = AnchorStyles.None;
            label3_Weight.AutoSize = true;
            label3_Weight.Location = new Point(14, 83);
            label3_Weight.Name = "label3_Weight";
            label3_Weight.Size = new Size(79, 50);
            label3_Weight.TabIndex = 0;
            label3_Weight.Text = "Product Weight ";
            // 
            // label4_Price
            // 
            label4_Price.Anchor = AnchorStyles.None;
            label4_Price.AutoSize = true;
            label4_Price.Location = new Point(14, 155);
            label4_Price.Name = "label4_Price";
            label4_Price.Size = new Size(79, 50);
            label4_Price.TabIndex = 0;
            label4_Price.Text = "Product Price";
            // 
            // label5_quantity
            // 
            label5_quantity.Anchor = AnchorStyles.None;
            label5_quantity.AutoSize = true;
            label5_quantity.Location = new Point(7, 227);
            label5_quantity.Name = "label5_quantity";
            label5_quantity.Size = new Size(92, 50);
            label5_quantity.TabIndex = 0;
            label5_quantity.Text = "Product Quantities";
            // 
            // textBox1_productName
            // 
            textBox1_productName.Anchor = AnchorStyles.Left;
            textBox1_productName.BackColor = Color.White;
            textBox1_productName.Location = new Point(110, 20);
            textBox1_productName.Name = "textBox1_productName";
            textBox1_productName.Size = new Size(310, 31);
            textBox1_productName.TabIndex = 1;
            textBox1_productName.TextChanged += textBox1_TextChanged;
            // 
            // textBox2_ProductWeight
            // 
            textBox2_ProductWeight.Anchor = AnchorStyles.Left;
            textBox2_ProductWeight.BackColor = Color.White;
            textBox2_ProductWeight.Location = new Point(110, 92);
            textBox2_ProductWeight.Name = "textBox2_ProductWeight";
            textBox2_ProductWeight.Size = new Size(310, 31);
            textBox2_ProductWeight.TabIndex = 1;
            textBox2_ProductWeight.TextChanged += textBox2_TextChanged;
            // 
            // textBox3_productPrice
            // 
            textBox3_productPrice.Anchor = AnchorStyles.Left;
            textBox3_productPrice.BackColor = Color.White;
            textBox3_productPrice.Location = new Point(110, 164);
            textBox3_productPrice.Name = "textBox3_productPrice";
            textBox3_productPrice.Size = new Size(310, 31);
            textBox3_productPrice.TabIndex = 1;
            textBox3_productPrice.TextChanged += textBox3_productPrice_TextChanged;
            // 
            // textBox4_productQuantities
            // 
            textBox4_productQuantities.Anchor = AnchorStyles.Left;
            textBox4_productQuantities.BackColor = Color.White;
            textBox4_productQuantities.Location = new Point(110, 236);
            textBox4_productQuantities.Name = "textBox4_productQuantities";
            textBox4_productQuantities.Size = new Size(310, 31);
            textBox4_productQuantities.TabIndex = 1;
            textBox4_productQuantities.TextChanged += textBox4_productQuantities_TextChanged;
            // 
            // button1_Add
            // 
            button1_Add.Anchor = AnchorStyles.Right;
            button1_Add.BackColor = Color.Transparent;
            button1_Add.BackgroundImage = Properties.Resources.plus;
            button1_Add.BackgroundImageLayout = ImageLayout.Zoom;
            button1_Add.FlatAppearance.BorderSize = 0;
            button1_Add.FlatStyle = FlatStyle.Flat;
            button1_Add.Location = new Point(354, 291);
            button1_Add.Name = "button1_Add";
            button1_Add.Size = new Size(66, 66);
            button1_Add.TabIndex = 1;
            button1_Add.UseVisualStyleBackColor = false;
            button1_Add.Click += button1_Add_Click;
            // 
            // label2_Name
            // 
            label2_Name.Anchor = AnchorStyles.None;
            label2_Name.AutoSize = true;
            label2_Name.Location = new Point(14, 11);
            label2_Name.Name = "label2_Name";
            label2_Name.Size = new Size(79, 50);
            label2_Name.TabIndex = 0;
            label2_Name.Text = "Product Name";
            // 
            // dgv_products
            // 
            dgv_products.AllowUserToAddRows = false;
            dgv_products.AllowUserToDeleteRows = false;
            dgv_products.AllowUserToResizeColumns = false;
            dgv_products.AllowUserToResizeRows = false;
            dgv_products.Anchor = AnchorStyles.None;
            dgv_products.BackgroundColor = Color.White;
            dgv_products.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_products.GridColor = Color.FromArgb(197, 223, 248);
            dgv_products.Location = new Point(561, 35);
            dgv_products.MultiSelect = false;
            dgv_products.Name = "dgv_products";
            dgv_products.ReadOnly = true;
            dgv_products.RowHeadersVisible = false;
            dgv_products.RowHeadersWidth = 62;
            dgv_products.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgv_products.RowTemplate.Height = 33;
            dgv_products.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_products.Size = new Size(644, 383);
            dgv_products.TabIndex = 1;
            // 
            // errorProvider1_
            // 
            errorProvider1_.ContainerControl = this;
            errorProvider1_.Icon = (Icon)resources.GetObject("errorProvider1_.Icon");
            // 
            // Form3_AddProduct
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1270, 605);
            ControlBox = false;
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form3_AddProduct";
            StartPosition = FormStartPosition.CenterScreen;
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            panel3.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_products).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1_).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Button button1_back;
        private Panel panel2;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label2_Name;
        private Label label3_Weight;
        private Label label4_Price;
        private Button button1_Add;
        private Label label5_quantity;
        private TextBox textBox1_productName;
        private TextBox textBox2_ProductWeight;
        private TextBox textBox3_productPrice;
        private TextBox textBox4_productQuantities;
        private ErrorProvider errorProvider1_;
        private DataGridView dgv_products;
        private TableLayoutPanel tableLayoutPanel3;
        private Panel panel3;
        private Label label1;
    }
}