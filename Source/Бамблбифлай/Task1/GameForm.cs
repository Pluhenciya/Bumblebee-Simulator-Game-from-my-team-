using System;
using System.Diagnostics;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace Task1
{
    public partial class GameForm : Form
    {
        Random random = new Random();
        int mousePositionX;
        int mousePositionY;
        int queenHunger = 1;
        public GameForm()
        {
            InitializeComponent();
            SetStyle(this);
            mainTabControl.Appearance = TabAppearance.FlatButtons;
            mainTabControl.ItemSize = new Size(0, 1);
            mainTabControl.SizeMode = TabSizeMode.Fixed;
            this.MaximumSize = new Size(this.Width, this.Height);
            this.MinimumSize = new Size(this.Width, this.Height);
            SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint, true);

        }

        void SetStyle(Control control)
        {
            foreach (Control item in control.Controls)
            {
                if (item is Button)
                {
                    var button = (Button)item;
                    button.BackColor = Color.FromArgb(255, 204, 150);
                }
                if (item.HasChildren)
                {
                    SetStyle(item);
                }
            }
        }


        private void PlayButton_Click(object sender, EventArgs e)
        {
            mainTabControl.SelectedTab = gameTabPage;
            mediaPlayer.URL = $@"{Environment.CurrentDirectory}\CalmBackground.wav";
            mediaPlayer.settings.setMode("loop", true);
            mediaPlayer.Ctlcontrols.play();
            hive1.Nectar = 500;
            gameTabPage.Controls.Add(bee1);
            gameTabPage.Controls.Add(hive1);
            gameTimer.Start();
            foreach (var item in gameTabPage.Controls)
            {
                if (item is Flower)
                {
                    Flower flower = item as Flower;
                    flower.timer.Stop();
                    gameTabPage.Controls.Remove(flower);
                }
            }
            for (int i = 0; i < 10; i++)
            {
                CreateFlower(i);
            }
        }

        void CreateFlower(int i)
        {
            Flower flower = new Flower(random.Next(100));
            flower.Name = "asd" + i.ToString();
            //flower.BackColor = Color.FromArgb(random.Next(255), random.Next(255), random.Next(255));
            flower.Size = new Size(75, 75);
            flower.Location = new Point(random.Next(75, Width), random.Next(Height / 2, Height - 75));
            gameTabPage.Controls.Add(flower);
            Debug.WriteLine($"{flower.Location.X} {flower.Location.Y}");
        }


        private void GameForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                mainTabControl.SelectedTab = mainMenuTabPage;
                gameTimer.Stop();
            }
            if (e.KeyCode == Keys.E)
                bee1.Interact(gameTabPage);
        }

        private void GameForm_Load(object sender, EventArgs e)
        {
            new SoundPlayer(SoundsResx.LogoLoad).Play();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ToHistoryBtn_Click(object sender, EventArgs e)
        {
            mainTabControl.SelectedTab = historyTabPage;
        }

        private void InfoBtn_Click(object sender, EventArgs e)
        {
            mainTabControl.SelectedTab = infoTabPage;
        }

        private void ToMenuBtn_Click(object sender, EventArgs e)
        {
            mainTabControl.SelectedTab = mainMenuTabPage;
        }

        private void ToSettingsBtn_Click(object sender, EventArgs e)
        {
            mainTabControl.SelectedTab = settingsTabPage;
        }

        private void Button_SoundMouseEnter(object sender, EventArgs e)
        {
            new SoundPlayer(SoundsResx.Buttonsound2).Play();
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            bee1.Move(mousePositionX, mousePositionY);
            try
            {
                hive1.Nectar -= queenHunger;
                if (hive1.Nectar <= hiveProgressBar.Maximum)
                    hiveProgressBar.Value = hive1.nectar;
            }
            catch (Exception)
            {
                gameTimer.Stop();
                mainTabControl.SelectedTab = loseTabPage;
            }
            beeProgressBar.Value = bee1.Nectar;
        }

        private void GameTabPage_MouseMove(object sender, MouseEventArgs e)
        {
            mousePositionX = e.X - bee1.Width / 2;
            mousePositionY = e.Y - bee1.Height / 2;
            //bee1.Location = new Point(e.X, e.Y);
        }

        private void LeaderBoardButton_Click(object sender, EventArgs e)
        {
            mainTabControl.SelectedTab = leaderBoardTabPage;
        }
    }
}
