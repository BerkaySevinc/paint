using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            g = this.CreateGraphics();
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
        }


        Pen pen = new Pen(Color.Black, 6);
        private void panel2_Click(object sender, EventArgs e)
        {
            Panel selected = (Panel)sender;
            pen.Color = selected.BackColor;
        }




        bool draw = false;
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;
            draw = true;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            draw = false;
        }


        Graphics g;
        int x = -1;
        int y = -1;
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (!draw) return;

            g.DrawLine(pen, new Point(x, y), e.Location);
            x = e.X;
            y = e.Y;
        }




        private void panel9_Click(object sender, EventArgs e)
        {
            pen.Width = 3;
        }

        private void panel11_Click(object sender, EventArgs e)
        {
            pen.Width = 6;
        }

        private void panel13_Click(object sender, EventArgs e)
        {
            pen.Width = 10;
        }

        private void panel15_Click(object sender, EventArgs e)
        {
            pen.Width = 15;
        }


        private void label1_Click(object sender, EventArgs e)
        {
            g.Clear(Color.FromArgb(240, 240, 240));
        }

    }
}
