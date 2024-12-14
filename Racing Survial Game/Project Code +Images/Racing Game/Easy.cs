using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Racing_Game
{
    public partial class Easy : Form
    {
        int Speed = 2, Score = 0;
        PictureBox[] Road = new PictureBox[14];
        PictureBox[] Enmycar = new PictureBox[4];
        Random R = new Random();

        public Easy()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Road[0] = picb1;
            Road[1] = picb2;
            Road[2] = picb3;
            Road[3] = picb4;
            Road[4] = picb5;
            Road[5] = picb6;
            Road[6] = picb7;
            Road[7] = picb8;
            Road[8] = picb9;
            Road[9] = picb10;
            Road[10] = picb11;
            Road[11] = picb12;
            Road[12] = picb13;
            Road[13] = picb14;

            Enmycar[0] = EnemyCar1;
            Enmycar[1] = EnemyCar2;
            Enmycar[2] = EnemyCar3;
            Enmycar[3] = EnemyCar4;
        }

        private void Rdmover_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i <= 13; i++)
            {
                Road[i].Top += (Speed+2);
                if (Road[i].Top >= this.Height)
                {
                    Road[i].Top = -Road[i].Height;
                }

                if (Score > 10 && Score <= 20) Speed = 3;
                else if (Score > 20 && Score < 40) Speed = 4;
                else if (Score > 40 && Score < 60) Speed = 5;
                else if (Score > 60 && Score < 100) Speed = 6;
                else if (Score > 100) Speed = 7;
                Speed_txt.Text = "Speed:" + Speed;
            } 
        }

        private void Easy_KeyDown(object sender, KeyEventArgs e)
        {
            int x = playercar.Location.X;
            int y = playercar.Location.Y;

            if (e.KeyCode == Keys.Right) R_move.Start();
            else if (e.KeyCode == Keys.Left) L_move.Start();
            else if (e.KeyCode == Keys.Up) Up_move.Start();
            else if (e.KeyCode == Keys.Down) Down_move.Start();
        }

        private void E_car_Tick(object sender, EventArgs e)
        {  
            for (int i = 0; i <= 3; i++)
            {
                Enmycar[i].Top += Speed;

                if (Enmycar[i].Top >= this.Height)
                {
                    Enmycar[i].Top = -Enmycar[i].Height;
                    Enmycar[i].Left = R.Next(8, 235);
                    Score += 1;
                    score_txt.Text = "Score:" + Score;
                }

                if (playercar.Bounds.IntersectsWith(Enmycar[i].Bounds))
                {
                    End_lbl.Visible = true;
                    Replay_btn.Visible = true;
                    txt_devBy.Visible = true;
                    Rdmover.Stop();
                    E_car.Stop();
                    R_move.Stop();
                    L_move.Stop();
                    Up_move.Stop();
                    Down_move.Stop();
                }
            }
        }

        private void L_move_Tick(object sender, EventArgs e)
        {
            int x = playercar.Location.X;
            int y = playercar.Location.Y;
            if (x > 10)
            {
                x -= 2;
                playercar.Location = new Point(x, y);
            }
        }

        private void R_move_Tick(object sender, EventArgs e)
        {
            int x = playercar.Location.X;
            int y = playercar.Location.Y;
            if (x < 238)
            {
                x += 2;
                playercar.Location = new Point(x, y);
            }
        }

        private void Up_move_Tick(object sender, EventArgs e)
        {
            int x = playercar.Location.X;
            int y = playercar.Location.Y;
            if (y > 24)
            {
                y -= 2;
                playercar.Location = new Point(x, y);
            }
        }

        private void Down_move_Tick(object sender, EventArgs e)
        {
            int x = playercar.Location.X;
            int y = playercar.Location.Y;
            if (y < 430)
            {
                y += 2;
                playercar.Location = new Point(x, y);
            }
        }

        private void Replay_btn_Click(object sender, EventArgs e)
        {
            Score = 0;
            this.Controls.Clear();
            InitializeComponent();
            Form1_Load(e, e);
        }

        private void Easy_KeyUp(object sender, KeyEventArgs e)
        {
            R_move.Stop();
            L_move.Stop();
            Up_move.Stop();
            Down_move.Stop();
        }
    }
}
