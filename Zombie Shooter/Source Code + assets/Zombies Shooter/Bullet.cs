using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;


namespace Zombies_Shooter
{
    internal class Bullet
    {
        public String direction;
        public int bulletLeft, bulletTop;
        public int speed = 25;
        
        private PictureBox bullet = new PictureBox();
        private Timer bulletTimer = new Timer();

        public void MakeBullet(Form form)
        {
            bullet.BackColor = Color.White;
            bullet.Size = new Size(5, 5);
            bullet.Tag = "bullet";
            bullet.Left = bulletLeft;
            bullet.Top = bulletTop;
            bullet.BringToFront();

            form.Controls.Add(bullet);

            bulletTimer.Interval = speed;
            bulletTimer.Tick += new EventHandler(bulletTimerEvent);
            bulletTimer.Start();
        }

        private void bulletTimerEvent(object sender, EventArgs e)
        {
            if (direction == "left") bullet.Left -= speed;
            if (direction == "right") bullet.Left += speed;
            if (direction == "up") bullet.Top -= speed;
            if (direction == "down") bullet.Top += speed;

            if (bullet.Left < 10 || bullet.Left > 990 || bullet.Top < 40|| bullet.Top > 690)
            {
                bulletTimer.Stop();
                bulletTimer.Dispose();
                bullet.Dispose();
                bulletTimer = null;
                bullet = null;
            }
        }
    }
}
