using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LeftBorderButtonDemo
{
    class LeftBorderButton : Button
    {
        public Color hTheme = Color.FromArgb(100, 100, 100);
        public Color cTheme = Color.Firebrick;
        public Color bTheme = Color.FromArgb(64, 64, 64);
        bool focused = false;

        public Color tTheme;
        public LeftBorderButton()
        {
            BackColor = bTheme;
            ForeColor = Color.WhiteSmoke;
            tTheme = ForeColor;
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            Margin = new Padding(0, 0, 0, 0);
            Font = new Font("Lucida Console", this.Font.Size);
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            if (focused == false)
            {
                base.OnMouseEnter(e);

                BackColor = Color.FromArgb(bTheme.R + 24, bTheme.G + 24, bTheme.B + 24);
                Refresh();
            }
            hTheme = cTheme;
            Refresh();
        }


        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            if (focused == false)
            {
                hTheme = Color.FromArgb(bTheme.R + 24, bTheme.G + 24, bTheme.B + 24);
                BackColor = bTheme;
            }
        }
        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);
            BackColor = cTheme;
            ForeColor = tTheme;
            focused = true;
        }

        protected override void OnMouseDown(MouseEventArgs mevent)
        {
            base.OnMouseDown(mevent);
            BackColor = cTheme;
            ForeColor = Color.FromArgb(15, 15, 15);
            focused = true;
        }

        protected override void OnLostFocus(EventArgs e)
        {
            base.OnLostFocus(e);
            BackColor = bTheme;
            focused = false;
            hTheme = Color.FromArgb(bTheme.R + 24, bTheme.G + 24, bTheme.B + 24);
            ForeColor = tTheme;
        }
        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            pevent.Graphics.FillRectangle(new SolidBrush(hTheme), 0, 0, Width / 20, Height);
        }
    }
}
