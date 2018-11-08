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
        Bitmap bitmap;

        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonDraw_Click(object sender, EventArgs e)
        {
            try
            {
                bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);

                Rectangle rectangle = new Rectangle(int.Parse(textBoxN.Text), double.Parse(textBoxR.Text), bitmap);

                bitmap = rectangle.Draw();
                pictureBox1.Image = bitmap;

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
                bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);

                Rectangle rectangle = new Rectangle(int.Parse(textBoxN.Text), double.Parse(textBoxR.Text), bitmap);

                bitmap = rectangle.Draw();
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
