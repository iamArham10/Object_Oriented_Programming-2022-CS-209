namespace Pharmacy_Management_System
{
    partial class Sign_Up
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
            pictureBox2 = new PictureBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            tableLayoutPanel3 = new TableLayoutPanel();
            lbl_username = new Label();
            lbl_password = new Label();
            tb_Username = new TextBox();
            tb_Password = new TextBox();
            btn_SignUp = new Button();
            btn_Back = new Button();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(btn_Back, 0, 1);
            tableLayoutPanel1.Controls.Add(pictureBox2, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Left;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 37.01923F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 62.98077F));
            tableLayoutPanel1.Size = new Size(229, 693);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top;
            pictureBox2.Image = Properties.Resources.pills;
            pictureBox2.Location = new Point(4, 5);
            pictureBox2.Margin = new Padding(4, 5, 4, 5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(220, 246);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(panel1, 0, 0);
            tableLayoutPanel2.Controls.Add(panel2, 0, 1);
            tableLayoutPanel2.Location = new Point(229, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 442F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(1051, 693);
            tableLayoutPanel2.TabIndex = 0;
            tableLayoutPanel2.Paint += tableLayoutPanel2_Paint;
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(869, 245);
            panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Logo;
            pictureBox1.Location = new Point(0, -17);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(869, 278);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(tableLayoutPanel3);
            panel2.Controls.Add(btn_SignUp);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(4, 256);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(867, 432);
            panel2.TabIndex = 2;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.Anchor = AnchorStyles.None;
            tableLayoutPanel3.AutoSize = true;
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.90411F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 81.0958939F));
            tableLayoutPanel3.Controls.Add(lbl_username, 0, 0);
            tableLayoutPanel3.Controls.Add(lbl_password, 0, 1);
            tableLayoutPanel3.Controls.Add(tb_Username, 1, 0);
            tableLayoutPanel3.Controls.Add(tb_Password, 1, 1);
            tableLayoutPanel3.Location = new Point(61, 88);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 33F));
            tableLayoutPanel3.Size = new Size(727, 228);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // lbl_username
            // 
            lbl_username.Anchor = AnchorStyles.None;
            lbl_username.AutoSize = true;
            lbl_username.Location = new Point(23, 44);
            lbl_username.Name = "lbl_username";
            lbl_username.Size = new Size(91, 25);
            lbl_username.TabIndex = 0;
            lbl_username.Text = "Username";
            // 
            // lbl_password
            // 
            lbl_password.Anchor = AnchorStyles.None;
            lbl_password.AutoSize = true;
            lbl_password.Location = new Point(25, 158);
            lbl_password.Name = "lbl_password";
            lbl_password.Size = new Size(87, 25);
            lbl_password.TabIndex = 0;
            lbl_password.Text = "Password";
            // 
            // tb_Username
            // 
            tb_Username.Anchor = AnchorStyles.None;
            tb_Username.Location = new Point(153, 41);
            tb_Username.Name = "tb_Username";
            tb_Username.Size = new Size(557, 31);
            tb_Username.TabIndex = 1;
            // 
            // tb_Password
            // 
            tb_Password.Anchor = AnchorStyles.None;
            tb_Password.Location = new Point(155, 155);
            tb_Password.Name = "tb_Password";
            tb_Password.Size = new Size(553, 31);
            tb_Password.TabIndex = 1;
            // 
            // btn_SignUp
            // 
            btn_SignUp.AutoSize = true;
            btn_SignUp.Location = new Point(631, 325);
            btn_SignUp.Margin = new Padding(4, 5, 4, 5);
            btn_SignUp.Name = "btn_SignUp";
            btn_SignUp.Size = new Size(141, 68);
            btn_SignUp.TabIndex = 2;
            btn_SignUp.Text = "Sign Up";
            btn_SignUp.UseVisualStyleBackColor = true;
            btn_SignUp.Click += btn_SignUp_Click;
            // 
            // btn_Back
            // 
            btn_Back.BackColor = Color.FromArgb(117, 194, 246);
            btn_Back.Dock = DockStyle.Top;
            btn_Back.Font = new Font("Verdana", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Back.ForeColor = Color.White;
            btn_Back.Location = new Point(3, 259);
            btn_Back.Name = "btn_Back";
            btn_Back.Size = new Size(223, 124);
            btn_Back.TabIndex = 1;
            btn_Back.Text = "Back";
            btn_Back.UseVisualStyleBackColor = false;
            btn_Back.Click += btn_Back_Click;
            // 
            // Sign_Up
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 234, 221);
            ClientSize = new Size(1280, 693);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Name = "Sign_Up";
            Text = "Sign_Up";
            Load += Sign_Up_Load;
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private Label lbl_username;
        private Label lbl_password;
        private TextBox tb_Username;
        private TextBox tb_Password;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private PictureBox pictureBox2;
        private Button btn_SignUp;
        private Button btn_Back;
    }
}