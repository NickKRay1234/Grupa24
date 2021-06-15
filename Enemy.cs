using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ProjektGame
{
    public class Enemy
    {
        public EnemyBuletsClass NewEnemyBullet;
        public PictureBox EnemyPicture;
        public int TopLocation;
        public int LeftLocation;
        public int EnemyMovementSpeed = 1;
        Random rand;
        int l;
        public int ApearingSpeed = 1000;
        Timer EnemyTimer = new Timer();
        Timer BulletApearing = new Timer();
        Timer Position = new Timer();
        public int HP = 3;
        public int DM = 1;


        Form1 mainform;

        public Enemy(Form1 p_form)
        {
            mainform = p_form;
        }


        public void MakeEnemy()
        {

            EnemyPicture = new PictureBox();
            EnemyPicture.Visible = false;
            EnemyPicture.Tag = "Enemy";
            EnemyPicture.Size = new Size(55, 55);
            rand = new Random((int)DateTime.Now.Ticks);
            l = rand.Next(1, 4);
            if (l == 1)
                EnemyPicture.Image = Properties.Resources.enemy1;
            else if (l == 2)
                EnemyPicture.Image = Properties.Resources.enemy2;
            else
                EnemyPicture.Image = Properties.Resources.enemy3;

            rand = new Random((int)DateTime.Now.Ticks);
            l = rand.Next(1, 3);
            EnemyMovementSpeed = l;

            EnemyPicture.SizeMode = PictureBoxSizeMode.Zoom;
            EnemyPicture.BorderStyle = BorderStyle.None;
            EnemyPicture.BackColor = Color.Black;
            mainform.Controls.Add(EnemyPicture);
            EnemyPicture.Top = TopLocation;
            EnemyPicture.Left = LeftLocation;
            EnemyTimer.Interval = EnemyMovementSpeed;
            EnemyTimer.Tick += new EventHandler(EnemyTimerEvent);
            EnemyTimer.Start();
            Position.Interval = 1;
            Position.Tick += new EventHandler(PositionTimerEvent);
            Position.Start();

            BulletApearing.Interval = ApearingSpeed;
            BulletApearing.Tick += new EventHandler(EnemyApearingTimerEvent);

        }



        public void StartEnemyEvents()
        {
            EnemyTimer.Start();
            Position.Start();
        }
        public void StopEnemyEvents()
        {
            EnemyTimer.Stop();
            Position.Stop();
        }

        public void StopTimers()
        {
            BulletApearing.Stop();
            EnemyTimer.Stop();
            Position.Stop();

        }


        public void PositionTimerEvent(object sender, EventArgs e)
        {
            TopLocation = EnemyPicture.Top;
            LeftLocation = EnemyPicture.Left;
        }

        public void EnemyTimerEvent(object sender, EventArgs e)
        {
            EnemyPicture.Top += EnemyMovementSpeed;
            if (EnemyPicture.Top > 550)
            {
                //if enemy was not destroyed, enemy must be respawned in other point of form
                EnemyPicture.Top = -30;
                EnemyPicture.Left = LeftLocation;

                rand = new Random((int)DateTime.Now.Ticks);
                l = rand.Next(1, 4);
                if (l == 1)
                    EnemyPicture.Image = Properties.Resources.enemy1;
                else if (l == 2)
                    EnemyPicture.Image = Properties.Resources.enemy2;
                else
                    EnemyPicture.Image = Properties.Resources.enemy3;


            }
        }

        public void StartBulletTimer()
        {
            BulletApearing.Start();
        }

        public void StoptBulletTimer()
        {
            BulletApearing.Stop();
        }

        public void EnemyApearingTimerEvent(object sender, EventArgs e)
        {
            if (NewEnemyBullet == null)
            {
                NewEnemyBullet = new EnemyBuletsClass();
                NewEnemyBullet.EnemyBulletTop = TopLocation + 10;
                NewEnemyBullet.EnemyBulletLeft = LeftLocation + 27;
                NewEnemyBullet.MakeEnemyBullet(mainform);
                BulletApearing.Interval = ApearingSpeed;
            }
        }



    }
}
