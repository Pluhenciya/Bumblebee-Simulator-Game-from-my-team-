namespace Task1
{
    partial class GameForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.infoTabPage = new System.Windows.Forms.TabPage();
            this.mainMenuTabPage = new System.Windows.Forms.TabPage();
            this.historyTabPage = new System.Windows.Forms.TabPage();
            this.leaderBoardTabPage = new System.Windows.Forms.TabPage();
            this.settingsTabPage = new System.Windows.Forms.TabPage();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.mediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.firstTabPage = new System.Windows.Forms.TabPage();
            this.toHistoryBtn = new System.Windows.Forms.Button();
            this.tomenufrominfoBtn = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.settingsButton = new System.Windows.Forms.Button();
            this.leaderBoardButton = new System.Windows.Forms.Button();
            this.infoBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.playBtn = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.toMenuBtn = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tomenufrombordBtn = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.backButton = new System.Windows.Forms.Button();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.gameTabPage = new System.Windows.Forms.TabPage();
            this.nectarLabel = new System.Windows.Forms.Label();
            this.beeProgressBar = new System.Windows.Forms.ProgressBar();
            this.hiveProgressBar = new System.Windows.Forms.ProgressBar();
            this.hive1 = new Task1.Hive();
            this.bee1 = new Task1.Bee();
            this.loseTabPage = new System.Windows.Forms.TabPage();
            this.mainTabControl.SuspendLayout();
            this.infoTabPage.SuspendLayout();
            this.mainMenuTabPage.SuspendLayout();
            this.historyTabPage.SuspendLayout();
            this.leaderBoardTabPage.SuspendLayout();
            this.settingsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mediaPlayer)).BeginInit();
            this.firstTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.gameTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.firstTabPage);
            this.mainTabControl.Controls.Add(this.infoTabPage);
            this.mainTabControl.Controls.Add(this.mainMenuTabPage);
            this.mainTabControl.Controls.Add(this.historyTabPage);
            this.mainTabControl.Controls.Add(this.leaderBoardTabPage);
            this.mainTabControl.Controls.Add(this.settingsTabPage);
            this.mainTabControl.Controls.Add(this.gameTabPage);
            this.mainTabControl.Controls.Add(this.loseTabPage);
            this.mainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTabControl.Location = new System.Drawing.Point(0, 0);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(1584, 881);
            this.mainTabControl.TabIndex = 0;
            // 
            // infoTabPage
            // 
            this.infoTabPage.Controls.Add(this.tomenufrominfoBtn);
            this.infoTabPage.Controls.Add(this.pictureBox4);
            this.infoTabPage.Location = new System.Drawing.Point(4, 22);
            this.infoTabPage.Name = "infoTabPage";
            this.infoTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.infoTabPage.Size = new System.Drawing.Size(1576, 855);
            this.infoTabPage.TabIndex = 1;
            this.infoTabPage.Text = "Information";
            this.infoTabPage.UseVisualStyleBackColor = true;
            // 
            // mainMenuTabPage
            // 
            this.mainMenuTabPage.Controls.Add(this.settingsButton);
            this.mainMenuTabPage.Controls.Add(this.leaderBoardButton);
            this.mainMenuTabPage.Controls.Add(this.infoBtn);
            this.mainMenuTabPage.Controls.Add(this.button1);
            this.mainMenuTabPage.Controls.Add(this.playBtn);
            this.mainMenuTabPage.Controls.Add(this.pictureBox3);
            this.mainMenuTabPage.Location = new System.Drawing.Point(4, 22);
            this.mainMenuTabPage.Name = "mainMenuTabPage";
            this.mainMenuTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.mainMenuTabPage.Size = new System.Drawing.Size(1576, 855);
            this.mainMenuTabPage.TabIndex = 2;
            this.mainMenuTabPage.Text = "MainMenu";
            this.mainMenuTabPage.UseVisualStyleBackColor = true;
            // 
            // historyTabPage
            // 
            this.historyTabPage.Controls.Add(this.toMenuBtn);
            this.historyTabPage.Controls.Add(this.pictureBox2);
            this.historyTabPage.Location = new System.Drawing.Point(4, 22);
            this.historyTabPage.Name = "historyTabPage";
            this.historyTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.historyTabPage.Size = new System.Drawing.Size(1576, 855);
            this.historyTabPage.TabIndex = 3;
            this.historyTabPage.Text = "tabPage4";
            this.historyTabPage.UseVisualStyleBackColor = true;
            // 
            // leaderBoardTabPage
            // 
            this.leaderBoardTabPage.Controls.Add(this.tomenufrombordBtn);
            this.leaderBoardTabPage.Controls.Add(this.pictureBox5);
            this.leaderBoardTabPage.Location = new System.Drawing.Point(4, 22);
            this.leaderBoardTabPage.Name = "leaderBoardTabPage";
            this.leaderBoardTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.leaderBoardTabPage.Size = new System.Drawing.Size(1576, 855);
            this.leaderBoardTabPage.TabIndex = 5;
            this.leaderBoardTabPage.Text = "tabPage6";
            this.leaderBoardTabPage.UseVisualStyleBackColor = true;
            // 
            // settingsTabPage
            // 
            this.settingsTabPage.Controls.Add(this.mediaPlayer);
            this.settingsTabPage.Controls.Add(this.backButton);
            this.settingsTabPage.Controls.Add(this.pictureBox6);
            this.settingsTabPage.Location = new System.Drawing.Point(4, 22);
            this.settingsTabPage.Name = "settingsTabPage";
            this.settingsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.settingsTabPage.Size = new System.Drawing.Size(1576, 855);
            this.settingsTabPage.TabIndex = 6;
            this.settingsTabPage.Text = "tabPage7";
            this.settingsTabPage.UseVisualStyleBackColor = true;
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 1;
            this.gameTimer.Tick += new System.EventHandler(this.GameTimer_Tick);
            // 
            // mediaPlayer
            // 
            this.mediaPlayer.Enabled = true;
            this.mediaPlayer.Location = new System.Drawing.Point(338, 232);
            this.mediaPlayer.Name = "mediaPlayer";
            this.mediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("mediaPlayer.OcxState")));
            this.mediaPlayer.Size = new System.Drawing.Size(211, 48);
            this.mediaPlayer.TabIndex = 2;
            // 
            // firstTabPage
            // 
            this.firstTabPage.BackgroundImage = global::Task1.Properties.Resources.PREWIEW;
            this.firstTabPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.firstTabPage.Controls.Add(this.toHistoryBtn);
            this.firstTabPage.Location = new System.Drawing.Point(4, 22);
            this.firstTabPage.Name = "firstTabPage";
            this.firstTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.firstTabPage.Size = new System.Drawing.Size(1576, 855);
            this.firstTabPage.TabIndex = 0;
            this.firstTabPage.Text = "Preview";
            this.firstTabPage.UseVisualStyleBackColor = true;
            // 
            // toHistoryBtn
            // 
            this.toHistoryBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("toHistoryBtn.BackgroundImage")));
            this.toHistoryBtn.Location = new System.Drawing.Point(597, 666);
            this.toHistoryBtn.Name = "toHistoryBtn";
            this.toHistoryBtn.Size = new System.Drawing.Size(400, 80);
            this.toHistoryBtn.TabIndex = 2;
            this.toHistoryBtn.UseVisualStyleBackColor = true;
            this.toHistoryBtn.Click += new System.EventHandler(this.ToHistoryBtn_Click);
            // 
            // tomenufrominfoBtn
            // 
            this.tomenufrominfoBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tomenufrominfoBtn.BackgroundImage")));
            this.tomenufrominfoBtn.Location = new System.Drawing.Point(608, 772);
            this.tomenufrominfoBtn.Name = "tomenufrominfoBtn";
            this.tomenufrominfoBtn.Size = new System.Drawing.Size(400, 80);
            this.tomenufrominfoBtn.TabIndex = 1;
            this.tomenufrominfoBtn.UseVisualStyleBackColor = true;
            this.tomenufrominfoBtn.Click += new System.EventHandler(this.ToMenuBtn_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox4.Image = global::Task1.Properties.Resources.infoBGverycorrect;
            this.pictureBox4.Location = new System.Drawing.Point(3, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(1570, 849);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 2;
            this.pictureBox4.TabStop = false;
            // 
            // settingsButton
            // 
            this.settingsButton.Image = ((System.Drawing.Image)(resources.GetObject("settingsButton.Image")));
            this.settingsButton.Location = new System.Drawing.Point(653, 565);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(400, 80);
            this.settingsButton.TabIndex = 6;
            this.settingsButton.UseVisualStyleBackColor = true;
            this.settingsButton.Click += new System.EventHandler(this.ToSettingsBtn_Click);
            this.settingsButton.MouseEnter += new System.EventHandler(this.Button_SoundMouseEnter);
            // 
            // leaderBoardButton
            // 
            this.leaderBoardButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("leaderBoardButton.BackgroundImage")));
            this.leaderBoardButton.Location = new System.Drawing.Point(653, 460);
            this.leaderBoardButton.Name = "leaderBoardButton";
            this.leaderBoardButton.Size = new System.Drawing.Size(400, 80);
            this.leaderBoardButton.TabIndex = 5;
            this.leaderBoardButton.UseVisualStyleBackColor = true;
            this.leaderBoardButton.Click += new System.EventHandler(this.LeaderBoardButton_Click);
            this.leaderBoardButton.MouseEnter += new System.EventHandler(this.Button_SoundMouseEnter);
            // 
            // infoBtn
            // 
            this.infoBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("infoBtn.BackgroundImage")));
            this.infoBtn.Location = new System.Drawing.Point(653, 358);
            this.infoBtn.Name = "infoBtn";
            this.infoBtn.Size = new System.Drawing.Size(400, 80);
            this.infoBtn.TabIndex = 3;
            this.infoBtn.UseVisualStyleBackColor = true;
            this.infoBtn.Click += new System.EventHandler(this.InfoBtn_Click);
            this.infoBtn.MouseEnter += new System.EventHandler(this.Button_SoundMouseEnter);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.Location = new System.Drawing.Point(653, 670);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(400, 80);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ExitBtn_Click);
            this.button1.MouseEnter += new System.EventHandler(this.Button_SoundMouseEnter);
            // 
            // playBtn
            // 
            this.playBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("playBtn.BackgroundImage")));
            this.playBtn.Location = new System.Drawing.Point(653, 253);
            this.playBtn.Name = "playBtn";
            this.playBtn.Size = new System.Drawing.Size(400, 80);
            this.playBtn.TabIndex = 1;
            this.playBtn.UseVisualStyleBackColor = true;
            this.playBtn.Click += new System.EventHandler(this.PlayButton_Click);
            this.playBtn.MouseEnter += new System.EventHandler(this.Button_SoundMouseEnter);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(3, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(1570, 849);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // toMenuBtn
            // 
            this.toMenuBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("toMenuBtn.BackgroundImage")));
            this.toMenuBtn.Location = new System.Drawing.Point(573, 767);
            this.toMenuBtn.Name = "toMenuBtn";
            this.toMenuBtn.Size = new System.Drawing.Size(400, 80);
            this.toMenuBtn.TabIndex = 1;
            this.toMenuBtn.UseVisualStyleBackColor = true;
            this.toMenuBtn.Click += new System.EventHandler(this.ToMenuBtn_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = global::Task1.Properties.Resources.historyBGcorrect;
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1570, 849);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // tomenufrombordBtn
            // 
            this.tomenufrombordBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tomenufrombordBtn.BackgroundImage")));
            this.tomenufrombordBtn.Location = new System.Drawing.Point(817, 742);
            this.tomenufrombordBtn.Name = "tomenufrombordBtn";
            this.tomenufrombordBtn.Size = new System.Drawing.Size(400, 80);
            this.tomenufrombordBtn.TabIndex = 0;
            this.tomenufrombordBtn.UseVisualStyleBackColor = true;
            this.tomenufrombordBtn.Click += new System.EventHandler(this.ToMenuBtn_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(3, 3);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(1570, 849);
            this.pictureBox5.TabIndex = 1;
            this.pictureBox5.TabStop = false;
            // 
            // backButton
            // 
            this.backButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backButton.BackgroundImage")));
            this.backButton.Location = new System.Drawing.Point(541, 735);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(400, 80);
            this.backButton.TabIndex = 0;
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.ToMenuBtn_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(3, 3);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(1570, 849);
            this.pictureBox6.TabIndex = 1;
            this.pictureBox6.TabStop = false;
            // 
            // gameTabPage
            // 
            this.gameTabPage.BackColor = System.Drawing.Color.Transparent;
            this.gameTabPage.BackgroundImage = global::Task1.Properties.Resources.lygGameBGcorrect;
            this.gameTabPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gameTabPage.Controls.Add(this.nectarLabel);
            this.gameTabPage.Controls.Add(this.beeProgressBar);
            this.gameTabPage.Controls.Add(this.hiveProgressBar);
            this.gameTabPage.Controls.Add(this.hive1);
            this.gameTabPage.Controls.Add(this.bee1);
            this.gameTabPage.Location = new System.Drawing.Point(4, 22);
            this.gameTabPage.Name = "gameTabPage";
            this.gameTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.gameTabPage.Size = new System.Drawing.Size(1576, 855);
            this.gameTabPage.TabIndex = 7;
            this.gameTabPage.Text = "Game";
            this.gameTabPage.MouseMove += new System.Windows.Forms.MouseEventHandler(this.GameTabPage_MouseMove);
            // 
            // nectarLabel
            // 
            this.nectarLabel.AutoSize = true;
            this.nectarLabel.Location = new System.Drawing.Point(1132, 62);
            this.nectarLabel.Name = "nectarLabel";
            this.nectarLabel.Size = new System.Drawing.Size(92, 13);
            this.nectarLabel.TabIndex = 4;
            this.nectarLabel.Text = "Нектар у шмеля:";
            // 
            // beeProgressBar
            // 
            this.beeProgressBar.Location = new System.Drawing.Point(1230, 52);
            this.beeProgressBar.Name = "beeProgressBar";
            this.beeProgressBar.Size = new System.Drawing.Size(136, 23);
            this.beeProgressBar.TabIndex = 1;
            // 
            // hiveProgressBar
            // 
            this.hiveProgressBar.Location = new System.Drawing.Point(22, 6);
            this.hiveProgressBar.Maximum = 1000;
            this.hiveProgressBar.Name = "hiveProgressBar";
            this.hiveProgressBar.Size = new System.Drawing.Size(136, 23);
            this.hiveProgressBar.TabIndex = 0;
            // 
            // hive1
            // 
            this.hive1.BackColor = System.Drawing.Color.Transparent;
            this.hive1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("hive1.BackgroundImage")));
            this.hive1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.hive1.Location = new System.Drawing.Point(8, 52);
            this.hive1.Name = "hive1";
            this.hive1.Nectar = 500;
            this.hive1.Size = new System.Drawing.Size(150, 150);
            this.hive1.TabIndex = 3;
            // 
            // bee1
            // 
            this.bee1.AutoSize = true;
            this.bee1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bee1.BackColor = System.Drawing.Color.Transparent;
            this.bee1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bee1.Location = new System.Drawing.Point(719, 181);
            this.bee1.Name = "bee1";
            this.bee1.Nectar = 0;
            this.bee1.Size = new System.Drawing.Size(106, 63);
            this.bee1.TabIndex = 2;
            // 
            // loseTabPage
            // 
            this.loseTabPage.BackgroundImage = global::Task1.Properties.Resources.end1BGcorrect;
            this.loseTabPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.loseTabPage.Location = new System.Drawing.Point(4, 22);
            this.loseTabPage.Name = "loseTabPage";
            this.loseTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.loseTabPage.Size = new System.Drawing.Size(1576, 855);
            this.loseTabPage.TabIndex = 8;
            this.loseTabPage.Text = "Lose";
            this.loseTabPage.UseVisualStyleBackColor = true;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1584, 881);
            this.Controls.Add(this.mainTabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximumSize = new System.Drawing.Size(1600, 940);
            this.MinimumSize = new System.Drawing.Size(1600, 900);
            this.Name = "GameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bumblebee Simulator";
            this.Load += new System.EventHandler(this.GameForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameForm_KeyDown);
            this.mainTabControl.ResumeLayout(false);
            this.infoTabPage.ResumeLayout(false);
            this.mainMenuTabPage.ResumeLayout(false);
            this.historyTabPage.ResumeLayout(false);
            this.leaderBoardTabPage.ResumeLayout(false);
            this.settingsTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mediaPlayer)).EndInit();
            this.firstTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.gameTabPage.ResumeLayout(false);
            this.gameTabPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage firstTabPage;
        private System.Windows.Forms.TabPage infoTabPage;
        private System.Windows.Forms.TabPage mainMenuTabPage;
        private System.Windows.Forms.TabPage historyTabPage;
        private System.Windows.Forms.Button tomenufrominfoBtn;
        private System.Windows.Forms.Button playBtn;
        private System.Windows.Forms.Button toMenuBtn;
        private System.Windows.Forms.Button toHistoryBtn;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button infoBtn;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button leaderBoardButton;
        private System.Windows.Forms.TabPage leaderBoardTabPage;
        private System.Windows.Forms.Button tomenufrombordBtn;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.TabPage settingsTabPage;
        private System.Windows.Forms.Button backButton;
        private AxWMPLib.AxWindowsMediaPlayer mediaPlayer;
        private System.Windows.Forms.TabPage gameTabPage;
        private System.Windows.Forms.ProgressBar beeProgressBar;
        private System.Windows.Forms.ProgressBar hiveProgressBar;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private Bee bee1;
        private Hive hive1;
        private System.Windows.Forms.Label nectarLabel;
        private System.Windows.Forms.TabPage loseTabPage;
    }
}

