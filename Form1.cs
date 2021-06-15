using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using WMPLib;

/*To do:
 * new definition of enemy bullets 
*/



namespace ProjektGame
{
    public partial class Form1 : Form
    {

        WindowsMediaPlayer ShootSound;
        WindowsMediaPlayer menuMusic;
        WindowsMediaPlayer playMusic;

        int Player_HP;
        int Player_DM;
        int EnemyHP;
        int EnemyDM;
        int EnemyAmmo;

        int Amo;
        int PlayerSpeed;
        bool firstPlane;
        bool secondPlane;
        bool thirdPlane;
        int StarsSpeed;

        string path;
        string path2;


        bool isDead;
        bool paused;
        bool isstarted;
        bool mute;

        bool polish;
        bool russian;
        bool english;

        PictureBox[] stars;
        List<Enemy> enemies;

        Random rand;
        int random;

        int points;
        int lvl;

        bool Win_is_not;
        
        public Form1()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {

            Player_DM = 1;
            PlayerSpeed = 5;
            EnemyHP = 3;
            EnemyDM = 1;
            EnemyAmmo = 2000;
            firstPlane = true;
            secondPlane = false;
            thirdPlane = false;
            StarsSpeed = 6;
            Amo = 30;

            lvl = 1;
            Win_is_not = true;

            russian = false;
            polish = false;
            english = true;

            //path = @"C:\Users\ikusa\Desktop\studia\sem-letni-2020-2021\Inzenierija\rep 32\Score";
            path = Environment.CurrentDirectory + "\\ScoreData";
            DirectoryInfo dirInfo = new DirectoryInfo(path);
            if (!dirInfo.Exists)
            {
                dirInfo.Create();
            }

            if(!(File.Exists(path + "\\score.txt")))
            {
                StreamWriter writer = new StreamWriter(path + "\\score.txt");
                writer.Close();
            }

            isDead = false;
            rand = new Random();
            paused = false;
            isstarted = false;
            mute = false;

            Player.Tag = "Player";

            stars = new PictureBox[30];
            Change_Plane_Background.Visible = false;
            Text_Plane_1.Visible = false;
            Text_Plane_2.Visible = false;
            Text_Plane_3.Visible = false;
            Plane_3_Choosed.Visible = false;
            Plane_1_Choosed.Visible = false;
            Plane_2_Choosed.Visible = false;

            points = 0;

            Image enemy1 = Properties.Resources.enemy1;
            Image enemy2 = Properties.Resources.enemy2;
            Image enemy3 = Properties.Resources.enemy3;



            for (int i = 0; i < stars.Length; i++)
            {
                stars[i] = new PictureBox();
                stars[i].BorderStyle = BorderStyle.None;
                stars[i].Location = new Point(rand.Next(0, 990), rand.Next(-10, 890));
                if (i % 2 == 0)
                {
                    stars[i].Size = new Size(2, 2);
                    stars[i].BackColor = Color.Wheat;
                }
                else if (i % 3 == 0)
                {
                    stars[i].Size = new Size(3, 3);
                    stars[i].BackColor = Color.DarkGray;
                }
                else
                {
                    stars[i].Size = new Size(2, 4);
                    stars[i].BackColor = Color.GhostWhite;
                }
                stars[i].Visible = false;
                this.Controls.Add(stars[i]);
            }

            random = rand.Next(1, 100);


            enemies = new List<Enemy>();

            for (int i = 0; i < 13; i++)
            {
                enemies.Add(new Enemy(this));
                enemies[i].LeftLocation = (i * 55);
                enemies[i].TopLocation = random;
                enemies[i].MakeEnemy();
                random = rand.Next(1, 100);
                enemies[i].HP = EnemyHP;
                enemies[i].DM = EnemyDM;
            }



            Random ra = new Random();
            int r = ra.Next(1, 3);


            ShootSound = new WindowsMediaPlayer();
            ShootSound.URL = "Sounds\\firstSound.mp3";
            ShootSound.settings.volume = 5;
            ShootSound.controls.stop();

            menuMusic = new WindowsMediaPlayer();
            menuMusic.URL = "Sounds\\menu.mp3";
            menuMusic.settings.volume = 20;

            playMusic = new WindowsMediaPlayer();
            playMusic.URL = "Sounds\\play.mp3";
            playMusic.settings.volume = 10;
            playMusic.controls.stop();

            Languages_Off();
            StoptEnemyEventsInForm();

         


        }

