namespace ProjektGame
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.LeftMoveTimer = new System.Windows.Forms.Timer(this.components);
            this.RihtMoveTimer = new System.Windows.Forms.Timer(this.components);
            this.BackMoveTimer = new System.Windows.Forms.Timer(this.components);
            this.ForwardMoveTimer = new System.Windows.Forms.Timer(this.components);
            this.enemyMoveTimer = new System.Windows.Forms.Timer(this.components);
            this.ColisionTimer = new System.Windows.Forms.Timer(this.components);
            this.PointsLabel = new System.Windows.Forms.Label();
            this.StarsMoveTimer = new System.Windows.Forms.Timer(this.components);
            this.PauseLabel = new System.Windows.Forms.Label();
            this.ResumLabel = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.Text_Plane_3 = new System.Windows.Forms.TextBox();
            this.Text_Plane_2 = new System.Windows.Forms.TextBox();
            this.Text_Plane_1 = new System.Windows.Forms.TextBox();
            this.LevelUpTimer = new System.Windows.Forms.Timer(this.components);
            this.EnemyBulletForm = new System.Windows.Forms.Timer(this.components);
            this.AmmoApearingTImer = new System.Windows.Forms.Timer(this.components);
            this.LevelUpText = new System.Windows.Forms.Label();
            this.LeaderBoard = new System.Windows.Forms.Label();
            this.Crown = new System.Windows.Forms.PictureBox();
            this.Win_Text = new System.Windows.Forms.PictureBox();
            this.leader_Board_Button_Form = new System.Windows.Forms.PictureBox();
            this.unmuteBotton = new System.Windows.Forms.PictureBox();
            this.muteBotton = new System.Windows.Forms.PictureBox();
            this.Polish_Polish = new System.Windows.Forms.Button();
            this.Heart3 = new System.Windows.Forms.PictureBox();
            this.Heart2 = new System.Windows.Forms.PictureBox();
            this.Heart1 = new System.Windows.Forms.PictureBox();
            this.English_Language = new System.Windows.Forms.Button();
            this.Russian_Language = new System.Windows.Forms.Button();
            this.Main_Languages = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Change_Off = new System.Windows.Forms.PictureBox();
            this.GIF = new System.Windows.Forms.PictureBox();
            this.Plane_Changes_Menu = new System.Windows.Forms.PictureBox();
            this.Player = new System.Windows.Forms.PictureBox();
            this.Plane_2_Choosed = new System.Windows.Forms.PictureBox();
            this.Plane_3_Choosed = new System.Windows.Forms.PictureBox();
            this.Plane_1_Choosed = new System.Windows.Forms.PictureBox();
            this.Change_Plane_Background = new System.Windows.Forms.PictureBox();
            this.LevelUpGif = new System.Windows.Forms.PictureBox();
            this.Play = new System.Windows.Forms.Button();
            this.ReplayButton = new System.Windows.Forms.Button();
            this.Main_Text = new System.Windows.Forms.PictureBox();
            this.newRec = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Crown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Win_Text)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leader_Board_Button_Form)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unmuteBotton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.muteBotton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Heart3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Heart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Heart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Main_Languages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Change_Off)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GIF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Plane_Changes_Menu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Plane_2_Choosed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Plane_3_Choosed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Plane_1_Choosed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Change_Plane_Background)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LevelUpGif)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Main_Text)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newRec)).BeginInit();
            this.SuspendLayout();
            // 
            // LeftMoveTimer
            // 
            this.LeftMoveTimer.Interval = 1;
            this.LeftMoveTimer.Tick += new System.EventHandler(this.LeftMoveTimer_Tick);
            // 
            // RihtMoveTimer
            // 
            this.RihtMoveTimer.Interval = 1;
            this.RihtMoveTimer.Tick += new System.EventHandler(this.RihtMoveTimer_Tick);
            // 
            // BackMoveTimer
            // 
            this.BackMoveTimer.Interval = 1;
            this.BackMoveTimer.Tick += new System.EventHandler(this.BackMoveTimer_Tick);
            // 
            // ForwardMoveTimer
            // 
            this.ForwardMoveTimer.Interval = 1;
            this.ForwardMoveTimer.Tick += new System.EventHandler(this.ForwardMoveTimer_Tick);
            // 
            // ColisionTimer
            // 
            this.ColisionTimer.Enabled = true;
            this.ColisionTimer.Interval = 1;
            this.ColisionTimer.Tick += new System.EventHandler(this.ColisionTimer_Tick);
            // 
            // PointsLabel
            // 
            this.PointsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PointsLabel.ForeColor = System.Drawing.Color.Yellow;
            this.PointsLabel.Location = new System.Drawing.Point(15, 15);
            this.PointsLabel.Name = "PointsLabel";
            this.PointsLabel.Size = new System.Drawing.Size(530, 39);
            this.PointsLabel.TabIndex = 17;
            this.PointsLabel.Text = "Points:";
            this.PointsLabel.Visible = false;
            // 
            // StarsMoveTimer
            // 
            this.StarsMoveTimer.Interval = 10;
            this.StarsMoveTimer.Tick += new System.EventHandler(this.StarsMoveTimer_Tick);
            // 
            // PauseLabel
            // 
            this.PauseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PauseLabel.ForeColor = System.Drawing.Color.Yellow;
            this.PauseLabel.Location = new System.Drawing.Point(780, 367);
            this.PauseLabel.Name = "PauseLabel";
            this.PauseLabel.Size = new System.Drawing.Size(175, 46);
            this.PauseLabel.TabIndex = 19;
            this.PauseLabel.Text = "(P) to pause";
            // 
            // ResumLabel
            // 
            this.ResumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResumLabel.ForeColor = System.Drawing.Color.Yellow;
            this.ResumLabel.Location = new System.Drawing.Point(784, 348);
            this.ResumLabel.Name = "ResumLabel";
            this.ResumLabel.Size = new System.Drawing.Size(184, 65);
            this.ResumLabel.TabIndex = 20;
            this.ResumLabel.Text = "(C) or (Play) \r\n to resume";
            this.ResumLabel.Visible = false;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imageList2
            // 
            this.imageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList2.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Text_Plane_3
            // 
            this.Text_Plane_3.BackColor = System.Drawing.SystemColors.Desktop;
            this.Text_Plane_3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Text_Plane_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Text_Plane_3.ForeColor = System.Drawing.Color.White;
            this.Text_Plane_3.Location = new System.Drawing.Point(352, 274);
            this.Text_Plane_3.Margin = new System.Windows.Forms.Padding(4);
            this.Text_Plane_3.Multiline = true;
            this.Text_Plane_3.Name = "Text_Plane_3";
            this.Text_Plane_3.ReadOnly = true;
            this.Text_Plane_3.Size = new System.Drawing.Size(264, 89);
            this.Text_Plane_3.TabIndex = 27;
            this.Text_Plane_3.Text = "Death Angel\r\nHP: 1\r\nDamage: 3\r\nSpeed 9\r\n";
            this.Text_Plane_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Text_Plane_2
            // 
            this.Text_Plane_2.BackColor = System.Drawing.SystemColors.Desktop;
            this.Text_Plane_2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Text_Plane_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Text_Plane_2.ForeColor = System.Drawing.Color.White;
            this.Text_Plane_2.Location = new System.Drawing.Point(636, 274);
            this.Text_Plane_2.Margin = new System.Windows.Forms.Padding(4);
            this.Text_Plane_2.Multiline = true;
            this.Text_Plane_2.Name = "Text_Plane_2";
            this.Text_Plane_2.ReadOnly = true;
            this.Text_Plane_2.Size = new System.Drawing.Size(264, 89);
            this.Text_Plane_2.TabIndex = 30;
            this.Text_Plane_2.Text = "Naruto\r\nHP: 2\r\nDamage: 2\r\nSpeed 7\r\n\r\n\r\n";
            this.Text_Plane_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Text_Plane_1
            // 
            this.Text_Plane_1.BackColor = System.Drawing.SystemColors.Desktop;
            this.Text_Plane_1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Text_Plane_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Text_Plane_1.ForeColor = System.Drawing.Color.White;
            this.Text_Plane_1.Location = new System.Drawing.Point(71, 281);
            this.Text_Plane_1.Margin = new System.Windows.Forms.Padding(4);
            this.Text_Plane_1.Multiline = true;
            this.Text_Plane_1.Name = "Text_Plane_1";
            this.Text_Plane_1.ReadOnly = true;
            this.Text_Plane_1.Size = new System.Drawing.Size(264, 89);
            this.Text_Plane_1.TabIndex = 31;
            this.Text_Plane_1.Text = "Saske\r\nHP: 3\r\nDamage: 1\r\nSpeed 5\r\n\r\n\r\n\r\n";
            this.Text_Plane_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LevelUpTimer
            // 
            this.LevelUpTimer.Enabled = true;
            this.LevelUpTimer.Interval = 1;
            this.LevelUpTimer.Tick += new System.EventHandler(this.LevelUpTimer_Tick);
            // 
            // EnemyBulletForm
            // 
            this.EnemyBulletForm.Interval = 1000;
            this.EnemyBulletForm.Tick += new System.EventHandler(this.EnemyBulletForm_Tick);
            // 
            // AmmoApearingTImer
            // 
            this.AmmoApearingTImer.Interval = 5000;
            this.AmmoApearingTImer.Tick += new System.EventHandler(this.AmmoApearingTImer_Tick);
            // 
            // LevelUpText
            // 
            this.LevelUpText.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LevelUpText.ForeColor = System.Drawing.Color.Yellow;
            this.LevelUpText.Location = new System.Drawing.Point(392, 15);
            this.LevelUpText.Name = "LevelUpText";
            this.LevelUpText.Size = new System.Drawing.Size(206, 48);
            this.LevelUpText.TabIndex = 47;
            this.LevelUpText.Text = "Level up";
            this.LevelUpText.Visible = false;
            // 
            // LeaderBoard
            // 
            this.LeaderBoard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LeaderBoard.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.LeaderBoard.ForeColor = System.Drawing.Color.Yellow;
            this.LeaderBoard.Image = global::ProjektGame.Properties.Resources.Ресурс_21;
            this.LeaderBoard.Location = new System.Drawing.Point(0, 0);
            this.LeaderBoard.Margin = new System.Windows.Forms.Padding(0);
            this.LeaderBoard.Name = "LeaderBoard";
            this.LeaderBoard.Padding = new System.Windows.Forms.Padding(0, 0, 0, 250);
            this.LeaderBoard.Size = new System.Drawing.Size(979, 848);
            this.LeaderBoard.TabIndex = 0;
            this.LeaderBoard.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.LeaderBoard.Visible = false;
            // 
            // Crown
            // 
            this.Crown.Image = ((System.Drawing.Image)(resources.GetObject("Crown.Image")));
            this.Crown.Location = new System.Drawing.Point(352, 57);
            this.Crown.Name = "Crown";
            this.Crown.Size = new System.Drawing.Size(226, 163);
            this.Crown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Crown.TabIndex = 46;
            this.Crown.TabStop = false;
            this.Crown.Visible = false;
            // 
            // Win_Text
            // 
            this.Win_Text.Image = ((System.Drawing.Image)(resources.GetObject("Win_Text.Image")));
            this.Win_Text.Location = new System.Drawing.Point(140, 230);
            this.Win_Text.Name = "Win_Text";
            this.Win_Text.Size = new System.Drawing.Size(666, 183);
            this.Win_Text.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Win_Text.TabIndex = 45;
            this.Win_Text.TabStop = false;
            this.Win_Text.Visible = false;
            // 
            // leader_Board_Button_Form
            // 
            this.leader_Board_Button_Form.Image = global::ProjektGame.Properties.Resources.leader_board_Button_Final;
            this.leader_Board_Button_Form.Location = new System.Drawing.Point(785, 570);
            this.leader_Board_Button_Form.Name = "leader_Board_Button_Form";
            this.leader_Board_Button_Form.Size = new System.Drawing.Size(151, 120);
            this.leader_Board_Button_Form.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.leader_Board_Button_Form.TabIndex = 43;
            this.leader_Board_Button_Form.TabStop = false;
            this.leader_Board_Button_Form.Click += new System.EventHandler(this.LeaderBoard_Click);
            this.leader_Board_Button_Form.DoubleClick += new System.EventHandler(this.LeaderBoard_DoubleClick);
            // 
            // unmuteBotton
            // 
            this.unmuteBotton.Image = ((System.Drawing.Image)(resources.GetObject("unmuteBotton.Image")));
            this.unmuteBotton.Location = new System.Drawing.Point(855, 426);
            this.unmuteBotton.Name = "unmuteBotton";
            this.unmuteBotton.Size = new System.Drawing.Size(100, 100);
            this.unmuteBotton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.unmuteBotton.TabIndex = 42;
            this.unmuteBotton.TabStop = false;
            this.unmuteBotton.Visible = false;
            this.unmuteBotton.Click += new System.EventHandler(this.unmuteBotton_Click);
            // 
            // muteBotton
            // 
            this.muteBotton.Image = ((System.Drawing.Image)(resources.GetObject("muteBotton.Image")));
            this.muteBotton.Location = new System.Drawing.Point(855, 426);
            this.muteBotton.Name = "muteBotton";
            this.muteBotton.Size = new System.Drawing.Size(100, 100);
            this.muteBotton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.muteBotton.TabIndex = 41;
            this.muteBotton.TabStop = false;
            this.muteBotton.Click += new System.EventHandler(this.muteBotton_Click);
            // 
            // Polish_Polish
            // 
            this.Polish_Polish.BackColor = System.Drawing.Color.Transparent;
            this.Polish_Polish.BackgroundImage = global::ProjektGame.Properties.Resources.PL_Language;
            this.Polish_Polish.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Polish_Polish.FlatAppearance.BorderSize = 0;
            this.Polish_Polish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Polish_Polish.ForeColor = System.Drawing.Color.Transparent;
            this.Polish_Polish.Location = new System.Drawing.Point(13, 491);
            this.Polish_Polish.Margin = new System.Windows.Forms.Padding(0);
            this.Polish_Polish.Name = "Polish_Polish";
            this.Polish_Polish.Size = new System.Drawing.Size(115, 85);
            this.Polish_Polish.TabIndex = 38;
            this.Polish_Polish.UseMnemonic = false;
            this.Polish_Polish.UseVisualStyleBackColor = false;
            this.Polish_Polish.Click += new System.EventHandler(this.PL_Language_Click);
            // 
            // Heart3
            // 
            this.Heart3.BackColor = System.Drawing.Color.Transparent;
            this.Heart3.Image = global::ProjektGame.Properties.Resources.heart1;
            this.Heart3.Location = new System.Drawing.Point(899, 0);
            this.Heart3.Margin = new System.Windows.Forms.Padding(4);
            this.Heart3.Name = "Heart3";
            this.Heart3.Size = new System.Drawing.Size(85, 76);
            this.Heart3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Heart3.TabIndex = 37;
            this.Heart3.TabStop = false;
            this.Heart3.Visible = false;
            // 
            // Heart2
            // 
            this.Heart2.BackColor = System.Drawing.Color.Transparent;
            this.Heart2.Image = global::ProjektGame.Properties.Resources.heart1;
            this.Heart2.Location = new System.Drawing.Point(815, 0);
            this.Heart2.Margin = new System.Windows.Forms.Padding(4);
            this.Heart2.Name = "Heart2";
            this.Heart2.Size = new System.Drawing.Size(85, 76);
            this.Heart2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Heart2.TabIndex = 36;
            this.Heart2.TabStop = false;
            this.Heart2.Visible = false;
            // 
            // Heart1
            // 
            this.Heart1.BackColor = System.Drawing.Color.Transparent;
            this.Heart1.Image = global::ProjektGame.Properties.Resources.heart1;
            this.Heart1.Location = new System.Drawing.Point(721, 0);
            this.Heart1.Margin = new System.Windows.Forms.Padding(4);
            this.Heart1.Name = "Heart1";
            this.Heart1.Size = new System.Drawing.Size(85, 76);
            this.Heart1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Heart1.TabIndex = 35;
            this.Heart1.TabStop = false;
            this.Heart1.Visible = false;
            // 
            // English_Language
            // 
            this.English_Language.BackColor = System.Drawing.Color.Transparent;
            this.English_Language.FlatAppearance.BorderSize = 0;
            this.English_Language.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.English_Language.ForeColor = System.Drawing.Color.Transparent;
            this.English_Language.Image = global::ProjektGame.Properties.Resources.UA_Language;
            this.English_Language.Location = new System.Drawing.Point(13, 426);
            this.English_Language.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.English_Language.Name = "English_Language";
            this.English_Language.Size = new System.Drawing.Size(115, 63);
            this.English_Language.TabIndex = 9;
            this.English_Language.UseVisualStyleBackColor = false;
            this.English_Language.Click += new System.EventHandler(this.UA_Language_Click);
            // 
            // Russian_Language
            // 
            this.Russian_Language.BackColor = System.Drawing.Color.Transparent;
            this.Russian_Language.BackgroundImage = global::ProjektGame.Properties.Resources.RU_Language2;
            this.Russian_Language.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Russian_Language.FlatAppearance.BorderSize = 0;
            this.Russian_Language.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Russian_Language.ForeColor = System.Drawing.Color.Transparent;
            this.Russian_Language.Location = new System.Drawing.Point(13, 570);
            this.Russian_Language.Margin = new System.Windows.Forms.Padding(0);
            this.Russian_Language.Name = "Russian_Language";
            this.Russian_Language.Size = new System.Drawing.Size(115, 85);
            this.Russian_Language.TabIndex = 7;
            this.Russian_Language.UseMnemonic = false;
            this.Russian_Language.UseVisualStyleBackColor = false;
            this.Russian_Language.Click += new System.EventHandler(this.RU_Language_Click);
            // 
            // Main_Languages
            // 
            this.Main_Languages.BackColor = System.Drawing.Color.Transparent;
            this.Main_Languages.Image = global::ProjektGame.Properties.Resources.Menu_languages_8;
            this.Main_Languages.Location = new System.Drawing.Point(13, 661);
            this.Main_Languages.Margin = new System.Windows.Forms.Padding(4);
            this.Main_Languages.Name = "Main_Languages";
            this.Main_Languages.Size = new System.Drawing.Size(208, 181);
            this.Main_Languages.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Main_Languages.TabIndex = 12;
            this.Main_Languages.TabStop = false;
            this.Main_Languages.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Main_Languages_Click_On);
            this.Main_Languages.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Main_Languages_Click_Off);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::ProjektGame.Properties.Resources.Left;
            this.pictureBox1.Location = new System.Drawing.Point(1940, 38);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(548, 377);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // Change_Off
            // 
            this.Change_Off.BackColor = System.Drawing.Color.Transparent;
            this.Change_Off.Image = global::ProjektGame.Properties.Resources.Menu_Change_8;
            this.Change_Off.Location = new System.Drawing.Point(759, 661);
            this.Change_Off.Margin = new System.Windows.Forms.Padding(4);
            this.Change_Off.Name = "Change_Off";
            this.Change_Off.Size = new System.Drawing.Size(208, 181);
            this.Change_Off.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Change_Off.TabIndex = 22;
            this.Change_Off.TabStop = false;
            this.Change_Off.Click += new System.EventHandler(this.Planes_Change_Click_Off);
            // 
            // GIF
            // 
            this.GIF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.GIF.Image = ((System.Drawing.Image)(resources.GetObject("GIF.Image")));
            this.GIF.Location = new System.Drawing.Point(259, 542);
            this.GIF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GIF.Name = "GIF";
            this.GIF.Size = new System.Drawing.Size(429, 295);
            this.GIF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.GIF.TabIndex = 18;
            this.GIF.TabStop = false;
            // 
            // Plane_Changes_Menu
            // 
            this.Plane_Changes_Menu.BackColor = System.Drawing.Color.Transparent;
            this.Plane_Changes_Menu.Image = global::ProjektGame.Properties.Resources.Menu_Change_8;
            this.Plane_Changes_Menu.Location = new System.Drawing.Point(760, 661);
            this.Plane_Changes_Menu.Margin = new System.Windows.Forms.Padding(4);
            this.Plane_Changes_Menu.Name = "Plane_Changes_Menu";
            this.Plane_Changes_Menu.Size = new System.Drawing.Size(208, 181);
            this.Plane_Changes_Menu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Plane_Changes_Menu.TabIndex = 13;
            this.Plane_Changes_Menu.TabStop = false;
            this.Plane_Changes_Menu.Click += new System.EventHandler(this.Planes_Change_Click_On);
            // 
            // Player
            // 
            this.Player.BackColor = System.Drawing.Color.Black;
            this.Player.Image = ((System.Drawing.Image)(resources.GetObject("Player.Image")));
            this.Player.Location = new System.Drawing.Point(421, 739);
            this.Player.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(107, 98);
            this.Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Player.TabIndex = 0;
            this.Player.TabStop = false;
            // 
            // Plane_2_Choosed
            // 
            this.Plane_2_Choosed.Image = global::ProjektGame.Properties.Resources.Plane_2_place;
            this.Plane_2_Choosed.Location = new System.Drawing.Point(636, 58);
            this.Plane_2_Choosed.Margin = new System.Windows.Forms.Padding(4);
            this.Plane_2_Choosed.Name = "Plane_2_Choosed";
            this.Plane_2_Choosed.Size = new System.Drawing.Size(264, 209);
            this.Plane_2_Choosed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Plane_2_Choosed.TabIndex = 28;
            this.Plane_2_Choosed.TabStop = false;
            this.Plane_2_Choosed.Click += new System.EventHandler(this.Plane_2_Click_Choosed);
            // 
            // Plane_3_Choosed
            // 
            this.Plane_3_Choosed.Image = global::ProjektGame.Properties.Resources.Ресурс_12;
            this.Plane_3_Choosed.Location = new System.Drawing.Point(352, 58);
            this.Plane_3_Choosed.Margin = new System.Windows.Forms.Padding(4);
            this.Plane_3_Choosed.Name = "Plane_3_Choosed";
            this.Plane_3_Choosed.Size = new System.Drawing.Size(264, 209);
            this.Plane_3_Choosed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Plane_3_Choosed.TabIndex = 26;
            this.Plane_3_Choosed.TabStop = false;
            this.Plane_3_Choosed.Click += new System.EventHandler(this.Plane_3_Click_Choosed);
            // 
            // Plane_1_Choosed
            // 
            this.Plane_1_Choosed.Image = global::ProjektGame.Properties.Resources.Plane_1_place;
            this.Plane_1_Choosed.Location = new System.Drawing.Point(71, 58);
            this.Plane_1_Choosed.Margin = new System.Windows.Forms.Padding(4);
            this.Plane_1_Choosed.Name = "Plane_1_Choosed";
            this.Plane_1_Choosed.Size = new System.Drawing.Size(264, 209);
            this.Plane_1_Choosed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Plane_1_Choosed.TabIndex = 29;
            this.Plane_1_Choosed.TabStop = false;
            this.Plane_1_Choosed.Click += new System.EventHandler(this.Plane_1_Click_Choosed);
            // 
            // Change_Plane_Background
            // 
            this.Change_Plane_Background.Location = new System.Drawing.Point(0, 0);
            this.Change_Plane_Background.Margin = new System.Windows.Forms.Padding(4);
            this.Change_Plane_Background.Name = "Change_Plane_Background";
            this.Change_Plane_Background.Size = new System.Drawing.Size(133, 62);
            this.Change_Plane_Background.TabIndex = 39;
            this.Change_Plane_Background.TabStop = false;
            // 
            // LevelUpGif
            // 
            this.LevelUpGif.Image = global::ProjektGame.Properties.Resources.LevelUp;
            this.LevelUpGif.Location = new System.Drawing.Point(100, 110);
            this.LevelUpGif.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LevelUpGif.Name = "LevelUpGif";
            this.LevelUpGif.Size = new System.Drawing.Size(800, 350);
            this.LevelUpGif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LevelUpGif.TabIndex = 32;
            this.LevelUpGif.TabStop = false;
            this.LevelUpGif.Visible = false;
            // 
            // Play
            // 
            this.Play.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Play.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Play.BackColor = System.Drawing.Color.Transparent;
            this.Play.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Play.FlatAppearance.BorderSize = 0;
            this.Play.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Play.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Play.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Play.ForeColor = System.Drawing.Color.Transparent;
            this.Play.Image = global::ProjektGame.Properties.Resources.Zasób_11;
            this.Play.Location = new System.Drawing.Point(303, 258);
            this.Play.Margin = new System.Windows.Forms.Padding(4);
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(385, 297);
            this.Play.TabIndex = 14;
            this.Play.UseVisualStyleBackColor = false;
            this.Play.Click += new System.EventHandler(this.Play_Start_Click);
            this.Play.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.Play.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            // 
            // ReplayButton
            // 
            this.ReplayButton.BackColor = System.Drawing.Color.Transparent;
            this.ReplayButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ReplayButton.Enabled = false;
            this.ReplayButton.FlatAppearance.BorderSize = 0;
            this.ReplayButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ReplayButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ReplayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReplayButton.ForeColor = System.Drawing.Color.Transparent;
            this.ReplayButton.Image = global::ProjektGame.Properties.Resources.replay;
            this.ReplayButton.Location = new System.Drawing.Point(303, 258);
            this.ReplayButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ReplayButton.Name = "ReplayButton";
            this.ReplayButton.Size = new System.Drawing.Size(345, 274);
            this.ReplayButton.TabIndex = 16;
            this.ReplayButton.UseVisualStyleBackColor = false;
            this.ReplayButton.Visible = false;
            this.ReplayButton.Click += new System.EventHandler(this.ReplayButtonClick);
            // 
            // Main_Text
            // 
            this.Main_Text.BackColor = System.Drawing.Color.Transparent;
            this.Main_Text.Image = global::ProjektGame.Properties.Resources.Text;
            this.Main_Text.Location = new System.Drawing.Point(195, 93);
            this.Main_Text.Margin = new System.Windows.Forms.Padding(4);
            this.Main_Text.Name = "Main_Text";
            this.Main_Text.Size = new System.Drawing.Size(421, 115);
            this.Main_Text.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Main_Text.TabIndex = 11;
            this.Main_Text.TabStop = false;
            // 
            // newRec
            // 
            this.newRec.Image = global::ProjektGame.Properties.Resources.new_record1;
            this.newRec.Location = new System.Drawing.Point(88, 76);
            this.newRec.Name = "newRec";
            this.newRec.Size = new System.Drawing.Size(812, 384);
            this.newRec.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.newRec.TabIndex = 40;
            this.newRec.TabStop = false;
            this.newRec.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(979, 848);
            this.Controls.Add(this.LeaderBoard);
            this.Controls.Add(this.LevelUpText);
            this.Controls.Add(this.Crown);
            this.Controls.Add(this.Win_Text);
            this.Controls.Add(this.leader_Board_Button_Form);
            this.Controls.Add(this.unmuteBotton);
            this.Controls.Add(this.muteBotton);
            this.Controls.Add(this.Polish_Polish);
            this.Controls.Add(this.Heart3);
            this.Controls.Add(this.Heart2);
            this.Controls.Add(this.Heart1);
            this.Controls.Add(this.English_Language);
            this.Controls.Add(this.Russian_Language);
            this.Controls.Add(this.Main_Languages);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Change_Off);
            this.Controls.Add(this.ResumLabel);
            this.Controls.Add(this.PauseLabel);
            this.Controls.Add(this.GIF);
            this.Controls.Add(this.PointsLabel);
            this.Controls.Add(this.Plane_Changes_Menu);
            this.Controls.Add(this.Player);
            this.Controls.Add(this.Text_Plane_3);
            this.Controls.Add(this.Text_Plane_2);
            this.Controls.Add(this.Text_Plane_1);
            this.Controls.Add(this.Plane_2_Choosed);
            this.Controls.Add(this.Plane_3_Choosed);
            this.Controls.Add(this.Plane_1_Choosed);
            this.Controls.Add(this.Change_Plane_Background);
            this.Controls.Add(this.LevelUpGif);
            this.Controls.Add(this.Play);
            this.Controls.Add(this.ReplayButton);
            this.Controls.Add(this.Main_Text);
            this.Controls.Add(this.newRec);
            this.ForeColor = System.Drawing.Color.Cyan;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(997, 895);
            this.MinimumSize = new System.Drawing.Size(997, 895);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.Crown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Win_Text)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leader_Board_Button_Form)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unmuteBotton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.muteBotton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Heart3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Heart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Heart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Main_Languages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Change_Off)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GIF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Plane_Changes_Menu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Plane_2_Choosed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Plane_3_Choosed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Plane_1_Choosed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Change_Plane_Background)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LevelUpGif)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Main_Text)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newRec)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer LeftMoveTimer;
        private System.Windows.Forms.Timer RihtMoveTimer;
        private System.Windows.Forms.Timer BackMoveTimer;
        private System.Windows.Forms.Timer ForwardMoveTimer;
        private System.Windows.Forms.Button Russian_Language;
        private System.Windows.Forms.Button English_Language;
        private System.Windows.Forms.Timer enemyMoveTimer;
        private System.Windows.Forms.Timer ColisionTimer;
        private System.Windows.Forms.PictureBox Player;
        private System.Windows.Forms.PictureBox Main_Text;
        private System.Windows.Forms.PictureBox Main_Languages;
        private System.Windows.Forms.PictureBox Plane_Changes_Menu;
        private System.Windows.Forms.Button Play;
        private System.Windows.Forms.Button ReplayButton;
        private System.Windows.Forms.Label PointsLabel;
        private System.Windows.Forms.Timer StarsMoveTimer;
        private System.Windows.Forms.PictureBox GIF;
        private System.Windows.Forms.Label PauseLabel;
        private System.Windows.Forms.Label ResumLabel;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox Change_Plane_Background;
        private System.Windows.Forms.PictureBox Change_Off;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.PictureBox Plane_3_Choosed;
        private System.Windows.Forms.TextBox Text_Plane_3;
        private System.Windows.Forms.PictureBox Plane_2_Choosed;
        private System.Windows.Forms.PictureBox Plane_1_Choosed;
        private System.Windows.Forms.TextBox Text_Plane_2;
        private System.Windows.Forms.TextBox Text_Plane_1;
        private System.Windows.Forms.PictureBox LevelUpGif;
        private System.Windows.Forms.Timer LevelUpTimer;
        private System.Windows.Forms.PictureBox Heart1;
        private System.Windows.Forms.PictureBox Heart2;
        private System.Windows.Forms.PictureBox Heart3;
        private System.Windows.Forms.Button Polish_Polish;
        private System.Windows.Forms.PictureBox newRec;
        private System.Windows.Forms.Timer EnemyBulletForm;
        private System.Windows.Forms.PictureBox muteBotton;
        private System.Windows.Forms.PictureBox unmuteBotton;
        public System.Windows.Forms.Timer AmmoApearingTImer;
        private System.Windows.Forms.PictureBox leader_Board_Button_Form;
        private System.Windows.Forms.Label LeaderBoard;
        private System.Windows.Forms.PictureBox Win_Text;
        private System.Windows.Forms.PictureBox Crown;
        private System.Windows.Forms.Label LevelUpText;
    }
}

