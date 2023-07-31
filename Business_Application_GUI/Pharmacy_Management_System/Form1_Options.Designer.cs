namespace Pharmacy_Management_System
{
    partial class Form1_Options
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
            tableLayoutPanel1 = new TableLayoutPanel();
            button1_takeOrder = new Button();
            button2_addProduct = new Button();
            button3_viewProduct = new Button();
            button4_changePrice = new Button();
            button6_removeProduct = new Button();
            button7_addStock = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Controls.Add(button1_takeOrder, 0, 0);
            tableLayoutPanel1.Controls.Add(button2_addProduct, 1, 0);
            tableLayoutPanel1.Controls.Add(button3_viewProduct, 2, 0);
            tableLayoutPanel1.Controls.Add(button4_changePrice, 2, 1);
            tableLayoutPanel1.Controls.Add(button6_removeProduct, 0, 1);
            tableLayoutPanel1.Controls.Add(button7_addStock, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(10);
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new Size(1141, 590);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // button1_takeOrder
            // 
            button1_takeOrder.BackColor = Color.FromArgb(161, 204, 209);
            button1_takeOrder.Dock = DockStyle.Fill;
            button1_takeOrder.FlatStyle = FlatStyle.Popup;
            button1_takeOrder.Font = new Font("Arial Rounded MT Bold", 13F, FontStyle.Regular, GraphicsUnit.Point);
            button1_takeOrder.ForeColor = Color.White;
            button1_takeOrder.Location = new Point(20, 20);
            button1_takeOrder.Margin = new Padding(10);
            button1_takeOrder.Name = "button1_takeOrder";
            button1_takeOrder.Padding = new Padding(5);
            button1_takeOrder.Size = new Size(353, 265);
            button1_takeOrder.TabIndex = 0;
            button1_takeOrder.Text = "Take Order";
            button1_takeOrder.UseVisualStyleBackColor = false;
            button1_takeOrder.Click += button1_takeOrder_Click;
            // 
            // button2_addProduct
            // 
            button2_addProduct.BackColor = Color.FromArgb(146, 136, 248);
            button2_addProduct.BackgroundImageLayout = ImageLayout.Zoom;
            button2_addProduct.Dock = DockStyle.Fill;
            button2_addProduct.FlatStyle = FlatStyle.Popup;
            button2_addProduct.Font = new Font("Arial Rounded MT Bold", 13F, FontStyle.Regular, GraphicsUnit.Point);
            button2_addProduct.ForeColor = Color.White;
            button2_addProduct.Location = new Point(393, 20);
            button2_addProduct.Margin = new Padding(10);
            button2_addProduct.Name = "button2_addProduct";
            button2_addProduct.Padding = new Padding(5);
            button2_addProduct.Size = new Size(353, 265);
            button2_addProduct.TabIndex = 0;
            button2_addProduct.Text = "Add Product";
            button2_addProduct.TextImageRelation = TextImageRelation.ImageAboveText;
            button2_addProduct.UseVisualStyleBackColor = false;
            button2_addProduct.Click += button2_addProduct_Click;
            // 
            // button3_viewProduct
            // 
            button3_viewProduct.BackColor = Color.FromArgb(22, 75, 96);
            button3_viewProduct.Dock = DockStyle.Fill;
            button3_viewProduct.FlatStyle = FlatStyle.Popup;
            button3_viewProduct.Font = new Font("Arial Rounded MT Bold", 13F, FontStyle.Regular, GraphicsUnit.Point);
            button3_viewProduct.ForeColor = Color.White;
            button3_viewProduct.Location = new Point(766, 20);
            button3_viewProduct.Margin = new Padding(10);
            button3_viewProduct.Name = "button3_viewProduct";
            button3_viewProduct.Padding = new Padding(5);
            button3_viewProduct.Size = new Size(355, 265);
            button3_viewProduct.TabIndex = 0;
            button3_viewProduct.Text = "View Products";
            button3_viewProduct.UseVisualStyleBackColor = false;
            button3_viewProduct.Click += button3_viewProduct_Click;
            // 
            // button4_changePrice
            // 
            button4_changePrice.BackColor = Color.FromArgb(134, 200, 188);
            button4_changePrice.Dock = DockStyle.Fill;
            button4_changePrice.FlatStyle = FlatStyle.Flat;
            button4_changePrice.Font = new Font("Arial Rounded MT Bold", 13F, FontStyle.Regular, GraphicsUnit.Point);
            button4_changePrice.ForeColor = Color.White;
            button4_changePrice.Location = new Point(766, 305);
            button4_changePrice.Margin = new Padding(10);
            button4_changePrice.Name = "button4_changePrice";
            button4_changePrice.Padding = new Padding(5);
            button4_changePrice.Size = new Size(355, 265);
            button4_changePrice.TabIndex = 0;
            button4_changePrice.Text = "Change Product Price";
            button4_changePrice.UseVisualStyleBackColor = false;
            button4_changePrice.Click += button4_changePrice_Click;
            // 
            // button6_removeProduct
            // 
            button6_removeProduct.BackColor = Color.FromArgb(239, 98, 98);
            button6_removeProduct.Dock = DockStyle.Fill;
            button6_removeProduct.FlatStyle = FlatStyle.Popup;
            button6_removeProduct.Font = new Font("Arial Rounded MT Bold", 13F, FontStyle.Regular, GraphicsUnit.Point);
            button6_removeProduct.ForeColor = Color.White;
            button6_removeProduct.Location = new Point(20, 305);
            button6_removeProduct.Margin = new Padding(10);
            button6_removeProduct.Name = "button6_removeProduct";
            button6_removeProduct.Padding = new Padding(5);
            button6_removeProduct.Size = new Size(353, 265);
            button6_removeProduct.TabIndex = 0;
            button6_removeProduct.Text = "Remove Product";
            button6_removeProduct.UseVisualStyleBackColor = false;
            button6_removeProduct.Click += button6_removeProduct_Click;
            // 
            // button7_addStock
            // 
            button7_addStock.BackColor = Color.FromArgb(29, 93, 155);
            button7_addStock.Dock = DockStyle.Fill;
            button7_addStock.FlatStyle = FlatStyle.Flat;
            button7_addStock.Font = new Font("Arial Rounded MT Bold", 13F, FontStyle.Regular, GraphicsUnit.Point);
            button7_addStock.ForeColor = Color.White;
            button7_addStock.Location = new Point(393, 305);
            button7_addStock.Margin = new Padding(10);
            button7_addStock.Name = "button7_addStock";
            button7_addStock.Padding = new Padding(5);
            button7_addStock.Size = new Size(353, 265);
            button7_addStock.TabIndex = 0;
            button7_addStock.Text = "Add Product Stock";
            button7_addStock.UseVisualStyleBackColor = false;
            button7_addStock.Click += button7_addStock_Click;
            // 
            // Form1_Options
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1141, 590);
            ControlBox = false;
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1_Options";
            StartPosition = FormStartPosition.CenterScreen;
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button button1_takeOrder;
        private Button button2_addProduct;
        private Button button3_viewProduct;
        private Button button4_changePrice;
        private Button button6_removeProduct;
        private Button button7_addStock;
    }
}