        public void LeftMoveTimer_Tick(object sender, EventArgs e)
        {
            if (Player.Left > 10) // left screen borders 
                Player.Left -= PlayerSpeed; // left moving
        }

        public void RihtMoveTimer_Tick(object sender, EventArgs e)
        {
            if (Player.Right < 730) // right screen borders 
                Player.Left += PlayerSpeed; // right moving
        }

        public void BackMoveTimer_Tick(object sender, EventArgs e)
        {
            if (Player.Top < 600) // down screen borders 
                Player.Top += PlayerSpeed; // moving down

        }

        public void ForwardMoveTimer_Tick(object sender, EventArgs e)
        {
            if (Player.Top > 10) // top screen borders 
                Player.Top -= PlayerSpeed; // moving top
        }

        public void Form1_KeyDown(object sender, KeyEventArgs e) // Function that performs movements in 2D space for 3 models of spacecraft
        {
            e.SuppressKeyPress = true;
            if (!paused && !isDead)
            {
                switch (e.KeyCode)
                {
                    case Keys.D: // Button D
                        if (firstPlane)
                            Player.Image = Properties.Resources.Plane_1_right;
                        else if (secondPlane)
                            Player.Image = Properties.Resources.Plane_2_right;
                        else if (thirdPlane)
                            Player.Image = Properties.Resources.Plane_3_right;
                        RihtMoveTimer.Start();
                        break;
                    case Keys.A: // Button A
                        if (firstPlane)
                            Player.Image = Properties.Resources.Plane_1_left;
                        else if (secondPlane)
                            Player.Image = Properties.Resources.Plane_2_left;
                        else if (thirdPlane)
                            Player.Image = Properties.Resources.Plane_3_left;
                        LeftMoveTimer.Start();
                        break;
                    case Keys.S: // Button S
                        if (firstPlane)
                            Player.Image = Properties.Resources.Plane_1_down;
                        else if (secondPlane)
                            Player.Image = Properties.Resources.Plane_2_place;
                        else if (thirdPlane)
                            Player.Image = Properties.Resources.Plane_3_down;
                        BackMoveTimer.Start();
                        break;
                    case Keys.W: // Button W
                        if (firstPlane)
                            Player.Image = Properties.Resources.Plane_1_up;
                        else if (secondPlane)
                            Player.Image = Properties.Resources.Plane_2_up;
                        else if (thirdPlane)
                            Player.Image = Properties.Resources.Plane_3_up;
                        ForwardMoveTimer.Start();
                        break;
                    case Keys.Space: //Button Space
                        if (!isDead)
                        {
                            if (paused)
                            {
                                if(Win_is_not)
                                    StartTimers();
                            }
                            else
                            {
                                if (Amo != 0)
                                {
                                    ShootSound.controls.play();
                                    MoveBullets();
                                    Amo--;
                                }
                            }
                        }

                        break;
                    case Keys.P:
                        if (isstarted)
                        {
                            playMusic.controls.pause();
                            if (!mute)
                                menuMusic.controls.play();
                            StopTimers();
                            Menu_On();
                        }
                        break;

                }
            }
            else
            {
                if (e.KeyCode == Keys.C)
                {
                    if (isstarted)
                    {
                        StartTimers();
                        Menu_Off();
                    }
                }
            }
        }

        public void RU_Language_Click(object sender, EventArgs e) //Languages buttons. This functions change language on Menu functions.
        {
            polish = false;
            russian = true;
            english = false;
            Text_Plane_1.Text = "Cаске:\r\n Жизнь: 3\r\n Урон: 1\r\n Скорость: 5";
            Text_Plane_2.Text = "Наруто:\r\n Жизнь: 2\r\n Урон: 2\r\n Скорость: 7";
            Text_Plane_3.Text = "Ангел Смерти:\r\n Жизнь: 1\r\n Урон: 3\r\n Скорость: 9";
        }

        public void PL_Language_Click(object sender, EventArgs e) //Languages buttons. This functions change language on Menu functions.
        {
            polish = true;
            russian = false;
            english = false;
            Text_Plane_1.Text = "Saske:\r\n Życie: 3\r\n Moc: 1\r\n Szybkość: 5";
            Text_Plane_2.Text = "Naruto:\r\n Życie: 2\r\n Moc: 2\r\n Szybkość: 7";
            Text_Plane_3.Text = "Angel Śmierci:\r\n Życie: 1\r\n Moc: 3\r\n Szybkość: 9";
        }

