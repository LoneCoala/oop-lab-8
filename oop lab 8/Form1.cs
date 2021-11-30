using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oop_lab_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Width = 1040;
            this.Height = 682;
            bm = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(bm);
            pictureBox1.Image = bm;
            p.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            p.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            erase.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            erase.EndCap = System.Drawing.Drawing2D.LineCap.Round;
        }

        Bitmap bm;
        Graphics g;
        bool paint = false;
        Point px, py;
        Pen p = new Pen(Color.Black, 5);
        Pen erase = new Pen(Color.White, 5);
        int x, y, Sx, Sy, cX, cY;
        ColorDialog cd = new ColorDialog();
        Color new_color;
        SolidBrush Sb = new SolidBrush(Color.White);

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            paint = true;
            py = e.Location;
            cX = e.X;
            cY = e.Y;

        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            paint = false;
            Sx = x - cX;
            Sy = y - cY;
            if (radioButton2.Checked == true)
            {

                g.DrawEllipse(p, cX, cY, Sx, Sy);
                g.FillEllipse(Sb, cX, cY, Sx, Sy);


            }

            if (radioButton3.Checked == true)
            {

                g.DrawRectangle(p, cX, cY, Sx, Sy);
                g.FillRectangle(Sb, cX, cY, Sx, Sy);

            }

            if (radioButton1.Checked == true)
            {
                g.DrawLine(p, cX, cY, x, y);
            }


        }
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {

            if (paint)
            {
                if (radioButton4.Checked == true)
                {
                    px = e.Location;
                    g.DrawLine(p, px, py);
                    py = px;
                }

                if (radioButton5.Checked == true)
                {
                    px = e.Location;
                    g.DrawLine(erase, px, py);
                    py = px;

                }


            }
            pictureBox1.Refresh();
            x = e.X;
            y = e.Y;
            Sx = e.X - cX;
            Sy = e.Y - cY;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            if (paint)
            {
                if (radioButton2.Checked == true)
                {

                    g.DrawEllipse(p, cX, cY, Sx, Sy);
                    g.FillEllipse(Sb, cX, cY, Sx, Sy);

                }

                if (radioButton3.Checked == true)
                {
                    g.DrawRectangle(p, cX, cY, Sx, Sy);
                    g.FillRectangle(Sb, cX, cY, Sx, Sy);
                }

                if (radioButton1.Checked == true)
                {
                    g.DrawLine(p, cX, cY, x, y);
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                new_color = cd.Color;
                line_color.BackColor = cd.Color;
                p.Color = cd.Color;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                new_color = cd.Color;
                bg_color.BackColor = cd.Color;
                g.Clear(cd.Color);
                pictureBox1.Refresh();
            }

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown1.Maximum = 100;
            numericUpDown1.Minimum = 1;

            int a = (int)numericUpDown1.Value;

            for (int i = 1; i < a; i++)
            {
                p.Width = i * 5;

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void line_color_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void bg_color_Click(object sender, EventArgs e)
        {

        }
        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown2.Maximum = 100;
            numericUpDown2.Minimum = 1;

            int a = (int)numericUpDown2.Value;

            for (int i = 1; i < a; i++)
            {
                erase.Width = i * 10;
            }
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                new_color = cd.Color;
                Sb.Color = new_color;
                fill_color.BackColor = cd.Color;
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            pictureBox1.Refresh();
            bg_color.BackColor = Color.White;

        }
        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {

        }

    }
}