using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3
{
    public partial class MainForm : Form
    {
        Graphics g;
        Bitmap bitmap;

        public MainForm()
        {
            InitializeComponent();
        }

        //рисует многоугольник
        private void DrawRectangle(double r, int n)
        {
            
            bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(bitmap);
            //g.Clear(Color.White);

            double angle = (n - 2) * 180 / n;
            angle = (Math.PI * angle) / 180;
            //int a = 70;

            PointF centr = new PointF(200, 200);
            double R = 100;

            //PointF end = DrawEdge(start, a, angle);

            PointF p1 = GetVertwex(centr, R, n, 0);
            PointF p2;

            for (int i = 1; i <= n; i++)
            {
                p2 = GetVertwex(centr, R, n, i);

                //g.DrawLine(Pens.Black, p1, p2);
                //DrawLineDDA(p1, p2);

                p1 = p2;
            }
        }

        //высчитывет вершину
        private PointF GetVertwex(PointF pointCentr, double R, int n, int i)
        {
            PointF p = new PointF();

            p.X = (float)(pointCentr.X + R * Math.Cos(2 * Math.PI * i / n));
            p.Y = (float)(pointCentr.Y + R * Math.Sin(2 * Math.PI * i / n));

            return p;
        }

        //алгоритм для рисования прямых
        private void DrawLineDDA(PointF start, PointF end)
        {
            double L = Math.Max(Math.Abs(end.X - start.X), Math.Abs(end.Y - start.Y));
            double dx = (end.X - start.X) / L;
            double dy = (end.Y - start.Y) / L;
            double x = start.X;
            double y = start.Y;

            for (int i = 0; i <= L; i++)
            {
                x += dx;
                y += dy;

                x = Math.Round(x, 0);
                y = Math.Round(y, 0);

                bitmap.SetPixel((int)x, (int)y, Color.Black);
                
            }
        }

        private void buttonDraw_Click(object sender, EventArgs e)
        {
            try
            {
                DrawRectangle(double.Parse(textBoxR.Text), int.Parse(textBoxN.Text));

                pictureBox1.Image = bitmap;
                //g.DrawLine(Pens.Black, 100, 100, 103, 109);
                //g.DrawLine(Pens.Black, 103, 109, 106, 119);
                //g.DrawLine(Pens.Black, 106, 119, 109, 128);
                //g.DrawLine(Pens.Black, 109, 128, 112, 138);
                //g.DrawLine(Pens.Black, 112, 138, 115, 147);

            }
            catch(Exception ex)
            {
                textBoxN.Text = "";
                textBoxR.Text = "";
            }

        }


        private void PaintForm(object sender, PaintEventArgs e)
        {
            try
            {
                DrawRectangle(double.Parse(textBoxR.Text), int.Parse(textBoxN.Text));

                pictureBox1.Image = bitmap;
            }
            catch (Exception ex)
            { }
        }

        //protected override void OnPaint(PaintEventArgs e)
        //{
        //    base.OnPaint(e);

        //    try
        //    {
        //        Graphics g = this.CreateGraphics();
        //        DrawRectangle(1, 5);

        //        g.DrawLine(Pens.Black, 200, 200, 200, 230);
        //        g.DrawLine(Pens.Black, 200, 200, 240, 260);

        //        //g = Graphics.FromImage(bitmap);
        //        g.Dispose();
        //    }
        //    catch (Exception ex)
        //    {
        //        textBoxN.Text = "";
        //        textBoxR.Text = "";
        //    }
        //}

        //private PointF DrawEdge(PointF start, int a, double angle)
        //{
        //    float dx = (float)(a * Math.Cos(angle));
        //    float dy = (float)(a * Math.Sin(angle));
        //    PointF end = new PointF(start.X + dx, start.Y + dy);



        //    g.DrawLine(Pens.Black, start, end);
        //    //DrawLineDDA(start, end);
        //    //gr = Graphics.FromImage(bitmap);
        //    //gr.Clear(Color.White);

        //    return end;
        //}
    }
}
