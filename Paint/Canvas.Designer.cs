
namespace Paint
{
    partial class Canvas
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label1 = new Label();
            panel14 = new Panel();
            panel15 = new Panel();
            panel16 = new Panel();
            panel13 = new Panel();
            panel11 = new Panel();
            panel12 = new Panel();
            panel9 = new Panel();
            panel10 = new Panel();
            panel8 = new Panel();
            panel7 = new Panel();
            panel6 = new Panel();
            panel5 = new Panel();
            panel4 = new Panel();
            panel3 = new Panel();
            panel2 = new Panel();
            panel1.SuspendLayout();
            panel15.SuspendLayout();
            panel11.SuspendLayout();
            panel9.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(100, 100, 100);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel14);
            panel1.Controls.Add(panel15);
            panel1.Controls.Add(panel13);
            panel1.Controls.Add(panel11);
            panel1.Controls.Add(panel9);
            panel1.Controls.Add(panel8);
            panel1.Controls.Add(panel7);
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1030, 68);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Cursor = Cursors.Hand;
            label1.Font = new Font("Webdings", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(240, 240, 240);
            label1.Location = new Point(814, 14);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(55, 39);
            label1.TabIndex = 16;
            label1.Text = "x";
            label1.Click += Reset_Click;
            // 
            // panel14
            // 
            panel14.BackColor = Color.Black;
            panel14.Cursor = Cursors.Hand;
            panel14.Location = new Point(640, 29);
            panel14.Margin = new Padding(4, 3, 4, 3);
            panel14.Name = "panel14";
            panel14.Size = new Size(41, 12);
            panel14.TabIndex = 15;
            panel14.Click += Thickness10_Click;
            // 
            // panel15
            // 
            panel15.BackColor = Color.FromArgb(240, 240, 240);
            panel15.Controls.Add(panel16);
            panel15.Cursor = Cursors.Hand;
            panel15.Location = new Point(688, 14);
            panel15.Margin = new Padding(4, 3, 4, 3);
            panel15.Name = "panel15";
            panel15.Size = new Size(41, 40);
            panel15.TabIndex = 12;
            panel15.Click += Thickness15_Click;
            // 
            // panel16
            // 
            panel16.BackColor = Color.Black;
            panel16.Cursor = Cursors.Hand;
            panel16.Location = new Point(0, 12);
            panel16.Margin = new Padding(4, 3, 4, 3);
            panel16.Name = "panel16";
            panel16.Size = new Size(41, 17);
            panel16.TabIndex = 16;
            panel16.Click += Thickness15_Click;
            // 
            // panel13
            // 
            panel13.BackColor = Color.FromArgb(240, 240, 240);
            panel13.Cursor = Cursors.Hand;
            panel13.Location = new Point(640, 14);
            panel13.Margin = new Padding(4, 3, 4, 3);
            panel13.Name = "panel13";
            panel13.Size = new Size(41, 40);
            panel13.TabIndex = 11;
            panel13.Click += Thickness10_Click;
            // 
            // panel11
            // 
            panel11.BackColor = Color.FromArgb(240, 240, 240);
            panel11.Controls.Add(panel12);
            panel11.Cursor = Cursors.Hand;
            panel11.Location = new Point(593, 14);
            panel11.Margin = new Padding(4, 3, 4, 3);
            panel11.Name = "panel11";
            panel11.Size = new Size(41, 40);
            panel11.TabIndex = 10;
            panel11.Click += Thickness6_Click;
            // 
            // panel12
            // 
            panel12.BackColor = Color.Black;
            panel12.Cursor = Cursors.Hand;
            panel12.Location = new Point(0, 17);
            panel12.Margin = new Padding(4, 3, 4, 3);
            panel12.Name = "panel12";
            panel12.Size = new Size(41, 7);
            panel12.TabIndex = 14;
            panel12.Click += Thickness6_Click;
            // 
            // panel9
            // 
            panel9.BackColor = Color.FromArgb(240, 240, 240);
            panel9.Controls.Add(panel10);
            panel9.Cursor = Cursors.Hand;
            panel9.Location = new Point(545, 14);
            panel9.Margin = new Padding(4, 3, 4, 3);
            panel9.Name = "panel9";
            panel9.Size = new Size(41, 40);
            panel9.TabIndex = 8;
            panel9.Click += Thickness3_Click;
            // 
            // panel10
            // 
            panel10.BackColor = Color.Black;
            panel10.Cursor = Cursors.Hand;
            panel10.Location = new Point(0, 19);
            panel10.Margin = new Padding(4, 3, 4, 3);
            panel10.Name = "panel10";
            panel10.Size = new Size(41, 3);
            panel10.TabIndex = 13;
            panel10.Click += Thickness3_Click;
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(240, 240, 240);
            panel8.Cursor = Cursors.Hand;
            panel8.Location = new Point(354, 14);
            panel8.Margin = new Padding(4, 3, 4, 3);
            panel8.Name = "panel8";
            panel8.Size = new Size(41, 40);
            panel8.TabIndex = 7;
            panel8.Click += ColorPalette_Click;
            // 
            // panel7
            // 
            panel7.BackColor = Color.Black;
            panel7.Cursor = Cursors.Hand;
            panel7.Location = new Point(257, 14);
            panel7.Margin = new Padding(4, 3, 4, 3);
            panel7.Name = "panel7";
            panel7.Size = new Size(41, 40);
            panel7.TabIndex = 6;
            panel7.Click += ColorPalette_Click;
            // 
            // panel6
            // 
            panel6.BackColor = Color.BlueViolet;
            panel6.Cursor = Cursors.Hand;
            panel6.Location = new Point(209, 14);
            panel6.Margin = new Padding(4, 3, 4, 3);
            panel6.Name = "panel6";
            panel6.Size = new Size(41, 40);
            panel6.TabIndex = 5;
            panel6.Click += ColorPalette_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.DodgerBlue;
            panel5.Cursor = Cursors.Hand;
            panel5.Location = new Point(161, 14);
            panel5.Margin = new Padding(4, 3, 4, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(41, 40);
            panel5.TabIndex = 4;
            panel5.Click += ColorPalette_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.LimeGreen;
            panel4.Cursor = Cursors.Hand;
            panel4.Location = new Point(113, 14);
            panel4.Margin = new Padding(4, 3, 4, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(41, 40);
            panel4.TabIndex = 3;
            panel4.Click += ColorPalette_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Yellow;
            panel3.Cursor = Cursors.Hand;
            panel3.Location = new Point(65, 14);
            panel3.Margin = new Padding(4, 3, 4, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(41, 40);
            panel3.TabIndex = 2;
            panel3.Click += ColorPalette_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Red;
            panel2.Cursor = Cursors.Hand;
            panel2.Location = new Point(18, 14);
            panel2.Margin = new Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(41, 40);
            panel2.TabIndex = 1;
            panel2.Click += ColorPalette_Click;
            // 
            // Canvas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 240, 240);
            ClientSize = new Size(1011, 601);
            Controls.Add(panel1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Canvas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Paint";
            MouseDown += Canvas_MouseDown;
            MouseMove += Canvas_MouseMove;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel15.ResumeLayout(false);
            panel11.ResumeLayout(false);
            panel9.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label1;
    }
}

