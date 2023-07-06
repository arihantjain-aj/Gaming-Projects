using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T_rex_Endless_Runner
{
    public partial class TRex : Form
    {
        bool jumping = false;
        int jumpSpeed, force, score, obstacleSpeed,ranSize;
        Random ran = new Random();

        public TRex()
        {
            InitializeComponent();
            GameReset();
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            Dino.Top += jumpSpeed;
            txt_Score.Text = "Score: " + score;
            tree1.Left -= obstacleSpeed;
            tree2.Left -= obstacleSpeed;

            if (jumping == true && force < 0) jumping = false;
            
            if (jumping== true)
            {
                jumpSpeed = -17;
                force -= 1;
            }
            else
            {
                jumpSpeed = 17;
            }

            if (Dino.Top > 341 && jumping == false)
            {
                force = 17;
                Dino.Top = 342;
                jumpSpeed = 0;
            }

            if (tree1.Left < -100)
            {
                tree1.Left = this.ClientSize.Width + ran.Next(100, 300);
                ranSize = ran.Next(30, 50);
                tree1.Size = new Size(ranSize,(ranSize*2));
                tree1.Top = 500 - (ground.Height + tree1.Height);
                score++;
            }

            if (tree2.Left < -100)
            {
                tree2.Left = this.ClientSize.Width + ran.Next(500, 800);
                ranSize = ran.Next(30, 70);
                tree2.Size = new Size(ranSize,ranSize);
                tree2.Top = 500 - (ground.Height + tree2.Height);
                score++;
            }

            if (Dino.Bounds.IntersectsWith(tree1.Bounds)|| Dino.Bounds.IntersectsWith(tree2.Bounds))
            {
                gameTimer.Stop();
                Dino.Image = Properties.Resources.dead;
                btn_restart.Visible = true;
                txt_gameOver.Visible = true;
                txt_devBy.Visible = true;
            }

            if (score == 0 || score <= 5) obstacleSpeed = 10;
            else if (score > 5 || score <= 10) obstacleSpeed = 12;
            else if (score > 10 || score <= 15) obstacleSpeed = 14;
            else if (score > 15 || score <= 20) obstacleSpeed = 16;
            else if (score > 20) obstacleSpeed = 18;


        }

        private void TRex_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space && jumping == false) jumping = true;
        }

        private void TRex_KeyUp(object sender, KeyEventArgs e)
        {
            if (jumping == true) jumping = false;
        }

        private void GameReset()
        {
            force = 17;
            jumpSpeed = 0;
            score = 0;
            obstacleSpeed = 10;

            jumping = false;
            txt_gameOver.Visible = false;
            btn_restart.Visible = false;
            txt_devBy.Visible = false;

            txt_Score.Text = "Score: " + score;
            Dino.Image = Properties.Resources.running;
            Dino.Top = 342;

            tree1.Left = this.ClientSize.Width + ran.Next(100, 300);
            tree2.Left = this.ClientSize.Width + ran.Next(500, 800);
            
            gameTimer.Start();
        }

        private void btn_restart_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            InitializeComponent();
            GameReset();
        }
    }
}
