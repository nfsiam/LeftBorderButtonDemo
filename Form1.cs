using System;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace LeftBorderButtonDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void LeftBorderButton4_Click(object sender, EventArgs e)
        {
            LabelAnim();
        }

        private void LeftBorderButton2_Click(object sender, EventArgs e)
        {
            LabelAnim();
        }

        private void LeftBorderButton3_Click(object sender, EventArgs e)
        {
            LabelAnim();
        }

        private void LeftBorderButton1_Click(object sender, EventArgs e)
        {
            LabelAnim();
        }

        public void LabelAnim()
        {


            label1.Visible = true;
            int x = 293;
            int y = 451;
            label1.Location = new Point(x, y);
            label1.Refresh();

            while (label1.Location.Y >= 175)
            {
                label1.Location = new Point(x, y);
                y -= 1;
                label1.Refresh();
                Thread.Sleep(1);
            }

        }
    }
}
