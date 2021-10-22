using System;
using System.Windows.Forms;

namespace WfClock
{
    public partial class formClock : Form
    {
        public int leftClick { get; set; }
        public int rightClick { get; set; }
        public int midleClick { get; set; }

        public formClock()
        {
            InitializeComponent();
            this.Text = $"Кликов левой мыши {leftClick}, кликов правой кнопкой мыши {rightClick}, кликов средней кнопкой мыши {midleClick}.";
        }

        private void Clock_Load(object sender, EventArgs e)
        {
            timer1_Tick(sender, e);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            timer1.Interval = 1;
            labelShoweTime.Text = DateTime.Now.ToString();
            timer1.Start();
        }

        private void Clock_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                leftClick++;
            }
            else if (e.Button == MouseButtons.Right)
            {
                rightClick++;
            }
            else if (e.Button == MouseButtons.Middle)
            {
                midleClick++;
            }
            this.Text = $"Кликов левой мыши {leftClick}, кликов правой кнопкой мыши {rightClick}, кликов средней кнопкой мыши {midleClick}.";
        }
    }
}
