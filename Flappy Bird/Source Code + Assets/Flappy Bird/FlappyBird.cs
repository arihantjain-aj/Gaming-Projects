using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flappy_Bird
{
    public partial class FlappyBird : Form
    {
        int pipeSpeed = 10;
        int gravity = 13;
        int score = 0;

        Random rnd = new Random();

        public FlappyBird()
        {
            InitializeComponent();
            restartGame();
        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            bird.Top += gravity;
            pipeBottom.Left -= pipeSpeed;
            pipeTop.Left -= pipeSpeed;
            txt_Score.Text = "Score: " + score;

            if (pipeBottom.Left < -150)
            {
                pipeBottom.Left = rnd.Next(800,1000);
                pipeBottom.Top = rnd.Next(350,500);
                score++;
            }

            if (pipeTop.Left < -150)
            {
                pipeTop.Left = rnd.Next(800,1000);
                pipeTop.Top = rnd.Next(-250,0);
                score++;
            }

            if(bird.Bounds.IntersectsWith(pipeBottom.Bounds) || 
               bird.Bounds.IntersectsWith(pipeTop.Bounds) ||
               bird.Bounds.IntersectsWith(ground.Bounds) ||
               bird.Top < -25)
            {
                endGame();
            }

            if (score == 0 && score <= 10) pipeSpeed = 10;
            else if (score > 10 && score <= 20) pipeSpeed = 12;
            else if (score > 20 && score >= 25) pipeSpeed = 15;
            else if (score > 25) pipeSpeed = 17;

        }

        private void FlappyBird_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space) gravity = -13;
        }

        private void FlappyBird_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space) gravity = 13;
        }

        private void endGame()
        {
            gameTimer.Stop();
            txt_gameOver.Visible = true;
            btn_restart.Visible = true;
            txt_devBy.Visible = true;
        }

        private void btn_restart_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            InitializeComponent(); 
            restartGame();
        }

        private void restartGame()
        {
            score = 0;
            bird.Location = new Point(112, 238);
            pipeTop.Left = rnd.Next(800, 1300);
            pipeBottom.Left = rnd.Next(800, 1300);

            txt_gameOver.Visible = false;
            btn_restart.Visible = false;
            txt_devBy.Visible = false;

            gameTimer.Start();
        }
    }
}