        public void UA_Language_Click(object sender, EventArgs e) //Languages buttons. This functions change language on Menu functions.
        {
            polish = false;
            russian = false;
            english = true;
            Text_Plane_1.Text = "Saske:\r\n HP: 3\r\n Damage: 1\r\n Speed: 5";
            Text_Plane_2.Text = "Naruto:\r\n HP: 2\r\n Damage: 2\r\n Speed: 7";
            Text_Plane_3.Text = "Death Angel:\r\n HP: 1\r\n Damage: 3\r\n Speed: 9";
        }



        public void gameover()
        {
            int counter = 0;
            int index = 0;
            bool is_equal = false;


            using (StreamReader sr = new StreamReader($"{path}\\score.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    int x = 0;
                    Int32.TryParse(line, out (x));
                    if (x == points)
                    {
                        is_equal = true;
                        break;
                    }

                }
            }

            System.IO.StreamWriter writer = new System.IO.StreamWriter($"{path}\\score.txt", true);
            if (points != 0 && !is_equal)
                writer.WriteLine(points);
            writer.Close();

            using (StreamReader sr = new StreamReader($"{path}\\score.txt"))
            {
                string line;

                while ((line = sr.ReadLine()) != null)
                {
                    counter++;
                }
            }
            int[] array = new int[counter];
            if (counter > 1)
            {
                using (StreamReader sr = new StreamReader($"{path}\\score.txt"))
                {
                    string line;

                    while ((line = sr.ReadLine()) != null)
                    {
                        Int32.TryParse(line, out (array[index]));
                        index++;
                    }
                }
            }

            if (counter > 1)
            {
                for (int i = 0; i < counter - 1; i++)
                {
                    for (int j = i + 1; j < counter; j++)
                    {
                        if (array[j] > array[i])
                        {
                            int temp = array[i];
                            array[i] = array[j];
                            array[j] = temp;
                        }
                    }
                }



                System.IO.File.WriteAllText($"{path}\\score.txt", String.Empty);
                System.IO.StreamWriter writer1 = new System.IO.StreamWriter($"{path}\\score.txt", true);

                if (counter > 10)
                {
                    for (int i = 0; i < 10; i++)
                    {
                        writer1.WriteLine(array[i]);
                    }
                    writer1.Close();
                }
                else
                {
                    for (int i = 0; i < counter; i++)
                    {
                        writer1.WriteLine(array[i]);
                    }
                    writer1.Close();
                }

            }


            ColisionTimer.Stop();
            EnemyBulletForm.Stop();
            StopTimers();

            for (int i = 0; i < enemies.Count; i++)
            {
                enemies[i].StopTimers();
                if (enemies[i].NewEnemyBullet != null)
                {
                    enemies[i].NewEnemyBullet.StopBullet();
                    enemies[i].NewEnemyBullet.death();
                }
                enemies[i].NewEnemyBullet = null;
                enemies[i].EnemyPicture.Dispose();
                enemies[i] = null;
            }

            enemies.Clear();

            for (int i = 0; i < stars.Length; i++)
            {
                this.Controls.Remove(stars[i]);
                stars[i].Dispose();
                stars[i] = null;
            }

            Player.Dispose();
            Player = null;

            RihtMoveTimer.Stop();
            LeftMoveTimer.Stop();
            BackMoveTimer.Stop();
            ForwardMoveTimer.Stop();

            isDead = true;

            Play.Enabled = false;
            ReplayButton.Visible = true;
            ReplayButton.Enabled = true;
            PointsLabel.Visible = false;

        }

        public void AmmoColision()
        {

            foreach (Control j in this.Controls)
            {
                if (j is PictureBox && (string)j.Tag == "Amo")
                {
                    if (Player != null && j.Bounds.IntersectsWith(Player.Bounds))
                    {

                        this.Controls.Remove(j);
                        ((PictureBox)j).Dispose();
                        Amo = Amo + 10;
                    }

                }
            }

        }

