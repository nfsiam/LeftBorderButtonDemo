using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace LeftBorderButtonDemo
{
    public partial class Form1 : Form
    {
        Thread thr1;
        public Form1()
        {
            InitializeComponent();
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            thr1.Abort();
            this.Dispose();
        }
        private void LeftBorderButton4_Click(object sender, EventArgs e)
        {
            InitAnim();
        }
        private void LeftBorderButton2_Click(object sender, EventArgs e)
        {
            InitAnim();
        }
        private void LeftBorderButton3_Click(object sender, EventArgs e)
        {
            InitAnim();
        }
        private void LeftBorderButton1_Click(object sender, EventArgs e)
        {
            InitAnim();
        }
        public void InitAnim()
        {
            if (thr1 == null || !thr1.IsAlive)
            {
                thr1 = new Thread(LabelAnim);
                thr1.Start();
            }
            else
            {
                label1.Location = new Point(293, 451);
                thr1.Abort();
                thr1 = new Thread(LabelAnim);
                thr1.Start();
            }
        }
        public void LabelAnim()
        {
            int x = 293;
            int y = 451;

            label1.Invoke((MethodInvoker)delegate
            {
                label1.Visible = true;
                label1.Location = new Point(x, y);
                label1.Refresh();
            });

            while (label1.Location.Y >= 175)
            {
                y -= 1;
                label1.Invoke((MethodInvoker)delegate
                {
                    label1.Location = new Point(x, y);
                    label1.Refresh();
                });
                Thread.Sleep(10);
            }
        }
    }
}