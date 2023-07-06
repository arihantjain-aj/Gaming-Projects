using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zombies_Shooter
{
    public partial class Zombie_shooter_frm : Form
    {
        bool goUp, goDown, goLeft, goRight, gameOver;
        String facing = "up";
        int playerHealth = 100;
        int speed = 10;
        int ammo = 10;
        int zombieSpeed = 4;
        int kills = 0;
        Random randNum = new Random();

        List<PictureBox> zombiesLst = new List<PictureBox>();


        public Zombie_shooter_frm()
        {
            InitializeComponent();
            RestartGame();
        }

        private void maintimerevent(object sender, EventArgs e)
        {
            if (playerHealth > 1) healthBar.Value = playerHealth;
            else GameOver(); 
            txt_ammo.Text = "Ammo: " + ammo;
            txt_kills.Text = "Kills: " + kills;

            if (goLeft == true && player.Left > 0) player.Left -= speed;
            if (goRight == true && player.Left + player.Width < this.ClientSize.Width) player.Left += speed;
            if (goUp == true && player.Top > 40) player.Top -= speed;
            if (goDown == true && player.Top + player.Height < this.ClientSize.Height) player.Top += speed;

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "ammo")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds))
                    {
                        this.Controls.Remove(x);
                        ((PictureBox)x).Dispose();
                        ammo += 5;
                    }
                }

                if (x is PictureBox && (string)x.Tag == "zombie")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds)) playerHealth -= 1;

                    if (x.Left > player.Left)
                    {
                        x.Left -= zombieSpeed;
                        ((PictureBox)x).Image = Properties.Resources.zleft;
                    }
                    if (x.Left < player.Left)
                    {
                        x.Left += zombieSpeed;
                        ((PictureBox)x).Image = Properties.Resources.zright;
                    }
                    if (x.Top > player.Top)
                    {
                        x.Top -= zombieSpeed;
                        ((PictureBox)x).Image = Properties.Resources.zup;
                    }
                    if (x.Top < player.Top)
                    {
                        x.Top += zombieSpeed;
                        ((PictureBox)x).Image = Properties.Resources.zdown;
                    }
                }

                foreach (Control j in this.Controls)
                {
                    if (j is PictureBox && (string)j.Tag == "bullet" && x is PictureBox && (string)x.Tag == "zombie")
                    {
                        if (x.Bounds.IntersectsWith(j.Bounds))
                        {
                            kills++;

                            this.Controls.Remove(j);
                            ((PictureBox)j).Dispose();
                            this.Controls.Remove(x);
                            ((PictureBox)x).Dispose();
                            zombiesLst.Remove(((PictureBox)x));
                            MakeZombies();
                        }
                    }
                }
            }
        } 

        private void Zombie_shooter_frm_KeyDown(object sender, KeyEventArgs e)
        {
            if (gameOver == true) return;
            if (e.KeyCode== Keys.Left)
            {
                goLeft = true;
                facing = "left";
                player.Image = Properties.Resources.left;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = true;
                facing = "right";
                player.Image = Properties.Resources.right;
            }
            if (e.KeyCode == Keys.Up)
            {
                goUp = true;
                facing = "up";
                player.Image = Properties.Resources.up;
            }
            if (e.KeyCode == Keys.Down)
            {
                goDown = true;
                facing = "down";
                player.Image = Properties.Resources.down;
            }
        }

        private void Zombie_shooter_frm_KeyUp(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Left) goLeft = false;
            if (e.KeyCode == Keys.Right) goRight = false;
            if (e.KeyCode == Keys.Up) goUp = false;
            if (e.KeyCode == Keys.Down) goDown = false;
            if (e.KeyCode == Keys.Space && ammo > 0 && gameOver == false)
            {
                ammo--;
                ShootBullet(facing);

                if (ammo < 1) DropAmmo();
            }
        }

        private void ShootBullet(String Direction)
        {
            Bullet shootBullet = new Bullet();
            shootBullet.direction = Direction;
            shootBullet.bulletLeft =player.Left + (player.Width / 2);
            shootBullet.bulletTop = player.Top + (player.Height / 2);
            shootBullet.MakeBullet(this);
        }

        private void btn_restart_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            InitializeComponent();
            RestartGame();
        }

        private void MakeZombies()
        {
            PictureBox zombie = new PictureBox();
            zombie.Tag = "zombie";
            zombie.Image = Properties.Resources.zdown;
            zombie.Left = randNum.Next(0,1000);
            zombie.Top = randNum.Next(40,700);
            zombie.SizeMode=PictureBoxSizeMode.AutoSize;
            zombiesLst.Add(zombie);
            this.Controls.Add(zombie);
            player.BringToFront();
        }

        private void DropAmmo()
        {
            PictureBox ammo = new PictureBox();
            ammo.Image = Properties.Resources.ammo_Image;
            ammo.SizeMode=PictureBoxSizeMode.AutoSize;
            ammo.Left = randNum.Next(10, this.ClientSize.Width-ammo.Width);
            ammo.Top = randNum.Next(10, this.ClientSize.Height - ammo.Height);
            ammo.Tag = "ammo";
            this.Controls.Add(ammo);
            ammo.BringToFront();
            player.BringToFront();
        } 

        private void RestartGame()
        {
            player.Image = Properties.Resources.up;
            foreach (PictureBox i in zombiesLst) 
            {
                this.Controls.Remove(i);
            }

            zombiesLst.Clear();

            for(int i = 0;i<3;i++)
            {
                MakeZombies();
            }
            goUp = false;
            goDown = false;
            goLeft = false;
            goRight = false;
            gameOver = false;
            txt_gameOver.Visible = false;
            btn_restart.Visible = false;
            txt_devBy.Visible = false;

            playerHealth = 100;
            kills = 0;
            ammo = 10;
            gameTimer.Start();    
        }

        private void GameOver()
        {
            gameOver = true;
            txt_gameOver.BringToFront();
            txt_gameOver.Visible = true;
            btn_restart.BringToFront();
            btn_restart.Visible = true;
            txt_devBy.BringToFront();
            txt_devBy.Visible = true;
            player.Image = Properties.Resources.dead;
            gameTimer.Stop();
        }
    }
}