        public void CollisionPL() // Collision 
        {
            for (int i = 0; i < enemies.Count; ++i)
            {
                if (enemies[i].EnemyPicture.Bounds.IntersectsWith(Player.Bounds))
                {
                    this.Controls.Remove(Heart1);
                    this.Controls.Remove(Heart2);
                    this.Controls.Remove(Heart3);
                    Heart1.Dispose();
                    Heart2.Dispose();
                    Heart3.Dispose();

                    Player.Visible = false;
                    gameover();
                }
            }
        }

        public void PlaneBulletsColision() //Collision
        {
            for (int i = 0; i < enemies.Count; ++i)
            {
                foreach (Control j in this.Controls)
                {
                    if (j is PictureBox && (string)j.Tag == "bullet")
                    {
                        if (j.Bounds.IntersectsWith(enemies[i].EnemyPicture.Bounds))
                        {
                            enemies[i].HP -= Player_DM;
                            this.Controls.Remove(j);
                            ((PictureBox)j).Dispose();
                            if (enemies[i].HP < 1)
                            {
                                this.Controls.Remove(j);
                                points++;
                                ((PictureBox)j).Dispose();
                                enemies[i].EnemyPicture.Location = new Point(enemies[i].EnemyPicture.Location.X, -55);
                                rand = new Random((int)DateTime.Now.Ticks);
                                random = rand.Next(1, 4);
                                if (random == 1)
                                    enemies[i].EnemyPicture.Image = Properties.Resources.enemy1;
                                else if (random == 2)
                                    enemies[i].EnemyPicture.Image = Properties.Resources.enemy2;
                                else
                                    enemies[i].EnemyPicture.Image = Properties.Resources.enemy3;

                                enemies[i].HP = EnemyHP;
                                enemies[i].DM = EnemyDM;

                            }



                        }
                    }
                }
            }
        }

        public void EnemyBulletsCollision()
        {

            for (int i = 0; i < enemies.Count; i++)
            {
                if (thirdPlane && Player != null && enemies[i].NewEnemyBullet != null && enemies[i].NewEnemyBullet.EnemyBulletPicture != null && enemies[i].NewEnemyBullet.EnemyBulletPicture.Bounds.IntersectsWith(Player.Bounds))
                {
                    //destruction of the third heart
                    //gameover
                    Heart3.Visible = false;
                    this.Controls.Remove(Heart3);
                    Heart3.Dispose();
                    gameover();
                }
                else if (secondPlane && Player != null && enemies[i].NewEnemyBullet != null && enemies[i].NewEnemyBullet.EnemyBulletPicture != null && enemies[i].NewEnemyBullet.EnemyBulletPicture.Bounds.IntersectsWith(Player.Bounds))
                {
                    Player.Location = new Point(313, 570);
                    enemies[i].NewEnemyBullet.death();
                    if (enemies[i].DM == 1)
                    {
                        if (Heart2.Visible != false)
                        {
                            //destruction of the second heart
                            Heart2.Visible = false;
                            this.Controls.Remove(Heart2);
                            Heart2.Dispose();
                        }
                        else
                        {
                            //destruction of the Third heart
                            //gameover
                            Heart3.Visible = false;
                            this.Controls.Remove(Heart3);
                            Heart3.Dispose();
                            gameover();
                        }
                    }
                    else if (enemies[i].DM > 1)
                    {
                        //destruction of the second heart
                        Heart2.Visible = false;
                        this.Controls.Remove(Heart2);
                        Heart2.Dispose();
                        //destruction of the Third heart
                        //gameover
                        Heart3.Visible = false;
                        this.Controls.Remove(Heart3);
                        Heart3.Dispose();
                        gameover();
                    }

                }
                else if (firstPlane && enemies[i].NewEnemyBullet != null && enemies[i].NewEnemyBullet.EnemyBulletPicture != null && enemies[i].NewEnemyBullet.EnemyBulletPicture.Bounds.IntersectsWith(Player.Bounds))
                {
                    Player.Location = new Point(313, 570);

                    enemies[i].NewEnemyBullet.death();


                    if (enemies[i].DM == 1)
                    {

                        if (Heart1.Visible == false)
                        {
                            if (Heart2.Visible == false)
                            {
                                //destruction of the Third heart
                                //gameover
                                Heart3.Visible = false;
                                this.Controls.Remove(Heart3);
                                Heart3.Dispose();
                                gameover();
                            }
                            else
                            {
                                //destruction of the second heart
                                Heart2.Visible = false;
                                this.Controls.Remove(Heart2);
                                Heart2.Dispose();
                            }

                        }
                        else
                        {
                            //destruction of the first heart
                            Heart1.Visible = false;
                            this.Controls.Remove(Heart1);
                            Heart1.Dispose();
                        }

                    }
                    else if (enemies[i].DM == 2)
                    {
                        if (Heart1.Visible == false)
                        {
                            //destruction of the second heart
                            Heart2.Visible = false;
                            this.Controls.Remove(Heart2);
                            Heart2.Dispose();
                            //destruction of the third heart
                            //gameover
                            Heart3.Visible = false;
                            this.Controls.Remove(Heart3);
                            Heart3.Dispose();
                            gameover();
                        }
                        else
                        {
                            //destruction of the first heart
                            Heart1.Visible = false;
                            this.Controls.Remove(Heart1);
                            Heart1.Dispose();
                            //destruction of the second heart
                            Heart2.Visible = false;
                            this.Controls.Remove(Heart2);
                            Heart2.Dispose();
                        }
                    }
                    else if (enemies[i].DM > 2)
                    {
                        //destruction of the first heart
                        Heart1.Visible = false;
                        this.Controls.Remove(Heart1);
                        Heart1.Dispose();
                        //destruction of the second heart
                        Heart2.Visible = false;
                        this.Controls.Remove(Heart2);
                        Heart2.Dispose();
                        //destruction of the third heart
                        //gameover
                        Heart3.Visible = false;
                        this.Controls.Remove(Heart3);
                        Heart3.Dispose();
                        gameover();
                    }
                }
            }

        }


