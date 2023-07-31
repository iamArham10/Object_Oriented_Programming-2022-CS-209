namespace Space_Successions
{
    partial class Game_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game_Form));
            GameLoop = new System.Windows.Forms.Timer(components);
            lbl_playerScore = new Label();
            lbl_SplayerScore = new Label();
            lbl_pLayerHealth = new Label();
            lbl_phihrothHealth = new Label();
            lbl_sPlayerHealth = new Label();
            lbl_SsiriousHealth = new Label();
            lbl_siriusHealth = new Label();
            lbl_SphihrothHealth = new Label();
            lbl_strocridHealth = new Label();
            lbl_SstrocridHealth = new Label();
            lbl_thrarkreilsHealth = new Label();
            lbl_SthrarkreilsHealth = new Label();
            SuspendLayout();
            // 
            // GameLoop
            // 
            GameLoop.Enabled = true;
            GameLoop.Tick += GameLoop_Tick;
            // 
            // lbl_playerScore
            // 
            lbl_playerScore.AutoSize = true;
            lbl_playerScore.BackColor = Color.Transparent;
            lbl_playerScore.Font = new Font("Ravie", 6F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_playerScore.ForeColor = Color.Red;
            lbl_playerScore.Location = new Point(203, 672);
            lbl_playerScore.Name = "lbl_playerScore";
            lbl_playerScore.Size = new Size(53, 17);
            lbl_playerScore.TabIndex = 0;
            lbl_playerScore.Text = "Score";
            // 
            // lbl_SplayerScore
            // 
            lbl_SplayerScore.AutoSize = true;
            lbl_SplayerScore.BackColor = Color.Black;
            lbl_SplayerScore.Font = new Font("Monotype Corsiva", 10F, FontStyle.Italic, GraphicsUnit.Point);
            lbl_SplayerScore.ForeColor = Color.White;
            lbl_SplayerScore.Location = new Point(215, 705);
            lbl_SplayerScore.Name = "lbl_SplayerScore";
            lbl_SplayerScore.Size = new Size(19, 24);
            lbl_SplayerScore.TabIndex = 0;
            lbl_SplayerScore.Text = "0";
            // 
            // lbl_pLayerHealth
            // 
            lbl_pLayerHealth.AutoSize = true;
            lbl_pLayerHealth.Font = new Font("Ravie", 6F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_pLayerHealth.ForeColor = Color.Red;
            lbl_pLayerHealth.Location = new Point(22, 672);
            lbl_pLayerHealth.Name = "lbl_pLayerHealth";
            lbl_pLayerHealth.Size = new Size(117, 17);
            lbl_pLayerHealth.TabIndex = 1;
            lbl_pLayerHealth.Text = "Player Health";
            // 
            // lbl_phihrothHealth
            // 
            lbl_phihrothHealth.AutoSize = true;
            lbl_phihrothHealth.Font = new Font("Ravie", 6F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_phihrothHealth.ForeColor = Color.Red;
            lbl_phihrothHealth.Location = new Point(532, 672);
            lbl_phihrothHealth.Name = "lbl_phihrothHealth";
            lbl_phihrothHealth.Size = new Size(134, 17);
            lbl_phihrothHealth.TabIndex = 1;
            lbl_phihrothHealth.Text = "Phihroth Health";
            // 
            // lbl_sPlayerHealth
            // 
            lbl_sPlayerHealth.AutoSize = true;
            lbl_sPlayerHealth.BackColor = Color.Black;
            lbl_sPlayerHealth.Font = new Font("Monotype Corsiva", 10F, FontStyle.Italic, GraphicsUnit.Point);
            lbl_sPlayerHealth.ForeColor = Color.White;
            lbl_sPlayerHealth.Location = new Point(64, 705);
            lbl_sPlayerHealth.Name = "lbl_sPlayerHealth";
            lbl_sPlayerHealth.Size = new Size(19, 24);
            lbl_sPlayerHealth.TabIndex = 0;
            lbl_sPlayerHealth.Text = "0";
            // 
            // lbl_SsiriousHealth
            // 
            lbl_SsiriousHealth.AutoSize = true;
            lbl_SsiriousHealth.BackColor = Color.Black;
            lbl_SsiriousHealth.Font = new Font("Monotype Corsiva", 10F, FontStyle.Italic, GraphicsUnit.Point);
            lbl_SsiriousHealth.ForeColor = Color.White;
            lbl_SsiriousHealth.Location = new Point(376, 705);
            lbl_SsiriousHealth.Name = "lbl_SsiriousHealth";
            lbl_SsiriousHealth.Size = new Size(19, 24);
            lbl_SsiriousHealth.TabIndex = 0;
            lbl_SsiriousHealth.Text = "0";
            // 
            // lbl_siriusHealth
            // 
            lbl_siriusHealth.AutoSize = true;
            lbl_siriusHealth.Font = new Font("Ravie", 6F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_siriusHealth.ForeColor = Color.Red;
            lbl_siriusHealth.Location = new Point(329, 672);
            lbl_siriusHealth.Name = "lbl_siriusHealth";
            lbl_siriusHealth.Size = new Size(114, 17);
            lbl_siriusHealth.TabIndex = 1;
            lbl_siriusHealth.Text = "Sirius Health";
            // 
            // lbl_SphihrothHealth
            // 
            lbl_SphihrothHealth.AutoSize = true;
            lbl_SphihrothHealth.BackColor = Color.Black;
            lbl_SphihrothHealth.Font = new Font("Monotype Corsiva", 10F, FontStyle.Italic, GraphicsUnit.Point);
            lbl_SphihrothHealth.ForeColor = Color.White;
            lbl_SphihrothHealth.Location = new Point(591, 705);
            lbl_SphihrothHealth.Name = "lbl_SphihrothHealth";
            lbl_SphihrothHealth.Size = new Size(19, 24);
            lbl_SphihrothHealth.TabIndex = 0;
            lbl_SphihrothHealth.Text = "0";
            // 
            // lbl_strocridHealth
            // 
            lbl_strocridHealth.AutoSize = true;
            lbl_strocridHealth.Font = new Font("Ravie", 6F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_strocridHealth.ForeColor = Color.Red;
            lbl_strocridHealth.Location = new Point(730, 672);
            lbl_strocridHealth.Name = "lbl_strocridHealth";
            lbl_strocridHealth.Size = new Size(134, 17);
            lbl_strocridHealth.TabIndex = 1;
            lbl_strocridHealth.Text = "Strocrid Health";
            // 
            // lbl_SstrocridHealth
            // 
            lbl_SstrocridHealth.AutoSize = true;
            lbl_SstrocridHealth.BackColor = Color.Black;
            lbl_SstrocridHealth.Font = new Font("Monotype Corsiva", 10F, FontStyle.Italic, GraphicsUnit.Point);
            lbl_SstrocridHealth.ForeColor = Color.White;
            lbl_SstrocridHealth.Location = new Point(790, 705);
            lbl_SstrocridHealth.Name = "lbl_SstrocridHealth";
            lbl_SstrocridHealth.Size = new Size(19, 24);
            lbl_SstrocridHealth.TabIndex = 0;
            lbl_SstrocridHealth.Text = "0";
            // 
            // lbl_thrarkreilsHealth
            // 
            lbl_thrarkreilsHealth.AutoSize = true;
            lbl_thrarkreilsHealth.Font = new Font("Ravie", 6F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_thrarkreilsHealth.ForeColor = Color.Red;
            lbl_thrarkreilsHealth.Location = new Point(911, 672);
            lbl_thrarkreilsHealth.Name = "lbl_thrarkreilsHealth";
            lbl_thrarkreilsHealth.Size = new Size(160, 17);
            lbl_thrarkreilsHealth.TabIndex = 1;
            lbl_thrarkreilsHealth.Text = "Thrarkreils Health";
            // 
            // lbl_SthrarkreilsHealth
            // 
            lbl_SthrarkreilsHealth.AutoSize = true;
            lbl_SthrarkreilsHealth.BackColor = Color.Black;
            lbl_SthrarkreilsHealth.Font = new Font("Monotype Corsiva", 10F, FontStyle.Italic, GraphicsUnit.Point);
            lbl_SthrarkreilsHealth.ForeColor = Color.White;
            lbl_SthrarkreilsHealth.Location = new Point(978, 705);
            lbl_SthrarkreilsHealth.Name = "lbl_SthrarkreilsHealth";
            lbl_SthrarkreilsHealth.Size = new Size(19, 24);
            lbl_SthrarkreilsHealth.TabIndex = 0;
            lbl_SthrarkreilsHealth.Text = "0";
            // 
            // Game_Form
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.Backgroun2;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1358, 738);
            Controls.Add(lbl_siriusHealth);
            Controls.Add(lbl_thrarkreilsHealth);
            Controls.Add(lbl_strocridHealth);
            Controls.Add(lbl_phihrothHealth);
            Controls.Add(lbl_pLayerHealth);
            Controls.Add(lbl_sPlayerHealth);
            Controls.Add(lbl_SthrarkreilsHealth);
            Controls.Add(lbl_SstrocridHealth);
            Controls.Add(lbl_SphihrothHealth);
            Controls.Add(lbl_SsiriousHealth);
            Controls.Add(lbl_SplayerScore);
            Controls.Add(lbl_playerScore);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimizeBox = false;
            Name = "Game_Form";
            Text = "Space Succession";
            WindowState = FormWindowState.Maximized;
            Load += Game_Form_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer GameLoop;
        private Label lbl_playerScore;
        private Label lbl_SplayerScore;
        private Label lbl_pLayerHealth;
        private Label lbl_phihrothHealth;
        private Label lbl_sPlayerHealth;
        private Label lbl_SsiriousHealth;
        private Label lbl_siriusHealth;
        private Label lbl_SphihrothHealth;
        private Label lbl_strocridHealth;
        private Label lbl_SstrocridHealth;
        private Label lbl_thrarkreilsHealth;
        private Label lbl_SthrarkreilsHealth;
    }
}