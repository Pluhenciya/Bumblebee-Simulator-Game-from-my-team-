using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task1
{
    internal class Hive : UserControl
    {

        public int maximum = 100000;
        public int nectar = 500;
        public int score = 0;

        public Hive()
        {
            InitializeComponent();
        }

        public int Nectar
        {
            get => nectar;
            set
            {
                if (nectar == 1)
                {
                    nectar = -1; //Открываем страницу концовки бездельник
                }
                else if (nectar + value > maximum)
                {
                    nectar = maximum;
                }
                else
                {
                    nectar = value;
                }
            }
        }

        public void TakeNectar(Bee bee)
        {
            Nectar += bee.Nectar;
            score += bee.Nectar / 10;
            bee.Nectar = 0;
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Hive
            // 
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::Task1.Properties.Resources.HIVE;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.DoubleBuffered = true;
            this.Name = "Hive";
            this.ResumeLayout(false);

        }
    }
}
