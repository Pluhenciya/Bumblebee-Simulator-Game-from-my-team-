using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task1
{
    internal class Bee : UserControl
    {
        private int nectar;
        private PictureBox beePictureBox;

        public int Maximum { get => 100; }
        public int Nectar
        {
            get => nectar; set
            {
                if (nectar + value > Maximum)
                {
                    nectar = Maximum;
                }
                else
                {
                    nectar = value;
                }
            }
        }
        private int slownes = 20;

        public Bee()
        {
            InitializeComponent();

            
        }

        //protected override void OnPaint(PaintEventArgs e)
        //{
        //    base.OnPaint(e);

        //    GraphicsPath path = new GraphicsPath();
        //    path.AddEllipse(0, 0, Width, Height);
        //    Region = new Region(path);
        //}
        /// <summary>
        /// Двигает пчелу к курсору
        /// Этот метод вызывать в таймере
        /// </summary>
        /// <param name="bee">Что двигают</param>
        /// <param name="mousePositionX">Горизонтальная координата к которой стремятся</param>
        /// <param name="mousePositionY">Вертикальная координата к которой стремятся</param>
        public void Move(int mousePositionX, int mousePositionY)
        {
            this.Location = new Point(
                this.Location.X + (-this.Location.X + mousePositionX) / slownes,
                this.Location.Y + (-this.Location.Y + mousePositionY) / slownes);
        }

        public void Interact(Panel mainPanel)
        {
            var bounds = this.Bounds;
            foreach (var item in mainPanel.Controls)
            {
                if (item is Flower)
                {
                    Flower flower = item as Flower;
                    if (bounds.IntersectsWith(flower.Bounds))
                    {
                        flower.GiveNectar(this);
                    }
                }
                if (item is Hive)
                {

                    Hive hive = item as Hive;
                    if (bounds.IntersectsWith(hive.Bounds))
                    {
                        hive.TakeNectar(this);
                    }
                }
            }
        }
        private void InitializeComponent()
        {
            this.beePictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.beePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // beePictureBox
            // 
            this.beePictureBox.BackColor = System.Drawing.Color.Transparent;
            this.beePictureBox.Image = global::Task1.Properties.Resources.BEENoBG;
            this.beePictureBox.Location = new System.Drawing.Point(3, 0);
            this.beePictureBox.Name = "beePictureBox";
            this.beePictureBox.Size = new System.Drawing.Size(100, 60);
            this.beePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.beePictureBox.TabIndex = 0;
            this.beePictureBox.TabStop = false;
            // 
            // Bee
            // 
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Controls.Add(this.beePictureBox);
            this.DoubleBuffered = true;
            this.Name = "Bee";
            this.Size = new System.Drawing.Size(106, 63);
            ((System.ComponentModel.ISupportInitialize)(this.beePictureBox)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
