namespace T_rex_Endless_Runner
{
    partial class TRex
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
            this.txt_gameOver = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.txt_Score = new System.Windows.Forms.Label();
            this.btn_restart = new System.Windows.Forms.Button();
            this.ground = new System.Windows.Forms.PictureBox();
            this.tree1 = new System.Windows.Forms.PictureBox();
            this.tree2 = new System.Windows.Forms.PictureBox();
            this.Dino = new System.Windows.Forms.PictureBox();
            this.txt_devBy = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tree1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tree2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dino)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_gameOver
            // 
            this.txt_gameOver.AutoSize = true;
            this.txt_gameOver.Font = new System.Drawing.Font("High Tower Text", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_gameOver.Location = new System.Drawing.Point(367, 91);
            this.txt_gameOver.Name = "txt_gameOver";
            this.txt_gameOver.Size = new System.Drawing.Size(265, 57);
            this.txt_gameOver.TabIndex = 4;
            this.txt_gameOver.Text = "Game Over";
            this.txt_gameOver.Visible = false;
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // txt_Score
            // 
            this.txt_Score.AutoSize = true;
            this.txt_Score.Font = new System.Drawing.Font("High Tower Text", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Score.ForeColor = System.Drawing.Color.Black;
            this.txt_Score.Location = new System.Drawing.Point(9, 10);
            this.txt_Score.Name = "txt_Score";
            this.txt_Score.Size = new System.Drawing.Size(90, 25);
            this.txt_Score.TabIndex = 5;
            this.txt_Score.Text = "Score: 0";
            // 
            // btn_restart
            // 
            this.btn_restart.AutoSize = true;
            this.btn_restart.Font = new System.Drawing.Font("High Tower Text", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_restart.Image = global::T_rex_Endless_Runner.Properties.Resources.Restart;
            this.btn_restart.Location = new System.Drawing.Point(445, 160);
            this.btn_restart.Name = "btn_restart";
            this.btn_restart.Size = new System.Drawing.Size(111, 82);
            this.btn_restart.TabIndex = 6;
            this.btn_restart.Text = "Restart";
            this.btn_restart.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btn_restart.UseVisualStyleBackColor = true;
            this.btn_restart.Visible = false;
            this.btn_restart.Click += new System.EventHandler(this.btn_restart_Click);
            // 
            // ground
            // 
            this.ground.BackColor = System.Drawing.Color.Black;
            this.ground.Location = new System.Drawing.Point(-10, 428);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(1001, 72);
            this.ground.TabIndex = 3;
            this.ground.TabStop = false;
            // 
            // tree1
            // 
            this.tree1.Image = global::T_rex_Endless_Runner.Properties.Resources.obstacle_1;
            this.tree1.Location = new System.Drawing.Point(500, 336);
            this.tree1.Name = "tree1";
            this.tree1.Size = new System.Drawing.Size(46, 92);
            this.tree1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tree1.TabIndex = 2;
            this.tree1.TabStop = false;
            this.tree1.Tag = "obstacle";
            // 
            // tree2
            // 
            this.tree2.Image = global::T_rex_Endless_Runner.Properties.Resources.obstacle_2;
            this.tree2.Location = new System.Drawing.Point(863, 362);
            this.tree2.Name = "tree2";
            this.tree2.Size = new System.Drawing.Size(53, 66);
            this.tree2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tree2.TabIndex = 1;
            this.tree2.TabStop = false;
            this.tree2.Tag = "obstacle";
            // 
            // Dino
            // 
            this.Dino.Image = global::T_rex_Endless_Runner.Properties.Resources.running;
            this.Dino.Location = new System.Drawing.Point(19, 342);
            this.Dino.Name = "Dino";
            this.Dino.Size = new System.Drawing.Size(80, 86);
            this.Dino.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Dino.TabIndex = 0;
            this.Dino.TabStop = false;
            // 
            // txt_devBy
            // 
            this.txt_devBy.AutoSize = true;
            this.txt_devBy.Font = new System.Drawing.Font("High Tower Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_devBy.Location = new System.Drawing.Point(373, 279);
            this.txt_devBy.Name = "txt_devBy";
            this.txt_devBy.Size = new System.Drawing.Size(253, 22);
            this.txt_devBy.TabIndex = 7;
            this.txt_devBy.Text = "Developed by Arihant Jain";
            this.txt_devBy.Visible = false;
            // 
            // TRex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.txt_devBy);
            this.Controls.Add(this.btn_restart);
            this.Controls.Add(this.txt_Score);
            this.Controls.Add(this.txt_gameOver);
            this.Controls.Add(this.tree1);
            this.Controls.Add(this.tree2);
            this.Controls.Add(this.Dino);
            this.Name = "TRex";
            this.Text = "TRex";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TRex_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TRex_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tree1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tree2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dino)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Dino;
        private System.Windows.Forms.PictureBox tree2;
        private System.Windows.Forms.PictureBox tree1;
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.Label txt_gameOver;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label txt_Score;
        private System.Windows.Forms.Button btn_restart;
        private System.Windows.Forms.Label txt_devBy;
    }
}