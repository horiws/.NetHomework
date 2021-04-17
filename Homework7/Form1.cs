using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Graphics graphics;
        double th = -Math.PI / 2;
        //double th1 = 30 * Math.PI / 180;
        //double th2 = 20 * Math.PI / 180;
        //double per1 = 0.6;
        //double per2 = 0.7;

        private void drawBtn_Click(object sender, EventArgs e)
        {
            if (graphics == null) graphics = this.pictureBox1.CreateGraphics();

            int n = int.Parse(textBoxN.Text);
            double leng = double.Parse(textBoxLeng.Text);
            double per1 = double.Parse(textBoxPer1.Text);
            double per2 = double.Parse(textBoxPer2.Text);
            double th1 = double.Parse(textBoxTh1.Text);
            double th2 = double.Parse(textBoxTh2.Text);
            string color = textBoxPen.Text;

            drawCayleyTree(n, 200, 310, leng, th, th1, th2, per1, per2, color);
        }

        void drawCayleyTree(int n, double x0, double y0, double leng, double th,
            double th1, double th2, double per1, double per2, string color)
        {
            if (n == 0) return;

            double x1 = x0 + leng * Math.Cos(th);
            double y1 = y0 + leng * Math.Sin(th);

            drawLine(x0, y0, x1, y1, color);

            drawCayleyTree(n - 1, x1, y1, per1 * leng, th - th1, th1, th2, per1, per2, color);
            drawCayleyTree(n - 1, x1, y1, per2 * leng, th - th2, th1, th2, per1, per2, color);
        }

        void drawLine(double x0, double y0, double x1, double y1, string color)
        {
            Color penColor = Color.FromName(color);
            Pen pen = new Pen(penColor);
            graphics.DrawLine(
                pen,
                (int)x0, (int)y0, (int)x1, (int)y1
                );
        }

    }
}