        public void ColisionTimer_Tick(object sender, EventArgs e) // Collision
        {
            CollisionPL();
            PlaneBulletsColision();
            EnemyBulletsCollision();
            AmmoColision();
            if(lvl < 16)
                PointsLabel.Text = "Points: " + points + " Level: " + lvl + " Amo " + Amo;
            else
                PointsLabel.Text = "Points: " + points + " Amo " + Amo;

        }

        public void Languages_Off() // UA, PL, RU - switch off
        {
            Russian_Language.Visible = false;
            Polish_Polish.Visible = false;
            English_Language.Visible = false;
        }

        public void Menu_Off() // Function switches off all buttons on "Start" screen.
        {
            if (mute)
            {
                unmuteBotton.Visible = false;
                unmuteBotton.Enabled = false;
            }
            else
            {
                muteBotton.Visible = false;
                muteBotton.Enabled = false;
            }
            Play.Visible = false;
            GIF.Visible = false;
            Main_Languages.Visible = false;
            Main_Text.Visible = false;
            Plane_Changes_Menu.Visible = false;
            Languages_Off();
            PauseLabel.Visible = false;
            ResumLabel.Visible = false;
            leader_Board_Button_Form.Visible = false;
        }

        public void Menu_On() // Function switches off all buttons on "Start" screen.
        {
            if (mute)
            {
                unmuteBotton.Visible = true;
                unmuteBotton.Enabled = true;
            }
            else
            {
                muteBotton.Visible = true;
                muteBotton.Enabled = true;
            }
            Change_Off.Visible = false;
            Play.Visible = true;
            Main_Languages.Visible = true;
            if (!isstarted)
            {
                Plane_Changes_Menu.Visible = true;
                Player.Location = new Point(313, 570);
            }
            if(!Win_is_not)
                Plane_Changes_Menu.Visible = true;
            Main_Text.Visible = true;
            leader_Board_Button_Form.Visible = true;
            Languages_Off();
        }


        public void StartEnemyEventsInForm()
        {
            for (int i = 0; i < enemies.Count; i++)
            {
                enemies[i].StartEnemyEvents();

            }
        }

        public void StoptEnemyEventsInForm()
        {
            for (int i = 0; i < enemies.Count; i++)
            {
                enemies[i].StopTimers();
            }
        }

