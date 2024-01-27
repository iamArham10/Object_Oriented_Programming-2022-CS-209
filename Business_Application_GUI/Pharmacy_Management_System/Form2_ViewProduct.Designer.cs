namespace Pharmacy_Management_System
{
    partial class Form2_ViewProduct
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2_ViewProduct));
            dataGridView1_Products = new DataGridView();
            tableLayoutPanel1 = new TableLayoutPanel();
            btn_back = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1_Products).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1_Products
            // 
            dataGridView1_Products.AllowUserToAddRows = false;
            dataGridView1_Products.AllowUserToDeleteRows = false;
            dataGridView1_Products.AllowUserToResizeColumns = false;
            dataGridView1_Products.AllowUserToResizeRows = false;
            dataGridView1_Products.Anchor = AnchorStyles.None;
            dataGridView1_Products.BackgroundColor = Color.White;
            dataGridView1_Products.BorderStyle = BorderStyle.None;
            dataGridView1_Products.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            dataGridView1_Products.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(197, 223, 248);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridView1_Products.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1_Products.GridColor = Color.White;
            dataGridView1_Products.Location = new Point(244, 151);
            dataGridView1_Products.MultiSelect = false;
            dataGridView1_Products.Name = "dataGridView1_Products";
            dataGridView1_Products.ReadOnly = true;
            dataGridView1_Products.RowHeadersWidth = 62;
            dataGridView1_Products.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView1_Products.RowTemplate.Height = 33;
            dataGridView1_Products.Size = new Size(707, 366);
            dataGridView1_Products.TabIndex = 0;
            dataGridView1_Products.CellContentClick += dataGridView1_Products_CellContentClick;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 6.21669626F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 93.7833F));
            tableLayoutPanel1.Controls.Add(btn_back, 0, 0);
            tableLayoutPanel1.Controls.Add(dataGridView1_Products, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 8.957655F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 91.04234F));
            tableLayoutPanel1.Size = new Size(1126, 614);
            tableLayoutPanel1.TabIndex = 1;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // btn_back
            // 
            btn_back.BackColor = Color.Transparent;
            btn_back.BackgroundImage = (Image)resources.GetObject("btn_back.BackgroundImage");
            btn_back.BackgroundImageLayout = ImageLayout.Zoom;
            btn_back.Dock = DockStyle.Fill;
            btn_back.FlatAppearance.BorderSize = 0;
            btn_back.FlatStyle = FlatStyle.Flat;
            btn_back.Location = new Point(3, 3);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(64, 49);
            btn_back.TabIndex = 1;
            btn_back.UseVisualStyleBackColor = false;
            btn_back.Click += btn_back_Click;
            // 
            // Form2_ViewProduct
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1126, 614);
            ControlBox = false;
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form2_ViewProduct";
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)dataGridView1_Products).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel tableLayoutPanel1;
        private Button button1_Back;
        private Label label1;
        private DataGridView dataGridView1_Products;
        private Button btn_back;
    }
}