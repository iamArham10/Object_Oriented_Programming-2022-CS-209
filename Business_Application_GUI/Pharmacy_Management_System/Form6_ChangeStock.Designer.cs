namespace Pharmacy_Management_System
{
    partial class Form6_ChangeStock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6_ChangeStock));
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            btn_back = new Button();
            lbl_changeStock = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            panel1 = new Panel();
            dgv_products = new DataGridView();
            tableLayoutPanel4 = new TableLayoutPanel();
            textBox1 = new TextBox();
            btn_search = new Button();
            panel2 = new Panel();
            tableLayoutPanel6 = new TableLayoutPanel();
            btn_removeQuantity = new Button();
            btn_setQuantity = new Button();
            btn_addQuantity = new Button();
            lbl_remove = new Label();
            lbl_set = new Label();
            lbl_add = new Label();
            tableLayoutPanel5 = new TableLayoutPanel();
            lbl_productName = new Label();
            lbl_SproductName = new Label();
            lbl_productWeight = new Label();
            lbl_SproductWeight = new Label();
            lbl_productPrice = new Label();
            lbl_SproductPrice = new Label();
            lbl_productQuantities = new Label();
            lbl_SproductQuantities = new Label();
            lbl_changeQuantities = new Label();
            tb_quantities = new TextBox();
            errorProvider1 = new ErrorProvider(components);
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_products).BeginInit();
            tableLayoutPanel4.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 13.1534567F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 86.84654F));
            tableLayoutPanel1.Size = new Size(1056, 593);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 6.285714F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 93.71429F));
            tableLayoutPanel2.Controls.Add(btn_back, 0, 0);
            tableLayoutPanel2.Controls.Add(lbl_changeStock, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(1050, 72);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // btn_back
            // 
            btn_back.BackColor = Color.Transparent;
            btn_back.BackgroundImage = (Image)resources.GetObject("btn_back.BackgroundImage");
            btn_back.BackgroundImageLayout = ImageLayout.Zoom;
            btn_back.Cursor = Cursors.Hand;
            btn_back.Dock = DockStyle.Fill;
            btn_back.FlatAppearance.BorderSize = 0;
            btn_back.FlatStyle = FlatStyle.Flat;
            btn_back.Location = new Point(3, 3);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(60, 66);
            btn_back.TabIndex = 0;
            btn_back.UseVisualStyleBackColor = false;
            btn_back.Click += btn_back_Click;
            // 
            // lbl_changeStock
            // 
            lbl_changeStock.Anchor = AnchorStyles.None;
            lbl_changeStock.AutoSize = true;
            lbl_changeStock.Location = new Point(498, 23);
            lbl_changeStock.Name = "lbl_changeStock";
            lbl_changeStock.Size = new Size(120, 25);
            lbl_changeStock.TabIndex = 1;
            lbl_changeStock.Text = "Change Stock";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 48.95238F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 51.04762F));
            tableLayoutPanel3.Controls.Add(panel1, 1, 0);
            tableLayoutPanel3.Controls.Add(panel2, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 81);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(1050, 509);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(dgv_products);
            panel1.Controls.Add(tableLayoutPanel4);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(517, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(530, 503);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // dgv_products
            // 
            dgv_products.AllowUserToAddRows = false;
            dgv_products.AllowUserToDeleteRows = false;
            dgv_products.AllowUserToResizeColumns = false;
            dgv_products.AllowUserToResizeRows = false;
            dgv_products.BackgroundColor = Color.White;
            dgv_products.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_products.GridColor = Color.White;
            dgv_products.Location = new Point(22, 55);
            dgv_products.MultiSelect = false;
            dgv_products.Name = "dgv_products";
            dgv_products.ReadOnly = true;
            dgv_products.RowHeadersWidth = 62;
            dgv_products.RowTemplate.Height = 33;
            dgv_products.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_products.Size = new Size(428, 374);
            dgv_products.TabIndex = 1;
            dgv_products.CellClick += dgv_products_CellClick;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 3;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 3.838384F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 84.84849F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel4.Controls.Add(textBox1, 1, 0);
            tableLayoutPanel4.Controls.Add(btn_search, 2, 0);
            tableLayoutPanel4.Dock = DockStyle.Top;
            tableLayoutPanel4.Location = new Point(0, 0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(530, 39);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.Location = new Point(23, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(427, 31);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // btn_search
            // 
            btn_search.BackgroundImage = Properties.Resources.Search;
            btn_search.BackgroundImageLayout = ImageLayout.Zoom;
            btn_search.Cursor = Cursors.Hand;
            btn_search.Dock = DockStyle.Fill;
            btn_search.FlatAppearance.BorderSize = 0;
            btn_search.FlatStyle = FlatStyle.Flat;
            btn_search.Location = new Point(473, 3);
            btn_search.Name = "btn_search";
            btn_search.Size = new Size(54, 33);
            btn_search.TabIndex = 1;
            btn_search.UseVisualStyleBackColor = true;
            btn_search.Click += btn_search_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(tableLayoutPanel6);
            panel2.Controls.Add(tableLayoutPanel5);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(508, 503);
            panel2.TabIndex = 1;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 3;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel6.Controls.Add(btn_removeQuantity, 1, 0);
            tableLayoutPanel6.Controls.Add(btn_setQuantity, 2, 0);
            tableLayoutPanel6.Controls.Add(btn_addQuantity, 0, 0);
            tableLayoutPanel6.Controls.Add(lbl_remove, 1, 1);
            tableLayoutPanel6.Controls.Add(lbl_set, 2, 1);
            tableLayoutPanel6.Controls.Add(lbl_add, 0, 1);
            tableLayoutPanel6.Location = new Point(176, 404);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 2;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel6.Size = new Size(304, 93);
            tableLayoutPanel6.TabIndex = 1;
            // 
            // btn_removeQuantity
            // 
            btn_removeQuantity.BackColor = Color.Transparent;
            btn_removeQuantity.BackgroundImage = (Image)resources.GetObject("btn_removeQuantity.BackgroundImage");
            btn_removeQuantity.BackgroundImageLayout = ImageLayout.Zoom;
            btn_removeQuantity.Cursor = Cursors.Hand;
            btn_removeQuantity.Dock = DockStyle.Fill;
            btn_removeQuantity.FlatAppearance.BorderSize = 0;
            btn_removeQuantity.FlatStyle = FlatStyle.Flat;
            btn_removeQuantity.Location = new Point(104, 3);
            btn_removeQuantity.Name = "btn_removeQuantity";
            btn_removeQuantity.Size = new Size(95, 57);
            btn_removeQuantity.TabIndex = 0;
            btn_removeQuantity.UseVisualStyleBackColor = false;
            btn_removeQuantity.Click += btn_removeQuantity_Click;
            // 
            // btn_setQuantity
            // 
            btn_setQuantity.BackgroundImage = Properties.Resources.set;
            btn_setQuantity.BackgroundImageLayout = ImageLayout.Zoom;
            btn_setQuantity.Cursor = Cursors.Hand;
            btn_setQuantity.Dock = DockStyle.Fill;
            btn_setQuantity.FlatAppearance.BorderSize = 0;
            btn_setQuantity.FlatStyle = FlatStyle.Flat;
            btn_setQuantity.Location = new Point(205, 3);
            btn_setQuantity.Name = "btn_setQuantity";
            btn_setQuantity.Size = new Size(96, 57);
            btn_setQuantity.TabIndex = 0;
            btn_setQuantity.UseVisualStyleBackColor = true;
            btn_setQuantity.Click += btn_setQuantity_Click;
            // 
            // btn_addQuantity
            // 
            btn_addQuantity.BackgroundImage = Properties.Resources.plus;
            btn_addQuantity.BackgroundImageLayout = ImageLayout.Zoom;
            btn_addQuantity.Cursor = Cursors.Hand;
            btn_addQuantity.Dock = DockStyle.Fill;
            btn_addQuantity.FlatAppearance.BorderSize = 0;
            btn_addQuantity.FlatStyle = FlatStyle.Flat;
            btn_addQuantity.Location = new Point(3, 3);
            btn_addQuantity.Name = "btn_addQuantity";
            btn_addQuantity.Size = new Size(95, 57);
            btn_addQuantity.TabIndex = 0;
            btn_addQuantity.UseVisualStyleBackColor = true;
            btn_addQuantity.Click += btn_addQuantity_Click;
            // 
            // lbl_remove
            // 
            lbl_remove.Anchor = AnchorStyles.None;
            lbl_remove.AutoSize = true;
            lbl_remove.Location = new Point(113, 65);
            lbl_remove.Name = "lbl_remove";
            lbl_remove.Size = new Size(76, 25);
            lbl_remove.TabIndex = 1;
            lbl_remove.Text = "Remove";
            // 
            // lbl_set
            // 
            lbl_set.Anchor = AnchorStyles.None;
            lbl_set.AutoSize = true;
            lbl_set.Location = new Point(234, 65);
            lbl_set.Name = "lbl_set";
            lbl_set.Size = new Size(37, 25);
            lbl_set.TabIndex = 1;
            lbl_set.Text = "Set";
            // 
            // lbl_add
            // 
            lbl_add.Anchor = AnchorStyles.None;
            lbl_add.AutoSize = true;
            lbl_add.Location = new Point(27, 65);
            lbl_add.Name = "lbl_add";
            lbl_add.Size = new Size(46, 25);
            lbl_add.TabIndex = 1;
            lbl_add.Text = "Add";
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.46856F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 66.53144F));
            tableLayoutPanel5.Controls.Add(lbl_productName, 0, 0);
            tableLayoutPanel5.Controls.Add(lbl_SproductName, 1, 0);
            tableLayoutPanel5.Controls.Add(lbl_productWeight, 0, 1);
            tableLayoutPanel5.Controls.Add(lbl_SproductWeight, 1, 1);
            tableLayoutPanel5.Controls.Add(lbl_productPrice, 0, 2);
            tableLayoutPanel5.Controls.Add(lbl_SproductPrice, 1, 2);
            tableLayoutPanel5.Controls.Add(lbl_productQuantities, 0, 3);
            tableLayoutPanel5.Controls.Add(lbl_SproductQuantities, 1, 3);
            tableLayoutPanel5.Controls.Add(lbl_changeQuantities, 0, 4);
            tableLayoutPanel5.Controls.Add(tb_quantities, 1, 4);
            tableLayoutPanel5.Location = new Point(24, 55);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 5;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel5.Size = new Size(456, 343);
            tableLayoutPanel5.TabIndex = 0;
            tableLayoutPanel5.Paint += tableLayoutPanel5_Paint;
            // 
            // lbl_productName
            // 
            lbl_productName.Anchor = AnchorStyles.None;
            lbl_productName.AutoSize = true;
            lbl_productName.Location = new Point(13, 21);
            lbl_productName.Name = "lbl_productName";
            lbl_productName.Size = new Size(126, 25);
            lbl_productName.TabIndex = 0;
            lbl_productName.Text = "Product Name";
            // 
            // lbl_SproductName
            // 
            lbl_SproductName.Anchor = AnchorStyles.None;
            lbl_SproductName.AutoSize = true;
            lbl_SproductName.Location = new Point(304, 21);
            lbl_SproductName.Name = "lbl_SproductName";
            lbl_SproductName.Size = new Size(0, 25);
            lbl_SproductName.TabIndex = 0;
            // 
            // lbl_productWeight
            // 
            lbl_productWeight.Anchor = AnchorStyles.None;
            lbl_productWeight.AutoSize = true;
            lbl_productWeight.Location = new Point(8, 89);
            lbl_productWeight.Name = "lbl_productWeight";
            lbl_productWeight.Size = new Size(135, 25);
            lbl_productWeight.TabIndex = 0;
            lbl_productWeight.Text = "Product Weight";
            // 
            // lbl_SproductWeight
            // 
            lbl_SproductWeight.Anchor = AnchorStyles.None;
            lbl_SproductWeight.AutoSize = true;
            lbl_SproductWeight.Location = new Point(304, 89);
            lbl_SproductWeight.Name = "lbl_SproductWeight";
            lbl_SproductWeight.Size = new Size(0, 25);
            lbl_SproductWeight.TabIndex = 0;
            // 
            // lbl_productPrice
            // 
            lbl_productPrice.Anchor = AnchorStyles.None;
            lbl_productPrice.AutoSize = true;
            lbl_productPrice.Location = new Point(18, 157);
            lbl_productPrice.Name = "lbl_productPrice";
            lbl_productPrice.Size = new Size(116, 25);
            lbl_productPrice.TabIndex = 0;
            lbl_productPrice.Text = "Product Price";
            // 
            // lbl_SproductPrice
            // 
            lbl_SproductPrice.Anchor = AnchorStyles.None;
            lbl_SproductPrice.AutoSize = true;
            lbl_SproductPrice.Location = new Point(304, 157);
            lbl_SproductPrice.Name = "lbl_SproductPrice";
            lbl_SproductPrice.Size = new Size(0, 25);
            lbl_SproductPrice.TabIndex = 0;
            // 
            // lbl_productQuantities
            // 
            lbl_productQuantities.Anchor = AnchorStyles.None;
            lbl_productQuantities.AutoSize = true;
            lbl_productQuantities.Location = new Point(30, 213);
            lbl_productQuantities.Name = "lbl_productQuantities";
            lbl_productQuantities.Size = new Size(92, 50);
            lbl_productQuantities.TabIndex = 0;
            lbl_productQuantities.Text = "Product Quantities";
            // 
            // lbl_SproductQuantities
            // 
            lbl_SproductQuantities.Anchor = AnchorStyles.None;
            lbl_SproductQuantities.AutoSize = true;
            lbl_SproductQuantities.Location = new Point(304, 225);
            lbl_SproductQuantities.Name = "lbl_SproductQuantities";
            lbl_SproductQuantities.Size = new Size(0, 25);
            lbl_SproductQuantities.TabIndex = 0;
            // 
            // lbl_changeQuantities
            // 
            lbl_changeQuantities.Anchor = AnchorStyles.None;
            lbl_changeQuantities.AutoSize = true;
            lbl_changeQuantities.Location = new Point(11, 295);
            lbl_changeQuantities.Name = "lbl_changeQuantities";
            lbl_changeQuantities.Size = new Size(130, 25);
            lbl_changeQuantities.TabIndex = 0;
            lbl_changeQuantities.Text = "Enter Quantity ";
            // 
            // tb_quantities
            // 
            tb_quantities.Anchor = AnchorStyles.None;
            tb_quantities.BackColor = Color.White;
            tb_quantities.Location = new Point(176, 292);
            tb_quantities.Name = "tb_quantities";
            tb_quantities.Size = new Size(255, 31);
            tb_quantities.TabIndex = 1;
            tb_quantities.TextChanged += tb_quantities_TextChanged;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Form6_ChangeStock
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1056, 593);
            ControlBox = false;
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form6_ChangeStock";
            StartPosition = FormStartPosition.CenterScreen;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_products).EndInit();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            panel2.ResumeLayout(false);
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private Panel panel1;
        private Panel panel2;
        private Button btn_back;
        private Label lbl_changeStock;
        private TableLayoutPanel tableLayoutPanel4;
        private TextBox textBox1;
        private Button btn_search;
        private DataGridView dgv_products;
        private TableLayoutPanel tableLayoutPanel5;
        private Label lbl_productName;
        private Label lbl_SproductName;
        private Label lbl_productWeight;
        private Label lbl_SproductWeight;
        private Label lbl_productPrice;
        private Label lbl_SproductPrice;
        private Label lbl_productQuantities;
        private Label lbl_SproductQuantities;
        private Label lbl_changeQuantities;
        private TextBox tb_quantities;
        private TableLayoutPanel tableLayoutPanel6;
        private Button btn_removeQuantity;
        private Button btn_setQuantity;
        private Button btn_addQuantity;
        private Label lbl_remove;
        private Label lbl_set;
        private Label lbl_add;
        private ErrorProvider errorProvider1;
    }
}