        public void Play_Start_Click(object sender, EventArgs e) // Function switches on a game 
        {
            AmmoApearingTImer.Start();

            muteBotton.Visible = false;
            unmuteBotton.Visible = false;
            muteBotton.Enabled = false;
            unmuteBotton.Enabled = false;

            menuMusic.controls.pause();
            if (!mute)
                playMusic.controls.play();




            StartEnemyEventsInForm();

            for (int i = 0; i < enemies.Count; ++i)
            {
                enemies[i].EnemyPicture.Visible = true;
            }


            LevelUpGif.BringToFront();
            if (Win_is_not)
            {
                if (firstPlane)
                {
                    Heart1.Visible = true;
                    Heart2.Visible = true;
                    Heart3.Visible = true;
                }
                else if (secondPlane)
                {
                    Heart1.Visible = false;
                    Heart2.Visible = true;
                    Heart3.Visible = true;
                }
                else if (thirdPlane)
                {
                    
                    Heart1.Visible = false;
                    Heart2.Visible = false;
                    Heart3.Visible = true;
                }
            }
            else
            {
                Heart1.Visible = true;
                Heart2.Visible = true;
                Heart3.Visible = true;
            }


            if (isstarted)
            {
                if (paused)
                {
                    StartTimers();
                    Menu_Off();
                }
            }
            if (!isstarted)
            {
                isstarted = true;
                Menu_Off();
                Player.Visible = true;
                Change_Off.Visible = false;
                PointsLabel.Visible = true;
                StarsMoveTimer.Start();

                for (int i = 0; i < stars.Length; i++)
                    stars[i].Visible = true;

            }

        }

        public void Main_Languages_Click_On(object sender, MouseEventArgs e) // Function switches on options of languages
        {
            Russian_Language.Visible = true;
            Polish_Polish.Visible = true;
            English_Language.Visible = true;
        }

        public void Main_Languages_Click_Off(object sender, MouseEventArgs e) // Function switches off options of languages
        {
            Russian_Language.Visible = false;
            Polish_Polish.Visible = false;
            English_Language.Visible = false;
        }

        public void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            RihtMoveTimer.Stop();
            LeftMoveTimer.Stop();
            BackMoveTimer.Stop();
            ForwardMoveTimer.Stop();
            if (!isDead)
            {
                if (firstPlane)
                    Player.Image = Properties.Resources.Plane_1_place;
                else if (secondPlane)
                    Player.Image = Properties.Resources.Plane_2_place;
                else if (thirdPlane)
                    Player.Image = Properties.Resources.Plane_3_place;
            }
        }

        public void Planes_Change_Click_On(object sender, EventArgs e)
        {
            Menu_Off();
            Main_Languages.Visible = true;
            Change_Plane_Background.Visible = true;
            Change_Off.Visible = true;
            Text_Plane_1.Visible = true;
            Text_Plane_2.Visible = true;
            Text_Plane_3.Visible = true;
            Plane_3_Choosed.Visible = true;
            Plane_1_Choosed.Visible = true;
            Plane_2_Choosed.Visible = true;
            Player.Visible = false;
        }

        public void Planes_Change_Click_Off(object sender, EventArgs e)
        {
            Menu_On();
            Text_Plane_1.Visible = false;
            Text_Plane_2.Visible = false;
            Text_Plane_3.Visible = false;
            Plane_3_Choosed.Visible = false;
            Plane_1_Choosed.Visible = false;
            Plane_2_Choosed.Visible = false;
            Change_Plane_Background.Visible = false;
            Change_Off.Visible = false;
            GIF.Visible = true;
            Main_Languages.Visible = true;
        }



        public void StopTimers()
        {
            paused = true;

            for (int i = 0; i < enemies.Count; i++)
            {
                enemies[i].StopEnemyEvents();

                if (enemies[i].NewEnemyBullet != null && enemies[i].NewEnemyBullet.EnemyBulletPicture != null)
                {
                    enemies[i].NewEnemyBullet.StopBullet();
                    enemies[i].NewEnemyBullet.EnemyBulletPicture.Visible = false;
                }
                if (enemies[i].NewEnemyBullet == null)
                {
                    enemies[i].StoptBulletTimer();
                }

                enemies[i].EnemyPicture.Visible = false;

            }
            EnemyBulletForm.Stop();

            foreach (Control j in this.Controls)
            {
                if (j is PictureBox && (string)j.Tag == "Amo")
                {
                    j.Visible = false;
                }
            }


            AmmoApearingTImer.Stop();
            Player.Visible = false;
            StarsMoveTimer.Stop();
            LevelUpTimer.Stop();
            EnemyBulletForm.Stop();

        }

