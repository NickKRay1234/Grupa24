using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;

//if bullet missed the mark, bullet must be destroyed and new bullet object must be created on this enemy place.
//Do not replace the bullet, replacinng is the wrong way to solve a problem
namespace ProjektGame
{
    public class EnemyBuletsClass
    {
        public int EnemyBulletTop;
        public int EnemyBulletLeft;
        public PictureBox EnemyBulletPicture = new PictureBox();
        public int EnemyBulletSpeed = 5;
        Timer EnemyBulletMoveTimer = new Timer();



        public void MakeEnemyBullet(Form1 form)
        {
            EnemyBulletPicture.Size = new Size(2, 25);
            EnemyBulletPicture.SizeMode = PictureBoxSizeMode.Zoom;
            EnemyBulletPicture.BorderStyle = BorderStyle.None;
            EnemyBulletPicture.Tag = "EnemyBullet";
            EnemyBulletPicture.BackColor = Color.Yellow;
            EnemyBulletPicture.Top = EnemyBulletTop;
            EnemyBulletPicture.Left = EnemyBulletLeft;
            EnemyBulletPicture.Visible = true;
            form.Controls.Add(EnemyBulletPicture);
            EnemyBulletMoveTimer.Interval = EnemyBulletSpeed;
            EnemyBulletMoveTimer.Tick += new EventHandler(EnemyBulletTimerEvent);
            EnemyBulletMoveTimer.Start();

        }

        public void StopBullet()
        {
            EnemyBulletMoveTimer.Stop();
        }

        public void StartBullet()
        {
            EnemyBulletMoveTimer.Start();
        }


        public void EnemyBulletTimerEvent(object sender, EventArgs e)
        {
            EnemyBulletPicture.Top += EnemyBulletSpeed;
            if (EnemyBulletPicture.Top > 550)
                death();
        }



        public void death()
        {
            if (EnemyBulletPicture != null)
            {
                EnemyBulletPicture.Dispose();
                EnemyBulletPicture = null;
                EnemyBulletMoveTimer.Stop();
            }
        }
    }
}
