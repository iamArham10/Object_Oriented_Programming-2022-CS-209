namespace Pharmacy_Management_System
{
    partial class Form5_ChangePrice
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
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            button1_back = new Button();
            label1_changePrice = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            panel1 = new Panel();
            dataGridView1_medicines = new DataGridView();
            panel2 = new Panel();
            button1_changePrice = new Button();
            tableLayoutPanel4 = new TableLayoutPanel();
            label1 = new Label();
            label5_newPrice = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5_sProductName = new Label();
            label6_sProductWeight = new Label();
            label7_sProductPrice = new Label();
            label8_sProductQuantity = new Label();
            textBox1 = new TextBox();
            errorProvider1 = new ErrorProvider(components);
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1_medicines).BeginInit();
            panel2.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 13.79822F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 86.20178F));
            tableLayoutPanel1.Size = new Size(1257, 678);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.7229128F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 88.2770844F));
            tableLayoutPanel2.Controls.Add(button1_back, 0, 0);
            tableLayoutPanel2.Controls.Add(label1_changePrice, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(1251, 87);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // button1_back
            // 
            button1_back.BackColor = Color.FromArgb(202, 222, 252);
            button1_back.Dock = DockStyle.Fill;
            button1_back.FlatStyle = FlatStyle.Flat;
            button1_back.Font = new Font("Arial Narrow", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button1_back.Location = new Point(3, 3);
            button1_back.Name = "button1_back";
            button1_back.Size = new Size(140, 81);
            button1_back.TabIndex = 0;
            button1_back.Text = "Back";
            button1_back.UseVisualStyleBackColor = false;
            button1_back.Click += button1_back_Click;
            // 
            // label1_changePrice
            // 
            label1_changePrice.Anchor = AnchorStyles.None;
            label1_changePrice.AutoSize = true;
            label1_changePrice.Font = new Font("Arial Black", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1_changePrice.Location = new Point(574, 21);
            label1_changePrice.Name = "label1_changePrice";
            label1_changePrice.Size = new Size(249, 45);
            label1_changePrice.TabIndex = 1;
            label1_changePrice.Text = "Change price";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 44.8490219F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55.1509781F));
            tableLayoutPanel3.Controls.Add(panel1, 1, 0);
            tableLayoutPanel3.Controls.Add(panel2, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 96);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(1251, 579);
            tableLayoutPanel3.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridView1_medicines);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(564, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(684, 573);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint_1;
            // 
            // dataGridView1_medicines
            // 
            dataGridView1_medicines.AllowUserToAddRows = false;
            dataGridView1_medicines.AllowUserToDeleteRows = false;
            dataGridView1_medicines.AllowUserToResizeColumns = false;
            dataGridView1_medicines.AllowUserToResizeRows = false;
            dataGridView1_medicines.Anchor = AnchorStyles.None;
            dataGridView1_medicines.BackgroundColor = Color.White;
            dataGridView1_medicines.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1_medicines.GridColor = Color.FromArgb(197, 223, 248);
            dataGridView1_medicines.Location = new Point(31, 94);
            dataGridView1_medicines.MultiSelect = false;
            dataGridView1_medicines.Name = "dataGridView1_medicines";
            dataGridView1_medicines.ReadOnly = true;
            dataGridView1_medicines.RowHeadersVisible = false;
            dataGridView1_medicines.RowHeadersWidth = 62;
            dataGridView1_medicines.RowTemplate.Height = 33;
            dataGridView1_medicines.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1_medicines.Size = new Size(635, 314);
            dataGridView1_medicines.TabIndex = 0;
            dataGridView1_medicines.CellClick += dataGridView1_medicines_CellClick;
            // 
            // panel2
            // 
            panel2.Controls.Add(button1_changePrice);
            panel2.Controls.Add(tableLayoutPanel4);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(555, 573);
            panel2.TabIndex = 0;
            panel2.Paint += panel1_Paint_1;
            // 
            // button1_changePrice
            // 
            button1_changePrice.BackColor = Color.FromArgb(202, 222, 252);
            button1_changePrice.Cursor = Cursors.Hand;
            button1_changePrice.Location = new Point(350, 424);
            button1_changePrice.Name = "button1_changePrice";
            button1_changePrice.Size = new Size(191, 81);
            button1_changePrice.TabIndex = 1;
            button1_changePrice.Text = "Change";
            button1_changePrice.UseVisualStyleBackColor = false;
            button1_changePrice.Click += button1_changePrice_Click;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35.07752F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 64.92248F));
            tableLayoutPanel4.Controls.Add(label1, 0, 0);
            tableLayoutPanel4.Controls.Add(label5_newPrice, 0, 4);
            tableLayoutPanel4.Controls.Add(label2, 0, 1);
            tableLayoutPanel4.Controls.Add(label3, 0, 2);
            tableLayoutPanel4.Controls.Add(label4, 0, 3);
            tableLayoutPanel4.Controls.Add(label5_sProductName, 1, 0);
            tableLayoutPanel4.Controls.Add(label6_sProductWeight, 1, 1);
            tableLayoutPanel4.Controls.Add(label7_sProductPrice, 1, 2);
            tableLayoutPanel4.Controls.Add(label8_sProductQuantity, 1, 3);
            tableLayoutPanel4.Controls.Add(textBox1, 1, 4);
            tableLayoutPanel4.Location = new Point(19, 94);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 5;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel4.Size = new Size(522, 314);
            tableLayoutPanel4.TabIndex = 0;
            tableLayoutPanel4.Paint += tableLayoutPanel4_Paint;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(21, 18);
            label1.Name = "label1";
            label1.Size = new Size(140, 25);
            label1.TabIndex = 0;
            label1.Text = "Product Name : ";
            // 
            // label5_newPrice
            // 
            label5_newPrice.Anchor = AnchorStyles.None;
            label5_newPrice.AutoSize = true;
            label5_newPrice.Location = new Point(47, 268);
            label5_newPrice.Name = "label5_newPrice";
            label5_newPrice.Size = new Size(89, 25);
            label5_newPrice.TabIndex = 1;
            label5_newPrice.Text = "New Price";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(17, 80);
            label2.Name = "label2";
            label2.Size = new Size(149, 25);
            label2.TabIndex = 0;
            label2.Text = "Product Weight : ";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Location = new Point(26, 142);
            label3.Name = "label3";
            label3.Size = new Size(130, 25);
            label3.TabIndex = 0;
            label3.Text = "Product Price : ";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Location = new Point(5, 204);
            label4.Name = "label4";
            label4.Size = new Size(173, 25);
            label4.TabIndex = 0;
            label4.Text = "Product Quantities : ";
            // 
            // label5_sProductName
            // 
            label5_sProductName.Anchor = AnchorStyles.None;
            label5_sProductName.AutoSize = true;
            label5_sProductName.Location = new Point(352, 18);
            label5_sProductName.Name = "label5_sProductName";
            label5_sProductName.Size = new Size(0, 25);
            label5_sProductName.TabIndex = 3;
            label5_sProductName.Click += label5_sProductName_Click;
            // 
            // label6_sProductWeight
            // 
            label6_sProductWeight.Anchor = AnchorStyles.None;
            label6_sProductWeight.AutoSize = true;
            label6_sProductWeight.Location = new Point(352, 80);
            label6_sProductWeight.Name = "label6_sProductWeight";
            label6_sProductWeight.Size = new Size(0, 25);
            label6_sProductWeight.TabIndex = 3;
            // 
            // label7_sProductPrice
            // 
            label7_sProductPrice.Anchor = AnchorStyles.None;
            label7_sProductPrice.AutoSize = true;
            label7_sProductPrice.Location = new Point(352, 142);
            label7_sProductPrice.Name = "label7_sProductPrice";
            label7_sProductPrice.Size = new Size(0, 25);
            label7_sProductPrice.TabIndex = 3;
            // 
            // label8_sProductQuantity
            // 
            label8_sProductQuantity.Anchor = AnchorStyles.None;
            label8_sProductQuantity.AutoSize = true;
            label8_sProductQuantity.Location = new Point(352, 204);
            label8_sProductQuantity.Name = "label8_sProductQuantity";
            label8_sProductQuantity.Size = new Size(0, 25);
            label8_sProductQuantity.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.None;
            textBox1.BackColor = Color.FromArgb(120, 149, 203);
            textBox1.Location = new Point(227, 265);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(251, 31);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Form5_ChangePrice
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1257, 678);
            ControlBox = false;
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form5_ChangePrice";
            StartPosition = FormStartPosition.CenterScreen;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1_medicines).EndInit();
            panel2.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Button button1_back;
        private Label label1_changePrice;
        private TableLayoutPanel tableLayoutPanel3;
        private Panel panel1;
        private DataGridView dataGridView1_medicines;
        private Panel panel2;
        private TableLayoutPanel tableLayoutPanel4;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private Label label5_newPrice;
        private Label label5_sProductName;
        private Label label6_sProductWeight;
        private Label label7_sProductPrice;
        private Label label8_sProductQuantity;
        private Button button1_changePrice;
        private ErrorProvider errorProvider1;
    }
}