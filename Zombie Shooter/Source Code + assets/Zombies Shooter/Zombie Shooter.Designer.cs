namespace Zombies_Shooter
{
    partial class Zombie_shooter_frm
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
            this.components = new System.ComponentModel.Container();
            this.txt_ammo = new System.Windows.Forms.Label();
            this.txt_kills = new System.Windows.Forms.Label();
            this.txt_health = new System.Windows.Forms.Label();
            this.healthBar = new System.Windows.Forms.ProgressBar();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.txt_gameOver = new System.Windows.Forms.Label();
            this.btn_restart = new System.Windows.Forms.Button();
            this.player = new System.Windows.Forms.PictureBox();
            this.txt_devBy = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_ammo
            // 
            this.txt_ammo.AutoSize = true;
            this.txt_ammo.Font = new System.Drawing.Font("High Tower Text", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ammo.ForeColor = System.Drawing.Color.White;
            this.txt_ammo.Location = new System.Drawing.Point(12, 7);
            this.txt_ammo.Name = "txt_ammo";
            this.txt_ammo.Size = new System.Drawing.Size(115, 28);
            this.txt_ammo.TabIndex = 0;
            this.txt_ammo.Text = "Ammo : 0";
            // 
            // txt_kills
            // 
            this.txt_kills.AutoSize = true;
            this.txt_kills.Font = new System.Drawing.Font("High Tower Text", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_kills.ForeColor = System.Drawing.Color.White;
            this.txt_kills.Location = new System.Drawing.Point(330, 7);
            this.txt_kills.Name = "txt_kills";
            this.txt_kills.Size = new System.Drawing.Size(95, 28);
            this.txt_kills.TabIndex = 0;
            this.txt_kills.Text = "Kills : 0";
            // 
            // txt_health
            // 
            this.txt_health.AutoSize = true;
            this.txt_health.Font = new System.Drawing.Font("High Tower Text", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_health.ForeColor = System.Drawing.Color.White;
            this.txt_health.Location = new System.Drawing.Point(671, 7);
            this.txt_health.Name = "txt_health";
            this.txt_health.Size = new System.Drawing.Size(89, 28);
            this.txt_health.TabIndex = 0;
            this.txt_health.Text = "Health ";
            // 
            // healthBar
            // 
            this.healthBar.Location = new System.Drawing.Point(756, 9);
            this.healthBar.Name = "healthBar";
            this.healthBar.Size = new System.Drawing.Size(216, 23);
            this.healthBar.TabIndex = 1;
            this.healthBar.Value = 100;
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.maintimerevent);
            // 
            // txt_gameOver
            // 
            this.txt_gameOver.AutoSize = true;
            this.txt_gameOver.Font = new System.Drawing.Font("High Tower Text", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_gameOver.ForeColor = System.Drawing.Color.White;
            this.txt_gameOver.Location = new System.Drawing.Point(325, 228);
            this.txt_gameOver.Name = "txt_gameOver";
            this.txt_gameOver.Size = new System.Drawing.Size(350, 75);
            this.txt_gameOver.TabIndex = 3;
            this.txt_gameOver.Text = "Game Over";
            this.txt_gameOver.Visible = false;
            // 
            // btn_restart
            // 
            this.btn_restart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_restart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_restart.Font = new System.Drawing.Font("High Tower Text", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_restart.ForeColor = System.Drawing.Color.White;
            this.btn_restart.Image = global::Zombies_Shooter.Properties.Resources.restart;
            this.btn_restart.Location = new System.Drawing.Point(406, 335);
            this.btn_restart.Name = "btn_restart";
            this.btn_restart.Size = new System.Drawing.Size(198, 66);
            this.btn_restart.TabIndex = 4;
            this.btn_restart.Text = "Restart";
            this.btn_restart.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_restart.UseVisualStyleBackColor = false;
            this.btn_restart.Visible = false;
            this.btn_restart.Click += new System.EventHandler(this.btn_restart_Click);
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Transparent;
            this.player.Image = global::Zombies_Shooter.Properties.Resources.up;
            this.player.Location = new System.Drawing.Point(465, 534);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(71, 100);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.player.TabIndex = 2;
            this.player.TabStop = false;
            // 
            // txt_devBy
            // 
            this.txt_devBy.AutoSize = true;
            this.txt_devBy.Font = new System.Drawing.Font("High Tower Text", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_devBy.ForeColor = System.Drawing.Color.White;
            this.txt_devBy.Location = new System.Drawing.Point(703, 627);
            this.txt_devBy.Name = "txt_devBy";
            this.txt_devBy.Size = new System.Drawing.Size(269, 25);
            this.txt_devBy.TabIndex = 5;
            this.txt_devBy.Text = "Developed by Arihant Jain";
            this.txt_devBy.Visible = false;
            // 
            // Zombie_shooter_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.txt_devBy);
            this.Controls.Add(this.btn_restart);
            this.Controls.Add(this.txt_gameOver);
            this.Controls.Add(this.player);
            this.Controls.Add(this.healthBar);
            this.Controls.Add(this.txt_health);
            this.Controls.Add(this.txt_kills);
            this.Controls.Add(this.txt_ammo);
            this.Name = "Zombie_shooter_frm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zombie Shooter";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Zombie_shooter_frm_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Zombie_shooter_frm_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txt_ammo;
        private System.Windows.Forms.Label txt_kills;
        private System.Windows.Forms.Label txt_health;
        private System.Windows.Forms.ProgressBar healthBar;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label txt_gameOver;
        private System.Windows.Forms.Button btn_restart;
        private System.Windows.Forms.Label txt_devBy;
    }
}