        public void StartTimers()
        {
            paused = false;

            for (int i = 0; i < enemies.Count; i++)
            {
                enemies[i].StartEnemyEvents();

                if (enemies[i].NewEnemyBullet != null && enemies[i].NewEnemyBullet.EnemyBulletPicture != null)
                {
                    enemies[i].NewEnemyBullet.StartBullet();
                    enemies[i].NewEnemyBullet.EnemyBulletPicture.Visible = true;
                }
                enemies[i].EnemyPicture.Visible = true;
            }
            EnemyBulletForm.Start();

            foreach (Control j in this.Controls)
            {
                if (j is PictureBox && (string)j.Tag == "Amo")
                {
                    j.Visible = true;
                }
            }

            AmmoApearingTImer.Start();
            Player.Visible = true;
            StarsMoveTimer.Start();
            EnemyBulletForm.Start();

            if(Win_is_not)
                LevelUpTimer.Start();

            LevelUpGif.Visible = false;
            LevelUpText.Visible = false;
            LevelUpGif.SendToBack();

            if (Win_Text.Visible && Crown.Visible)
            {
                Win_Text.Visible = false;
                Crown.Visible = false;
            }


        }

        public void MoveBullets() //Bullet Making
        {
            Bullets ShootBullet = new Bullets();
            if (firstPlane)
                ShootBullet.setImageFirst();
            if (secondPlane)
                ShootBullet.setImageSecond();
            if (thirdPlane)
                ShootBullet.setImageThird();
            ShootBullet.bulletLeft = Player.Left + 27;
            ShootBullet.bulletTop = Player.Top;
            ShootBullet.MakeBullet(this);
        }





        public void ReplayButtonClick(object sender, EventArgs e)
        {

            menuMusic.controls.stop();
            menuMusic.controls.stop();
            playMusic.controls.stop();
            this.Controls.Clear();
            InitializeComponent();
            Form1_Load(e, e);
            ReplayButton.Enabled = false;
            ReplayButton.Visible = false;
        }

        public void StarsMoveTimer_Tick(object sender, EventArgs e) //Stars Move
        {
            for (int i = 0; i < stars.Length; i++)
            {
                stars[i].Top += StarsSpeed;
                if (stars[i].Top > this.Height)
                {
                    stars[i].Location = new Point(rand.Next(20, 990), rand.Next(-10, 890));
                    stars[i].Top = -stars[i].Height;

                }
            }
        }

        public void Plane_2_Click_Choosed(object sender, EventArgs e)
        {
            if (Win_is_not)
            {
                Player_HP = 2;
                PlayerSpeed = 7;
                Player_DM = 2;
            }
            else
            {
                Player_HP = 3;
                PlayerSpeed = 9;
                Player_DM = 3;
            }
            secondPlane = true;
            firstPlane = false;
            thirdPlane = false;
            Player.Image = Properties.Resources.Plane_2_place;
            Player.Visible = true;
            ShootSound.URL = "Sounds\\secondSound.mp3";

        }

        public void Plane_3_Click_Choosed(object sender, EventArgs e)
        {
            if (Win_is_not)
            {
                Player_HP = 1;
                PlayerSpeed = 9;
                Player_DM = 3;
            }
            else
            {
                Player_HP = 3;
                PlayerSpeed = 9;
                Player_DM = 3;
            }

            
            thirdPlane = true;
            firstPlane = false;
            secondPlane = false;
            Player.Image = Properties.Resources.Plane_3_place;
            Player.Visible = true;
            ShootSound.URL = "Sounds\\thirdSound.mp3";
        }

        public void Plane_1_Click_Choosed(object sender, EventArgs e)
        {
            if (Win_is_not)
            {
                Player_HP = 3;
                PlayerSpeed = 5;
                Player_DM = 1;
            }
            else
            {
                Player_HP = 3;
                PlayerSpeed = 9;
                Player_DM = 3;
            }
            firstPlane = true;
            secondPlane = false;
            thirdPlane = false;
            Player.Image = Properties.Resources.Plane_1_place;
            Player.Visible = true;
            ShootSound.URL = "Sounds\\firstSound.mp3";
        }



