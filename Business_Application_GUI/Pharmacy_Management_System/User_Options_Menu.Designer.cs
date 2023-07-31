namespace Pharmacy_Management_System
{
    partial class User_Options_Menu
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
            panel1 = new Panel();
            panel6_userInfo = new Panel();
            button1_back = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            label1_Name = new Label();
            label2_userName = new Label();
            label3_Password = new Label();
            label4_userPassword = new Label();
            panel5 = new Panel();
            pictureBox2_UserProfile = new PictureBox();
            panel3 = new Panel();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            panel4_formPanel = new Panel();
            panel1.SuspendLayout();
            panel6_userInfo.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2_UserProfile).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel6_userInfo);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(326, 722);
            panel1.TabIndex = 0;
            // 
            // panel6_userInfo
            // 
            panel6_userInfo.Controls.Add(button1_back);
            panel6_userInfo.Controls.Add(tableLayoutPanel1);
            panel6_userInfo.Dock = DockStyle.Fill;
            panel6_userInfo.Location = new Point(0, 404);
            panel6_userInfo.Margin = new Padding(4);
            panel6_userInfo.Name = "panel6_userInfo";
            panel6_userInfo.Size = new Size(326, 318);
            panel6_userInfo.TabIndex = 2;
            // 
            // button1_back
            // 
            button1_back.BackColor = Color.FromArgb(8, 65, 119);
            button1_back.Dock = DockStyle.Bottom;
            button1_back.Font = new Font("Open Sans", 14F, FontStyle.Regular, GraphicsUnit.Point);
            button1_back.ForeColor = Color.White;
            button1_back.Location = new Point(0, 251);
            button1_back.Name = "button1_back";
            button1_back.Size = new Size(326, 67);
            button1_back.TabIndex = 1;
            button1_back.Text = "Log Out";
            button1_back.UseVisualStyleBackColor = false;
            button1_back.Click += button1_back_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(label1_Name, 0, 0);
            tableLayoutPanel1.Controls.Add(label2_userName, 1, 0);
            tableLayoutPanel1.Controls.Add(label3_Password, 0, 1);
            tableLayoutPanel1.Controls.Add(label4_userPassword, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(326, 178);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1_Name
            // 
            label1_Name.Anchor = AnchorStyles.None;
            label1_Name.AutoSize = true;
            label1_Name.Font = new Font("Open Sans", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1_Name.Location = new Point(47, 30);
            label1_Name.Margin = new Padding(4, 0, 4, 0);
            label1_Name.Name = "label1_Name";
            label1_Name.Size = new Size(68, 28);
            label1_Name.TabIndex = 0;
            label1_Name.Text = "Name";
            // 
            // label2_userName
            // 
            label2_userName.Anchor = AnchorStyles.None;
            label2_userName.AutoSize = true;
            label2_userName.Font = new Font("Open Sans Condensed SemiBold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label2_userName.Location = new Point(216, 30);
            label2_userName.Margin = new Padding(4, 0, 4, 0);
            label2_userName.Name = "label2_userName";
            label2_userName.Size = new Size(57, 28);
            label2_userName.TabIndex = 1;
            label2_userName.Text = "label2";
            // 
            // label3_Password
            // 
            label3_Password.Anchor = AnchorStyles.None;
            label3_Password.AutoSize = true;
            label3_Password.Font = new Font("Open Sans", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3_Password.Location = new Point(6, 119);
            label3_Password.Margin = new Padding(4, 0, 4, 0);
            label3_Password.Name = "label3_Password";
            label3_Password.Size = new Size(151, 28);
            label3_Password.TabIndex = 2;
            label3_Password.Text = "User Password";
            // 
            // label4_userPassword
            // 
            label4_userPassword.Anchor = AnchorStyles.None;
            label4_userPassword.AutoSize = true;
            label4_userPassword.Font = new Font("Open Sans Condensed SemiBold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label4_userPassword.Location = new Point(216, 119);
            label4_userPassword.Margin = new Padding(4, 0, 4, 0);
            label4_userPassword.Name = "label4_userPassword";
            label4_userPassword.Size = new Size(57, 28);
            label4_userPassword.TabIndex = 3;
            label4_userPassword.Text = "label4";
            // 
            // panel5
            // 
            panel5.Controls.Add(pictureBox2_UserProfile);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 109);
            panel5.Margin = new Padding(2);
            panel5.Name = "panel5";
            panel5.Padding = new Padding(10);
            panel5.Size = new Size(326, 295);
            panel5.TabIndex = 1;
            // 
            // pictureBox2_UserProfile
            // 
            pictureBox2_UserProfile.Dock = DockStyle.Fill;
            pictureBox2_UserProfile.Image = Properties.Resources.Profile_Picture;
            pictureBox2_UserProfile.Location = new Point(10, 10);
            pictureBox2_UserProfile.Margin = new Padding(2);
            pictureBox2_UserProfile.Name = "pictureBox2_UserProfile";
            pictureBox2_UserProfile.Padding = new Padding(25);
            pictureBox2_UserProfile.Size = new Size(306, 275);
            pictureBox2_UserProfile.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2_UserProfile.TabIndex = 0;
            pictureBox2_UserProfile.TabStop = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(pictureBox1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(2);
            panel3.Name = "panel3";
            panel3.Size = new Size(326, 109);
            panel3.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.Logo_Gradient;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Padding = new Padding(10);
            pictureBox1.Size = new Size(326, 109);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBox2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(326, 0);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1233, 107);
            panel2.TabIndex = 1;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Fill;
            pictureBox2.Image = Properties.Resources.Header;
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1233, 107);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // panel4_formPanel
            // 
            panel4_formPanel.Dock = DockStyle.Fill;
            panel4_formPanel.Location = new Point(326, 107);
            panel4_formPanel.Margin = new Padding(2);
            panel4_formPanel.Name = "panel4_formPanel";
            panel4_formPanel.Size = new Size(1233, 615);
            panel4_formPanel.TabIndex = 2;
            // 
            // User_Options_Menu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1559, 722);
            Controls.Add(panel4_formPanel);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(2);
            Name = "User_Options_Menu";
            Text = "User_Options";
            panel1.ResumeLayout(false);
            panel6_userInfo.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2_UserProfile).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Panel panel5;
        private PictureBox pictureBox2_UserProfile;
        private Panel panel4_formPanel;
        private Panel panel6_userInfo;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1_Name;
        private Label label2_userName;
        private Label label3_Password;
        private Label label4_userPassword;
        private Button button1_back;
        private PictureBox pictureBox2;
    }
}