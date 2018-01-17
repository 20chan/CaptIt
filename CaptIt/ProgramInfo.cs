using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaptIt
{
    public partial class ProgramInfo : Form
    {
        public ProgramInfo()
        {
            InitializeComponent();

            this.btnClose.FlatAppearance.BorderColor =
            this.btnMinimize.FlatAppearance.BorderColor =
            this.btnHouse.FlatAppearance.BorderColor =
            Color.FromArgb(0, 255, 255, 255);
        }

        Point old = new Point();
        private void pFront_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                Location = new Point(this.Left - (old.X - e.X),
                    this.Top - (old.Y - e.Y));
            }
        }

        private void pFront_MouseDown(object sender, MouseEventArgs e)
        {
            old = new Point(e.X, e.Y);
        }

        private void btnHouse_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://studio-sonagi.tistory.com/");
        }

        private void btnHouse_Paint(object sender, PaintEventArgs e)
        {
            Bitmap bmp = Resources1.house;
            bmp.MakeTransparent(Color.FromArgb(240, 113, 81));
            int x = (btnHouse.Width - bmp.Width) / 2;
            int y = (btnHouse.Height - bmp.Height) / 2;
            e.Graphics.DrawImage(bmp, x, y);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
