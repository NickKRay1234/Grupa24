using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;

namespace ProjektGame
{
    class Bullets
    {
        public int bulletSpeed = 40;
        PictureBox bullet = new PictureBox();
        Timer bulletTimer = new Timer();
        public int bulletTop;
        public int bulletLeft;

        public void MakeBullet(Form form)
        {
            bullet.Size = new Size(20, 20);
            bullet.SizeMode = PictureBoxSizeMode.Zoom;
            bullet.BorderStyle = BorderStyle.None;
            bullet.Tag = "bullet";
            bullet.BackColor = Color.Black;
            bullet.Top = bulletTop;
            bullet.Left = bulletLeft;
            form.Controls.Add(bullet);
            bulletTimer.Interval = bulletSpeed;
            bulletTimer.Tick += new EventHandler(BulletTimerEvent);
            bulletTimer.Start();
        }

        public void BulletTimerEvent(object sender, EventArgs e)
        {
            //if bullet location is less then -50, bullet must be destroyed
            bullet.Top -= bulletSpeed;
            //checking location
            if (bullet.Top < -50)
            {
                //destroing of an bullet
                bulletTimer.Stop();
                bulletTimer.Dispose();
                bullet.Dispose();
                bulletTimer = null;
                bullet = null;
            }
        }

        //setters of image for different planes 
        public void setImageFirst()
        {
            bullet.Image = Properties.Resources.Bullet1;
        }

        public void setImageSecond()
        {
            bullet.Image = Properties.Resources.bullet2;
        }

        public void setImageThird()
        {
            bullet.Image = Properties.Resources.bullet3;
        }

    }

}

