﻿using System;
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

        // Initializes canvas.
        Graphics g;
        public Canvas()
        {
            InitializeComponent();
            g = CreateGraphics();
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
        }


        // Gets cursor location when left mouse button is down.
        Point initialPoint;
        private void Canvas_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button is not MouseButtons.Left) return;

            initialPoint = new Point(e.X, e.Y);
        }

        // Draws line when mouse is moving if left mouse button is down.
        private void Canvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button is not MouseButtons.Left) return;

            g.DrawLine(pen, initialPoint, e.Location);
            initialPoint = e.Location;
        }


        // Sets pen color.
        Pen pen = new(Color.Black, 6);
        private void ColorPalette_Click(object sender, EventArgs e)
        {
            var selectedPalette = (Panel)sender;
            pen.Color = selectedPalette.BackColor;
        }


        // Sets pen thickness.
        private void Thickness3_Click(object sender, EventArgs e) => pen.Width = 3;
        private void Thickness6_Click(object sender, EventArgs e) => pen.Width = 6;
        private void Thickness10_Click(object sender, EventArgs e) => pen.Width = 10;
        private void Thickness15_Click(object sender, EventArgs e) => pen.Width = 15;


        // Resets canvas.
        private void Reset_Click(object sender, EventArgs e) => g.Clear(BackColor);


    }
}
