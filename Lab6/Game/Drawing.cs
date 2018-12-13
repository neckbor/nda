using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class Drawing
    {
        public static void DrawTarget()
        { }

        public static void DrawRocket()
        { }

        public static Graphics DrawBackGround(Graphics g)
        {
            //g.Clear(Color.White);

            //фон
            g.FillRectangle(Brushes.CornflowerBlue, 0, 0, 1400, 930); //Заливка глубым либо CadetBlue либо CornflowerBlue

            //прицел
            Pen pen = new Pen(Color.Black, 4);
            g.DrawEllipse(pen, 700, 620, 20, 20);
            g.DrawEllipse(pen, 690, 610, 40, 40);
            g.DrawEllipse(pen, 668, 588, 84, 84);
            g.DrawEllipse(pen, 648, 568, 124, 124);
            g.DrawLine(pen, 648, 630, 772, 630);
            g.DrawLine(pen, 710, 568, 710, 692);
            g.DrawLine(pen, 648, 630, 648, 705);
            g.DrawLine(pen, 772, 630, 772, 705);

            //приборная панель
            Point[] panel = new Point[] { new Point(200, 930), new Point(250, 800), new Point(700, 700), new Point(1150, 800), new Point(1200, 930) }; 
            g.FillClosedCurve(Brushes.DarkSlateGray, panel); 

            //кнопошки всякие разные

            g.Dispose();
            return g;
        }
    }
}
