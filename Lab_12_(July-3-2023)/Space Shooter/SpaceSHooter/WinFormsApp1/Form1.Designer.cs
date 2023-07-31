namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            pbPlayerShip = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pbPlayerShip).BeginInit();
            SuspendLayout();
            // 
            // pbPlayerShip
            // 
            pbPlayerShip.Anchor = AnchorStyles.None;
            pbPlayerShip.BackColor = Color.Transparent;
            pbPlayerShip.Image = Properties.Resources.player;
            pbPlayerShip.Location = new Point(551, 446);
            pbPlayerShip.Name = "pbPlayerShip";
            pbPlayerShip.Size = new Size(127, 114);
            pbPlayerShip.SizeMode = PictureBoxSizeMode.Zoom;
            pbPlayerShip.TabIndex = 0;
            pbPlayerShip.TabStop = false;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 10;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background;
            ClientSize = new Size(1216, 583);
            Controls.Add(pbPlayerShip);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load_1;
            ((System.ComponentModel.ISupportInitialize)pbPlayerShip).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pbPlayerShip;
        private System.Windows.Forms.Timer timer1;
    }
}