namespace Pharmacy_Management_System
{
    partial class Main_Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Menu));
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            pictureBox2 = new PictureBox();
            tableLayoutPanel4 = new TableLayoutPanel();
            tableLayoutPanel5 = new TableLayoutPanel();
            lbl_username = new Label();
            lbl_password = new Label();
            tb_password = new TextBox();
            tb_username = new TextBox();
            btn_signIn = new Button();
            tableLayoutPanel6 = new TableLayoutPanel();
            btn_SignUp = new Button();
            toolTip1 = new ToolTip(components);
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1284, 510);
            panel1.TabIndex = 0;
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
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tableLayoutPanel1.Size = new Size(1284, 510);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tableLayoutPanel2.Controls.Add(pictureBox1, 0, 0);
            tableLayoutPanel2.Controls.Add(pictureBox3, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(1278, 96);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.Logo_Gradient;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(10, 10);
            pictureBox1.Margin = new Padding(10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(235, 76);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.None;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(265, 10);
            pictureBox3.Margin = new Padding(10);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(1003, 76);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 54.1471062F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45.8528938F));
            tableLayoutPanel3.Controls.Add(pictureBox2, 0, 0);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel4, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 105);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(1278, 402);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Fill;
            pictureBox2.Image = Properties.Resources.Pharmacist;
            pictureBox2.Location = new Point(3, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(686, 396);
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(tableLayoutPanel5, 0, 0);
            tableLayoutPanel4.Controls.Add(tableLayoutPanel6, 0, 1);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(695, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 72.72727F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 27.272728F));
            tableLayoutPanel4.Size = new Size(580, 396);
            tableLayoutPanel4.TabIndex = 1;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.Anchor = AnchorStyles.None;
            tableLayoutPanel5.ColumnCount = 3;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.9445724F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 72.05543F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 93F));
            tableLayoutPanel5.Controls.Add(lbl_username, 0, 0);
            tableLayoutPanel5.Controls.Add(lbl_password, 0, 1);
            tableLayoutPanel5.Controls.Add(tb_password, 1, 1);
            tableLayoutPanel5.Controls.Add(tb_username, 1, 0);
            tableLayoutPanel5.Controls.Add(btn_signIn, 2, 1);
            tableLayoutPanel5.Location = new Point(13, 67);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 2;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Size = new Size(553, 153);
            tableLayoutPanel5.TabIndex = 0;
            // 
            // lbl_username
            // 
            lbl_username.AutoSize = true;
            lbl_username.BackColor = Color.FromArgb(29, 93, 155);
            lbl_username.Dock = DockStyle.Fill;
            lbl_username.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_username.ForeColor = Color.White;
            lbl_username.Location = new Point(5, 20);
            lbl_username.Margin = new Padding(5, 20, 5, 20);
            lbl_username.Name = "lbl_username";
            lbl_username.Size = new Size(118, 36);
            lbl_username.TabIndex = 0;
            lbl_username.Text = "Username";
            lbl_username.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_password
            // 
            lbl_password.AutoSize = true;
            lbl_password.BackColor = Color.FromArgb(29, 93, 155);
            lbl_password.Dock = DockStyle.Fill;
            lbl_password.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_password.ForeColor = Color.White;
            lbl_password.Location = new Point(5, 96);
            lbl_password.Margin = new Padding(5, 20, 5, 20);
            lbl_password.Name = "lbl_password";
            lbl_password.Size = new Size(118, 37);
            lbl_password.TabIndex = 1;
            lbl_password.Text = "Password";
            lbl_password.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tb_password
            // 
            tb_password.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tb_password.BackColor = Color.FromArgb(41, 93, 155);
            tb_password.Cursor = Cursors.IBeam;
            tb_password.ForeColor = Color.White;
            tb_password.Location = new Point(131, 99);
            tb_password.Name = "tb_password";
            tb_password.PasswordChar = '*';
            tb_password.Size = new Size(325, 31);
            tb_password.TabIndex = 2;
            // 
            // tb_username
            // 
            tb_username.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tb_username.BackColor = Color.FromArgb(41, 93, 155);
            tb_username.Cursor = Cursors.IBeam;
            tb_username.ForeColor = Color.White;
            tb_username.Location = new Point(131, 22);
            tb_username.Name = "tb_username";
            tb_username.Size = new Size(325, 31);
            tb_username.TabIndex = 2;
            // 
            // btn_signIn
            // 
            btn_signIn.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btn_signIn.BackgroundImage = Properties.Resources.SignIn;
            btn_signIn.BackgroundImageLayout = ImageLayout.Zoom;
            btn_signIn.FlatAppearance.BorderSize = 0;
            btn_signIn.FlatStyle = FlatStyle.Flat;
            btn_signIn.Location = new Point(462, 97);
            btn_signIn.Name = "btn_signIn";
            btn_signIn.Size = new Size(88, 34);
            btn_signIn.TabIndex = 3;
            btn_signIn.UseVisualStyleBackColor = true;
            btn_signIn.Click += btn_signIn_Click_1;
            btn_signIn.MouseMove += btn_signIn_MouseMove;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 2;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 71.60279F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 28.397213F));
            tableLayoutPanel6.Controls.Add(btn_SignUp, 1, 1);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(3, 291);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 2;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.Size = new Size(574, 102);
            tableLayoutPanel6.TabIndex = 1;
            // 
            // btn_SignUp
            // 
            btn_SignUp.BackColor = Color.FromArgb(29, 93, 155);
            btn_SignUp.Cursor = Cursors.Hand;
            btn_SignUp.Dock = DockStyle.Fill;
            btn_SignUp.FlatAppearance.BorderSize = 0;
            btn_SignUp.FlatStyle = FlatStyle.Flat;
            btn_SignUp.ForeColor = Color.White;
            btn_SignUp.Location = new Point(419, 59);
            btn_SignUp.Margin = new Padding(8);
            btn_SignUp.Name = "btn_SignUp";
            btn_SignUp.Size = new Size(147, 35);
            btn_SignUp.TabIndex = 0;
            btn_SignUp.Text = "Sign Up";
            btn_SignUp.UseVisualStyleBackColor = false;
            btn_SignUp.Click += btn_SignUp_Click_1;
            // 
            // Main_Menu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1284, 510);
            Controls.Add(panel1);
            Name = "Main_Menu";
            Text = "Main_Menu";
            Load += Main_Menu_Load;
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            tableLayoutPanel6.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private PictureBox pictureBox1;
        private TableLayoutPanel tableLayoutPanel3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private TableLayoutPanel tableLayoutPanel4;
        private TableLayoutPanel tableLayoutPanel5;
        private Label lbl_username;
        private Label lbl_password;
        private TextBox tb_password;
        private TextBox tb_username;
        private Button btn_signIn;
        private ToolTip toolTip1;
        private TableLayoutPanel tableLayoutPanel6;
        private Button btn_SignUp;
    }
}