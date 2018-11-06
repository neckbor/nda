﻿using System;
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

            double angle = (n - 2) * 180 / n;
            angle = (Math.PI * angle) / 180;

            Point centr = new Point(200, 200);
            double R = 100;

            Point p1 = GetVertwex(centr, R, n, 0);
            Point p2;

            for (int i = 1; i <= n; i++)
            {
                p2 = GetVertwex(centr, R, n, i);

                //DrawLineDDA(p1, p2);
                //Bresenham(p1, p2);
                DrawLineHabr(p1, p2);

                p1 = p2;
            }
        }

        //высчитывет вершину
        private Point GetVertwex(Point pointCentr, double R, int n, int i)
        {
            Point p = new Point();

            double x = pointCentr.X + R * Math.Cos(2 * Math.PI * i / n);
            double y = pointCentr.Y + R * Math.Sin(2 * Math.PI * i / n);

            p.X = (int)Math.Round(x, MidpointRounding.AwayFromZero);
            p.Y = (int)Math.Round(y, MidpointRounding.AwayFromZero);

            return p;
        }

        private void CalculateEquation(Point p1, Point p2)
        {
            float a = (float)(p2.Y - p1.Y) / (float)(p2.X - p1.X);
        }

        //алгоритм для рисования прямых
        private void DrawLineHabr(Point start, Point end)
        {
            bool flag = false;
            if(Math.Abs(start.X - end.X) < Math.Abs(start.Y - end.Y))
            {
                Interpolate(ref start, ref end);
                flag = true;
            }

            if (start.X > end.X)
            {
                Swap(ref start, ref end);
            }

            float a = (float)(end.Y - start.Y) / (float)(end.X - start.X);
            double y = start.Y;

            for (int x = start.X; x <= end.X; x++)
            {
                int yy = (int)Math.Round(y, MidpointRounding.AwayFromZero);

                if(flag)
                    bitmap.SetPixel(yy, x, Color.Black);
                else
                    bitmap.SetPixel(x, yy, Color.Black);

                y += a;
            }
        }

        private void Swap(ref Point start, ref Point end)
        {
            int a = start.X;
            start.X = end.X;
            end.X = a;

            a = start.Y;
            start.Y = end.Y;
            end.Y = a;
        }

        private void Interpolate(ref Point start, ref Point end)
        {
            int a = start.X;
            start.X = start.Y;
            start.Y = a;

            a = end.X;
            end.X = end.Y;
            end.Y = a;
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
