using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task1
{
    internal class Flower : UserControl
    {
        private Label nectarAmountLabel;
        private ImageList imageList1;
        private System.ComponentModel.IContainer components;
        public Timer timer;
        public int NectarAmount { get; set; }
        int speed = 1;

        static Random random = new Random();

        public Flower(int nectarAmount)
        {
            InitializeComponent();
            int image = random.Next(imageList1.Images.Count);
            BackgroundImage = imageList1.Images[image];
            NectarAmount = nectarAmount;
            speed = image + 1;

            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            NectarAmount += speed;
            nectarAmountLabel.Text = NectarAmount.ToString();
        }


        public void GiveNectar(Bee bee)
        {
            if (NectarAmount > 0)
            {
                bee.Nectar += NectarAmount;
                NectarAmount -= NectarAmount;
            }
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Flower));
            this.nectarAmountLabel = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // nectarAmountLabel
            // 
            this.nectarAmountLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nectarAmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nectarAmountLabel.Location = new System.Drawing.Point(0, 0);
            this.nectarAmountLabel.Name = "nectarAmountLabel";
            this.nectarAmountLabel.Size = new System.Drawing.Size(150, 150);
            this.nectarAmountLabel.TabIndex = 0;
            this.nectarAmountLabel.Text = "0";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "blue_flower_nektar.png");
            this.imageList1.Images.SetKeyName(1, "green_flower_nektar.png");
            this.imageList1.Images.SetKeyName(2, "red_flower_nektar.png");
            this.imageList1.Images.SetKeyName(3, "yellow_flower_nektar.png");
            // 
            // Flower
            // 
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::Task1.Properties.Resources.blue_flower_nektar;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Controls.Add(this.nectarAmountLabel);
            this.DoubleBuffered = true;
            this.Name = "Flower";
            this.ResumeLayout(false);

        }
    }
}
