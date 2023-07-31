namespace Space_Successions
{
    partial class EndGame
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
            label1 = new Label();
            label2 = new Label();
            lbl_sScore = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Showcard Gothic", 30F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(406, 201);
            label1.Name = "label1";
            label1.Size = new Size(392, 74);
            label1.TabIndex = 0;
            label1.Text = "Game Ended";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Showcard Gothic", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(462, 332);
            label2.Name = "label2";
            label2.Size = new Size(132, 37);
            label2.TabIndex = 1;
            label2.Text = "Score : ";
            // 
            // lbl_sScore
            // 
            lbl_sScore.AutoSize = true;
            lbl_sScore.BackColor = Color.Transparent;
            lbl_sScore.Font = new Font("Showcard Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_sScore.ForeColor = Color.White;
            lbl_sScore.Location = new Point(589, 313);
            lbl_sScore.Name = "lbl_sScore";
            lbl_sScore.Size = new Size(188, 60);
            lbl_sScore.TabIndex = 2;
            lbl_sScore.Text = "label3";
            // 
            // EndGame
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Background;
            ClientSize = new Size(1214, 598);
            Controls.Add(lbl_sScore);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "EndGame";
            Text = "EndGame";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label lbl_sScore;
    }
}