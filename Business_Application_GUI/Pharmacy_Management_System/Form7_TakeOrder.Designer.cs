namespace Pharmacy_Management_System
{
    partial class Form7_TakeOrder
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7_TakeOrder));
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel4 = new TableLayoutPanel();
            btn_search = new Button();
            tb_search = new TextBox();
            dgv_availableProducts = new DataGridView();
            tableLayoutPanel5 = new TableLayoutPanel();
            tableLayoutPanel6 = new TableLayoutPanel();
            lbl_total = new Label();
            btn_checkout = new Button();
            btn_remove = new Button();
            lbl_sTotalPrice = new Label();
            tableLayoutPanel7 = new TableLayoutPanel();
            tableLayoutPanel8 = new TableLayoutPanel();
            lbl_productPrice = new Label();
            lbl_productName = new Label();
            lbl_sProductName = new Label();
            lbl_productWeight = new Label();
            lbl_sProductWeight = new Label();
            lbl_sProductPrice = new Label();
            tableLayoutPanel9 = new TableLayoutPanel();
            lbl_enterQuantities = new Label();
            trackb_productQuantities = new TrackBar();
            btn_addtoCart = new Button();
            lbl_selectedQuantities = new Label();
            dgv_selectedProducts = new DataGridView();
            btn_back = new Button();
            toolTip1 = new ToolTip(components);
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_availableProducts).BeginInit();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            tableLayoutPanel8.SuspendLayout();
            tableLayoutPanel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackb_productQuantities).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_selectedProducts).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 4.77477455F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 95.22523F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 1);
            tableLayoutPanel1.Controls.Add(btn_back, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.1354F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 90.8646F));
            tableLayoutPanel1.Size = new Size(1198, 593);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 52.9355164F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 47.0644836F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 1, 0);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel5, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(60, 57);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(1135, 533);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(tableLayoutPanel4, 0, 0);
            tableLayoutPanel3.Controls.Add(dgv_availableProducts, 0, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(603, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 8.458647F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 91.54135F));
            tableLayoutPanel3.Size = new Size(529, 527);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 3;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 356F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 47F));
            tableLayoutPanel4.Controls.Add(btn_search, 2, 0);
            tableLayoutPanel4.Controls.Add(tb_search, 1, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(523, 38);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // btn_search
            // 
            btn_search.BackColor = Color.Transparent;
            btn_search.BackgroundImage = Properties.Resources.Search;
            btn_search.BackgroundImageLayout = ImageLayout.Zoom;
            btn_search.Dock = DockStyle.Fill;
            btn_search.FlatAppearance.BorderSize = 0;
            btn_search.FlatStyle = FlatStyle.Flat;
            btn_search.Location = new Point(479, 3);
            btn_search.Name = "btn_search";
            btn_search.Size = new Size(41, 32);
            btn_search.TabIndex = 0;
            btn_search.UseVisualStyleBackColor = false;
            // 
            // tb_search
            // 
            tb_search.BackColor = Color.White;
            tb_search.Dock = DockStyle.Fill;
            tb_search.Location = new Point(123, 3);
            tb_search.Name = "tb_search";
            tb_search.Size = new Size(350, 31);
            tb_search.TabIndex = 1;
            // 
            // dgv_availableProducts
            // 
            dgv_availableProducts.AllowUserToAddRows = false;
            dgv_availableProducts.AllowUserToDeleteRows = false;
            dgv_availableProducts.AllowUserToResizeColumns = false;
            dgv_availableProducts.AllowUserToResizeRows = false;
            dgv_availableProducts.BackgroundColor = Color.White;
            dgv_availableProducts.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgv_availableProducts.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(120, 149, 203);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgv_availableProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgv_availableProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.Purple;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgv_availableProducts.DefaultCellStyle = dataGridViewCellStyle2;
            dgv_availableProducts.Dock = DockStyle.Fill;
            dgv_availableProducts.GridColor = Color.FromArgb(197, 223, 248);
            dgv_availableProducts.Location = new Point(3, 47);
            dgv_availableProducts.MultiSelect = false;
            dgv_availableProducts.Name = "dgv_availableProducts";
            dgv_availableProducts.ReadOnly = true;
            dgv_availableProducts.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgv_availableProducts.RowHeadersVisible = false;
            dgv_availableProducts.RowHeadersWidth = 62;
            dgv_availableProducts.RowTemplate.Height = 33;
            dgv_availableProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_availableProducts.Size = new Size(523, 477);
            dgv_availableProducts.TabIndex = 1;
            dgv_availableProducts.CellClick += dgv_availableProducts_CellClick;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Controls.Add(tableLayoutPanel6, 0, 2);
            tableLayoutPanel5.Controls.Add(tableLayoutPanel7, 0, 0);
            tableLayoutPanel5.Controls.Add(dgv_selectedProducts, 0, 1);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(3, 3);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 3;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutPanel5.Size = new Size(594, 527);
            tableLayoutPanel5.TabIndex = 1;
            tableLayoutPanel5.Paint += tableLayoutPanel5_Paint;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 5;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.2222214F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.2222214F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel6.Controls.Add(lbl_total, 1, 0);
            tableLayoutPanel6.Controls.Add(btn_checkout, 3, 0);
            tableLayoutPanel6.Controls.Add(btn_remove, 0, 0);
            tableLayoutPanel6.Controls.Add(lbl_sTotalPrice, 2, 0);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(3, 484);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 1;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.Size = new Size(588, 40);
            tableLayoutPanel6.TabIndex = 0;
            tableLayoutPanel6.Paint += tableLayoutPanel6_Paint;
            // 
            // lbl_total
            // 
            lbl_total.Anchor = AnchorStyles.None;
            lbl_total.AutoSize = true;
            lbl_total.FlatStyle = FlatStyle.Flat;
            lbl_total.Location = new Point(203, 7);
            lbl_total.Name = "lbl_total";
            lbl_total.Size = new Size(49, 25);
            lbl_total.TabIndex = 1;
            lbl_total.Text = "Total";
            // 
            // btn_checkout
            // 
            btn_checkout.AutoSize = true;
            btn_checkout.BackColor = Color.Transparent;
            btn_checkout.BackgroundImage = (Image)resources.GetObject("btn_checkout.BackgroundImage");
            btn_checkout.BackgroundImageLayout = ImageLayout.Zoom;
            btn_checkout.Cursor = Cursors.Hand;
            btn_checkout.Dock = DockStyle.Fill;
            btn_checkout.FlatAppearance.BorderSize = 0;
            btn_checkout.FlatStyle = FlatStyle.Flat;
            btn_checkout.Location = new Point(459, 3);
            btn_checkout.Name = "btn_checkout";
            btn_checkout.Size = new Size(59, 34);
            btn_checkout.TabIndex = 0;
            btn_checkout.UseVisualStyleBackColor = false;
            btn_checkout.Click += btn_checkout_Click;
            btn_checkout.MouseHover += btn_checkout_MouseHover;
            // 
            // btn_remove
            // 
            btn_remove.BackColor = Color.FromArgb(74, 85, 162);
            btn_remove.Cursor = Cursors.Hand;
            btn_remove.Dock = DockStyle.Fill;
            btn_remove.FlatAppearance.BorderSize = 0;
            btn_remove.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            btn_remove.Location = new Point(3, 3);
            btn_remove.Name = "btn_remove";
            btn_remove.Size = new Size(124, 34);
            btn_remove.TabIndex = 2;
            btn_remove.Text = "Remove";
            btn_remove.UseVisualStyleBackColor = false;
            btn_remove.Click += btn_remove_Click;
            // 
            // lbl_sTotalPrice
            // 
            lbl_sTotalPrice.Anchor = AnchorStyles.None;
            lbl_sTotalPrice.AutoSize = true;
            lbl_sTotalPrice.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_sTotalPrice.Location = new Point(381, 9);
            lbl_sTotalPrice.Name = "lbl_sTotalPrice";
            lbl_sTotalPrice.Size = new Size(19, 21);
            lbl_sTotalPrice.TabIndex = 3;
            lbl_sTotalPrice.Text = "0";
            lbl_sTotalPrice.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 1;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.Controls.Add(tableLayoutPanel8, 0, 0);
            tableLayoutPanel7.Controls.Add(tableLayoutPanel9, 0, 1);
            tableLayoutPanel7.Dock = DockStyle.Fill;
            tableLayoutPanel7.Location = new Point(3, 3);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 2;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 69.6808548F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 30.319149F));
            tableLayoutPanel7.Size = new Size(588, 186);
            tableLayoutPanel7.TabIndex = 1;
            // 
            // tableLayoutPanel8
            // 
            tableLayoutPanel8.ColumnCount = 2;
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.2577324F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 74.74227F));
            tableLayoutPanel8.Controls.Add(lbl_productPrice, 0, 2);
            tableLayoutPanel8.Controls.Add(lbl_productName, 0, 0);
            tableLayoutPanel8.Controls.Add(lbl_sProductName, 1, 0);
            tableLayoutPanel8.Controls.Add(lbl_productWeight, 0, 1);
            tableLayoutPanel8.Controls.Add(lbl_sProductWeight, 1, 1);
            tableLayoutPanel8.Controls.Add(lbl_sProductPrice, 1, 2);
            tableLayoutPanel8.Dock = DockStyle.Fill;
            tableLayoutPanel8.Location = new Point(3, 3);
            tableLayoutPanel8.Name = "tableLayoutPanel8";
            tableLayoutPanel8.RowCount = 3;
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel8.Size = new Size(582, 123);
            tableLayoutPanel8.TabIndex = 0;
            // 
            // lbl_productPrice
            // 
            lbl_productPrice.Anchor = AnchorStyles.None;
            lbl_productPrice.AutoSize = true;
            lbl_productPrice.Location = new Point(15, 90);
            lbl_productPrice.Name = "lbl_productPrice";
            lbl_productPrice.Size = new Size(116, 25);
            lbl_productPrice.TabIndex = 0;
            lbl_productPrice.Text = "Product Price";
            // 
            // lbl_productName
            // 
            lbl_productName.Anchor = AnchorStyles.None;
            lbl_productName.AutoSize = true;
            lbl_productName.Location = new Point(10, 8);
            lbl_productName.Name = "lbl_productName";
            lbl_productName.Size = new Size(126, 25);
            lbl_productName.TabIndex = 0;
            lbl_productName.Text = "Product Name";
            lbl_productName.Click += lbl_productName_Click;
            // 
            // lbl_sProductName
            // 
            lbl_sProductName.Anchor = AnchorStyles.None;
            lbl_sProductName.AutoSize = true;
            lbl_sProductName.Location = new Point(301, 8);
            lbl_sProductName.Name = "lbl_sProductName";
            lbl_sProductName.Size = new Size(126, 25);
            lbl_sProductName.TabIndex = 0;
            lbl_sProductName.Text = "Product Name";
            lbl_sProductName.Click += lbl_productName_Click;
            // 
            // lbl_productWeight
            // 
            lbl_productWeight.Anchor = AnchorStyles.None;
            lbl_productWeight.AutoSize = true;
            lbl_productWeight.Location = new Point(6, 49);
            lbl_productWeight.Name = "lbl_productWeight";
            lbl_productWeight.Size = new Size(135, 25);
            lbl_productWeight.TabIndex = 0;
            lbl_productWeight.Text = "Product Weight";
            // 
            // lbl_sProductWeight
            // 
            lbl_sProductWeight.Anchor = AnchorStyles.None;
            lbl_sProductWeight.AutoSize = true;
            lbl_sProductWeight.Location = new Point(297, 49);
            lbl_sProductWeight.Name = "lbl_sProductWeight";
            lbl_sProductWeight.Size = new Size(135, 25);
            lbl_sProductWeight.TabIndex = 0;
            lbl_sProductWeight.Text = "Product Weight";
            // 
            // lbl_sProductPrice
            // 
            lbl_sProductPrice.Anchor = AnchorStyles.None;
            lbl_sProductPrice.AutoSize = true;
            lbl_sProductPrice.Location = new Point(306, 90);
            lbl_sProductPrice.Name = "lbl_sProductPrice";
            lbl_sProductPrice.Size = new Size(116, 25);
            lbl_sProductPrice.TabIndex = 0;
            lbl_sProductPrice.Text = "Product Price";
            // 
            // tableLayoutPanel9
            // 
            tableLayoutPanel9.ColumnCount = 4;
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 56.8316841F));
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 13.2673264F));
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 76F));
            tableLayoutPanel9.Controls.Add(lbl_enterQuantities, 0, 0);
            tableLayoutPanel9.Controls.Add(trackb_productQuantities, 1, 0);
            tableLayoutPanel9.Controls.Add(btn_addtoCart, 3, 0);
            tableLayoutPanel9.Controls.Add(lbl_selectedQuantities, 2, 0);
            tableLayoutPanel9.Dock = DockStyle.Fill;
            tableLayoutPanel9.Location = new Point(3, 132);
            tableLayoutPanel9.Name = "tableLayoutPanel9";
            tableLayoutPanel9.RowCount = 1;
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel9.Size = new Size(582, 51);
            tableLayoutPanel9.TabIndex = 1;
            tableLayoutPanel9.Paint += tableLayoutPanel9_Paint;
            // 
            // lbl_enterQuantities
            // 
            lbl_enterQuantities.Anchor = AnchorStyles.None;
            lbl_enterQuantities.AutoSize = true;
            lbl_enterQuantities.Location = new Point(4, 13);
            lbl_enterQuantities.Name = "lbl_enterQuantities";
            lbl_enterQuantities.Size = new Size(143, 25);
            lbl_enterQuantities.TabIndex = 0;
            lbl_enterQuantities.Text = "Select Quantities";
            // 
            // trackb_productQuantities
            // 
            trackb_productQuantities.Anchor = AnchorStyles.None;
            trackb_productQuantities.BackColor = Color.White;
            trackb_productQuantities.Enabled = false;
            trackb_productQuantities.Location = new Point(154, 3);
            trackb_productQuantities.Minimum = 1;
            trackb_productQuantities.Name = "trackb_productQuantities";
            trackb_productQuantities.Size = new Size(281, 45);
            trackb_productQuantities.TabIndex = 3;
            trackb_productQuantities.TickStyle = TickStyle.Both;
            toolTip1.SetToolTip(trackb_productQuantities, "Select Quantities");
            trackb_productQuantities.Value = 1;
            trackb_productQuantities.Scroll += trackb_productQuantities_Scroll;
            // 
            // btn_addtoCart
            // 
            btn_addtoCart.BackColor = Color.Transparent;
            btn_addtoCart.BackgroundImage = (Image)resources.GetObject("btn_addtoCart.BackgroundImage");
            btn_addtoCart.BackgroundImageLayout = ImageLayout.Zoom;
            btn_addtoCart.Dock = DockStyle.Fill;
            btn_addtoCart.FlatAppearance.BorderSize = 0;
            btn_addtoCart.FlatStyle = FlatStyle.Flat;
            btn_addtoCart.Location = new Point(508, 3);
            btn_addtoCart.Name = "btn_addtoCart";
            btn_addtoCart.Size = new Size(71, 45);
            btn_addtoCart.TabIndex = 2;
            btn_addtoCart.TextAlign = ContentAlignment.BottomRight;
            btn_addtoCart.TextImageRelation = TextImageRelation.TextBeforeImage;
            btn_addtoCart.UseVisualStyleBackColor = false;
            btn_addtoCart.Click += btn_addtoCart_Click;
            btn_addtoCart.MouseMove += btn__MouseMove;
            // 
            // lbl_selectedQuantities
            // 
            lbl_selectedQuantities.Anchor = AnchorStyles.Left;
            lbl_selectedQuantities.AutoSize = true;
            lbl_selectedQuantities.Location = new Point(441, 13);
            lbl_selectedQuantities.Name = "lbl_selectedQuantities";
            lbl_selectedQuantities.Size = new Size(0, 25);
            lbl_selectedQuantities.TabIndex = 4;
            // 
            // dgv_selectedProducts
            // 
            dgv_selectedProducts.AllowUserToAddRows = false;
            dgv_selectedProducts.AllowUserToDeleteRows = false;
            dgv_selectedProducts.AllowUserToResizeColumns = false;
            dgv_selectedProducts.BackgroundColor = Color.White;
            dgv_selectedProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_selectedProducts.Dock = DockStyle.Fill;
            dgv_selectedProducts.GridColor = Color.White;
            dgv_selectedProducts.Location = new Point(3, 195);
            dgv_selectedProducts.MultiSelect = false;
            dgv_selectedProducts.Name = "dgv_selectedProducts";
            dgv_selectedProducts.RowHeadersVisible = false;
            dgv_selectedProducts.RowHeadersWidth = 62;
            dgv_selectedProducts.RowTemplate.Height = 33;
            dgv_selectedProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_selectedProducts.Size = new Size(588, 283);
            dgv_selectedProducts.TabIndex = 2;
            // 
            // btn_back
            // 
            btn_back.BackColor = Color.Transparent;
            btn_back.BackgroundImage = Properties.Resources.Left_2;
            btn_back.BackgroundImageLayout = ImageLayout.Zoom;
            btn_back.Cursor = Cursors.Hand;
            btn_back.Dock = DockStyle.Fill;
            btn_back.FlatAppearance.BorderSize = 0;
            btn_back.FlatStyle = FlatStyle.Flat;
            btn_back.Location = new Point(3, 3);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(51, 48);
            btn_back.TabIndex = 1;
            btn_back.UseVisualStyleBackColor = false;
            btn_back.Click += btn_back_Click;
            // 
            // Form7_TakeOrder
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1198, 593);
            ControlBox = false;
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form7_TakeOrder";
            StartPosition = FormStartPosition.CenterScreen;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_availableProducts).EndInit();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            tableLayoutPanel7.ResumeLayout(false);
            tableLayoutPanel8.ResumeLayout(false);
            tableLayoutPanel8.PerformLayout();
            tableLayoutPanel9.ResumeLayout(false);
            tableLayoutPanel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackb_productQuantities).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_selectedProducts).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel4;
        private Button btn_search;
        private DataGridView dgv_availableProducts;
        private TextBox tb_search;
        private Button btn_back;
        private TableLayoutPanel tableLayoutPanel5;
        private TableLayoutPanel tableLayoutPanel6;
        private Button btn_checkout;
        private ToolTip toolTip1;
        private TableLayoutPanel tableLayoutPanel7;
        private TableLayoutPanel tableLayoutPanel8;
        private Label lbl_productWeight;
        private Label lbl_productName;
        private Label lbl_productPrice;
        private Label lbl_sProductName;
        private Label lbl_sProductWeight;
        private Label lbl_sProductPrice;
        private TableLayoutPanel tableLayoutPanel9;
        private Label lbl_enterQuantities;
        private Button btn_addtoCart;
        private TrackBar trackb_productQuantities;
        private Label lbl_selectedQuantities;
        private Label lbl_total;
        private Button btn_remove;
        private Label lbl_sTotalPrice;
        private DataGridView dgv_selectedProducts;
    }
}