        public void LevelUp()
        {
         
            lvl++;
            StopTimers();
            if (lvl == 16)
            {
                Win_Text.Visible = true;
                Crown.Visible = true;
                LevelUpGif.Dispose();
                LevelUpText.Dispose();
                this.Controls.Remove(LevelUpGif);
                this.Controls.Remove(LevelUpText);
            }
            else
            {
                LevelUpGif.Visible = true;
                LevelUpText.Visible = true;
            }
            EnemyHP++;

            if (lvl != 1 && lvl % 10 == 0)
                EnemyDM++;

            if (EnemyAmmo != 100 && lvl % 3 == 0)
                EnemyAmmo -= 100;

            for (int i = 0; i < enemies.Count; ++i)
            {
                if (enemies[i].NewEnemyBullet != null)
                    enemies[i].NewEnemyBullet.death();

                rand = new Random((int)DateTime.Now.Ticks);
                random = rand.Next(-55, 100);
                enemies[i].EnemyPicture.Location = new Point(enemies[i].EnemyPicture.Location.X, random);

                rand = new Random((int)DateTime.Now.Ticks);
                random = rand.Next(1, 4);
                if (random == 1)
                    enemies[i].EnemyPicture.Image = Properties.Resources.enemy1;
                else if (random == 2)
                    enemies[i].EnemyPicture.Image = Properties.Resources.enemy2;
                else
                    enemies[i].EnemyPicture.Image = Properties.Resources.enemy3;

                enemies[i].HP = EnemyHP;
                enemies[i].DM = EnemyDM;

                if (lvl > 5)
                {
                    rand = new Random((int)DateTime.Now.Ticks);
                    random = rand.Next(1, lvl / 2);
                    enemies[i].EnemyMovementSpeed = random;
                }


            }
            Amo = Amo + 5;
        }

        public void LevelUpTimer_Tick(object sender, EventArgs e)
        {
            if (lvl == 16)
            {
                Highest_Level();
                LevelUpTimer.Stop();
                LevelUpTimer.Dispose();
                points++;
            }
            if ((points + lvl) % 10 == 0)
            {
                LevelUp();
            }
        }


        public void Highest_Level()
        {
            //shows Highest_Level gif, and u can continue playing
            StopTimers();
            Win_is_not = false;
            //showgif, showtekst and continue
            Menu_On();
            Player_HP = 3;
            Player_DM = 3;
            PlayerSpeed = 9;
            Plane_Changes_Menu.Visible = true;
            lvl = 17;
            
  
        }

        private void EnemyBulletForm_Tick(object sender, EventArgs e)
        {
            random = rand.Next(1, enemies.Count);
            enemies[random].StartBulletTimer();
            EnemyBulletForm.Interval = EnemyAmmo;
            rand = new Random((int)DateTime.Now.Ticks);
        }

        private void muteBotton_Click(object sender, EventArgs e)
        {
            mute = true;
            muteBotton.Visible = false;
            muteBotton.Enabled = false;
            unmuteBotton.Visible = true;
            unmuteBotton.Enabled = true;
            menuMusic.controls.pause();
        }

        private void unmuteBotton_Click(object sender, EventArgs e)
        {
            mute = false;
            unmuteBotton.Visible = false;
            unmuteBotton.Enabled = false;
            muteBotton.Visible = true;
            muteBotton.Enabled = true;
            menuMusic.controls.play();
        }

        private void AmmoApearingTImer_Tick(object sender, EventArgs e)
        {
            int randomTopPos = rand.Next(100, 700);
            int randomLeftPos = rand.Next(100, 700);
            AmoClass Ammo = new AmoClass(this);
            Ammo.TopPosition = randomTopPos;
            Ammo.LeftPosition = randomLeftPos;
            Ammo.MakeAmo();
        }

        private void LeaderBoard_Click(object sender, EventArgs e)
        {
            LeaderBoard.Visible = false;
        }

        private void LeaderBoard_DoubleClick(object sender, EventArgs e)
        {

            LeaderBoard.BringToFront();
            leader_Board_Button_Form.BringToFront();
            int i = 1;
            if(english)
                LeaderBoard.Text = "  Points:\n";
            else if(polish)
                LeaderBoard.Text = "Punkty:\n";
            else if(russian)
                LeaderBoard.Text = "Баллы:\n";
            using (StreamReader sr = new StreamReader($"{path}\\score.txt"))
            {
                string line;

                while ((line = sr.ReadLine()) != null)
                {
                    if(english)
                        LeaderBoard.Text += "  Place " + i + ": " + line + "p" + "\n";
                    else if(polish)
                        LeaderBoard.Text += " Miejsce " + i + ": " + line + "p" + "\n";
                    else if(russian)
                        LeaderBoard.Text += " Место " + i + ": " + line + "б" + "\n";
                    i++;
                }
            }
            LeaderBoard.Visible = true;
        }
    }
}


