namespace Flappy_Bird
{
    partial class FlappyBird
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
            this.txt_Score = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.txt_gameOver = new System.Windows.Forms.Label();
            this.txt_devBy = new System.Windows.Forms.Label();
            this.btn_restart = new System.Windows.Forms.Button();
            this.ground = new System.Windows.Forms.PictureBox();
            this.pipeTop = new System.Windows.Forms.PictureBox();
            this.pipeBottom = new System.Windows.Forms.PictureBox();
            this.bird = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bird)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_Score
            // 
            this.txt_Score.AutoSize = true;
            this.txt_Score.Font = new System.Drawing.Font("High Tower Text", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Score.Location = new System.Drawing.Point(13, 12);
            this.txt_Score.Name = "txt_Score";
            this.txt_Score.Size = new System.Drawing.Size(98, 28);
            this.txt_Score.TabIndex = 4;
            this.txt_Score.Text = "Score: 0";
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // txt_gameOver
            // 
            this.txt_gameOver.AutoSize = true;
            this.txt_gameOver.Font = new System.Drawing.Font("High Tower Text", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_gameOver.Location = new System.Drawing.Point(217, 216);
            this.txt_gameOver.Name = "txt_gameOver";
            this.txt_gameOver.Size = new System.Drawing.Size(265, 57);
            this.txt_gameOver.TabIndex = 5;
            this.txt_gameOver.Text = "Game Over";
            this.txt_gameOver.Visible = false;
            // 
            // txt_devBy
            // 
            this.txt_devBy.AutoSize = true;
            this.txt_devBy.BackColor = System.Drawing.Color.Transparent;
            this.txt_devBy.Font = new System.Drawing.Font("High Tower Text", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_devBy.Location = new System.Drawing.Point(209, 577);
            this.txt_devBy.Name = "txt_devBy";
            this.txt_devBy.Size = new System.Drawing.Size(282, 25);
            this.txt_devBy.TabIndex = 6;
            this.txt_devBy.Text = "Developed By ~Arihant Jain";
            this.txt_devBy.Visible = false;
            // 
            // btn_restart
            // 
            this.btn_restart.AutoSize = true;
            this.btn_restart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_restart.Font = new System.Drawing.Font("High Tower Text", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_restart.Image = global::Flappy_Bird.Properties.Resources._1688390454534;
            this.btn_restart.Location = new System.Drawing.Point(267, 320);
            this.btn_restart.Name = "btn_restart";
            this.btn_restart.Size = new System.Drawing.Size(165, 64);
            this.btn_restart.TabIndex = 7;
            this.btn_restart.Text = "Restart";
            this.btn_restart.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_restart.UseVisualStyleBackColor = false;
            this.btn_restart.Visible = false;
            this.btn_restart.Click += new System.EventHandler(this.btn_restart_Click);
            // 
            // ground
            // 
            this.ground.Image = global::Flappy_Bird.Properties.Resources.ground;
            this.ground.Location = new System.Drawing.Point(-8, 602);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(697, 106);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 3;
            this.ground.TabStop = false;
            // 
            // pipeTop
            // 
            this.pipeTop.Image = global::Flappy_Bird.Properties.Resources.pipedown;
            this.pipeTop.Location = new System.Drawing.Point(332, -88);
            this.pipeTop.Name = "pipeTop";
            this.pipeTop.Size = new System.Drawing.Size(100, 300);
            this.pipeTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeTop.TabIndex = 2;
            this.pipeTop.TabStop = false;
            // 
            // pipeBottom
            // 
            this.pipeBottom.Image = global::Flappy_Bird.Properties.Resources.pipe;
            this.pipeBottom.Location = new System.Drawing.Point(575, 363);
            this.pipeBottom.Name = "pipeBottom";
            this.pipeBottom.Size = new System.Drawing.Size(100, 300);
            this.pipeBottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeBottom.TabIndex = 1;
            this.pipeBottom.TabStop = false;
            // 
            // bird
            // 
            this.bird.Image = global::Flappy_Bird.Properties.Resources.bird;
            this.bird.Location = new System.Drawing.Point(112, 238);
            this.bird.Name = "bird";
            this.bird.Size = new System.Drawing.Size(79, 61);
            this.bird.TabIndex = 0;
            this.bird.TabStop = false;
            // 
            // FlappyBird
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(684, 661);
            this.Controls.Add(this.txt_devBy);
            this.Controls.Add(this.btn_restart);
            this.Controls.Add(this.txt_gameOver);
            this.Controls.Add(this.txt_Score);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.pipeTop);
            this.Controls.Add(this.pipeBottom);
            this.Controls.Add(this.bird);
            this.MaximumSize = new System.Drawing.Size(700, 700);
            this.Name = "FlappyBird";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FlappyBird_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FlappyBird_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bird)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox bird;
        private System.Windows.Forms.PictureBox pipeBottom;
        private System.Windows.Forms.PictureBox pipeTop;
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.Label txt_Score;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label txt_gameOver;
        private System.Windows.Forms.Label txt_devBy;
        private System.Windows.Forms.Button btn_restart;
    }
}

