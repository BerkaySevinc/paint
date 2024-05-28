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
    public partial class Canvas : Form
    {

        // Initialize Canvas
        Graphics g;
        public Canvas()
        {
            InitializeComponent();
            g = CreateGraphics();
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
        }


        // Drawing
        private void Canvas_MouseDown(object sender, MouseEventArgs e)
        {
            initialPoint = new Point(e.X, e.Y);
        }

        Point initialPoint;
        private void Canvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button is not MouseButtons.Left) return;

            g.DrawLine(pen, initialPoint, e.Location);
            initialPoint = e.Location;
        }


        // Color Choice
        Pen pen = new(Color.Black, 6);
        private void ColorPalette_Click(object sender, EventArgs e)
        {
            var selectedPalette = (Panel)sender;
            pen.Color = selectedPalette.BackColor;
        }


        // Pen Thickness
        private void Thickness3_Click(object sender, EventArgs e)
        {
            pen.Width = 3;
        }

        private void Thickness6_Click(object sender, EventArgs e)
        {
            pen.Width = 6;
        }

        private void Thickness10_Click(object sender, EventArgs e)
        {
            pen.Width = 10;
        }

        private void Thickness15_Click(object sender, EventArgs e)
        {
            pen.Width = 15;
        }


        // Reset Canvas
        private void Reset_Click(object sender, EventArgs e)
        {
            g.Clear(BackColor);
        }


    }
}
