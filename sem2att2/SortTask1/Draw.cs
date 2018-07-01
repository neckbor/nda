using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortTask1
{
    class Draw
    {
        private Element[] _mas;
        public Graphics g;
        private Color color;
        private int _count = 1;

        public Draw(Graphics g, Color color)
        {
            _mas = CreateMas();
            this.g = g;
            this.color = color;
        }

        public void NatureMerge()
        {

        }

       private Element[] DrawNatureSort(Element[] mas)
        {
            List<Element> series1 = new List<Element>(),
                          series2 = new List<Element>();
            int count = 0;

            for (int i = 0; i < mas.Length - 1; i++)
                if (mas[i].val < mas[i + 1].val)
                {
                    if (count % 2 == 0)
                        series2.Add(mas[i]);
                    else
                        series1.Add(mas[i]);
                }
                else
                    count++;

            // mas = Merge(series1, series2);
            if (count == 1) { }
                //NatureMergeSort(mas);

            return mas;
        }

        //private Element[] Merge(List<Element> arr1, List<Element> arr2)
        //{

        //}











        public void SimpleMerge()
        {
            Element[] arr = new Element[_mas.Length];
            arr = DrawSimpleMergeSort(_mas);

            ClearGr();
            DrawState(arr);
        }

        private Element[] DrawSimpleMergeSort(Element[] arr)
        {
            if (arr.Length == 1)
            {
                arr[0].y += 30;
                DrawState(arr);
                return arr;
            }

            Element[] arr1, arr2;

            DrawState(arr);

            if (arr.Length == 2)
            {
                arr1 = new Element[1];
                arr2 = new Element[1];
            }
            else
                if (arr.Length % 2 == 0)
                {
                    arr1 = new Element[arr.Length / 2];
                    arr2 = new Element[arr.Length / 2];
                }
                else
                {
                    arr1 = new Element[arr.Length / 2 + 1];
                    arr2 = new Element[arr.Length / 2];
                }

            int a = 0, b = 0;

            for (int i = 0; i < arr.Length; i++)
                if (a < arr1.Length)
                    arr1[a++] = arr[i];
                else
                    arr2[b++] = arr[i];

            foreach (Element el in arr2)
            {
                el.y += 30;
                el.x += 100 / _count;
            }

            foreach (Element el in arr1)
                el.y += 30;

            _count++;

            DrawState(arr1);
            DrawState(arr2);
            System.Threading.Thread.Sleep(1000);

            arr1 = DrawSimpleMergeSort(arr1);
            arr2 = DrawSimpleMergeSort(arr2);


            arr = Merge(arr1, arr2);

            return arr;
        }

        private Element[] Merge(Element[] arr1, Element[] arr2)
        { 
            Element[] aRR = new Element[arr1.Length + arr2.Length];

            int a = 0,
                b = 0;

            for (int i = 0; i < aRR.Length; i++)
                if (a < arr1.Length && b < arr2.Length)
                {
                    DrawCompare(arr1[a], arr2[b]);
                    System.Threading.Thread.Sleep(1000);

                    if (arr1[a].val < arr2[b].val)
                    {
                        aRR[i] = arr1[a++];
                        aRR[i].y += 30;
                        aRR[i].x = i * 25;

                        DrawState(aRR);
                        DrawState(arr1);
                        System.Threading.Thread.Sleep(1000);
                    }
                    else
                    {
                        aRR[i] = arr2[b++];
                        aRR[i].y += 30;
                        aRR[i].x = i * 25;

                        DrawState(aRR);
                        DrawState(arr2);
                        System.Threading.Thread.Sleep(1000);
                    }
                }
                else
                {
                    if (a < arr1.Length)
                    {
                        aRR[i] = arr1[a++];
                        aRR[i].y += 30;
                        aRR[i].x = i * 25;

                        DrawState(aRR);
                        DrawState(arr1);
                        System.Threading.Thread.Sleep(1000);
                    }
                    else
                    {
                        aRR[i] = arr2[b++];
                        aRR[i].y += 30;
                        aRR[i].x = i * 25;

                        DrawState(aRR);
                        DrawState(arr2);
                        System.Threading.Thread.Sleep(1000);
                    }
                }

            DrawState(aRR);
            System.Threading.Thread.Sleep(1000);

            return aRR;
        }

        private void ClearLine(int x, int y)
        {
            Pen pen = new Pen(color);
            SolidBrush brush = new SolidBrush(color);
            g.DrawRectangle(pen, x, y, 250, 30);
            g.FillRectangle(brush, x, y, 250, 30);
        }

        private Element[] CreateMas()
        {
            Element[] mas = new Element[10];

            Random rnd = new Random();

            int cX = 0;

            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = new Element();
                mas[i].val = rnd.Next(0, 20);
                mas[i].y = 10;
                mas[i].x = cX += 30;
            }
            return mas;
        }

        private void ClearGr()
        {
            g.Clear(color);
        }

        private void DrawState(Element[] arr)
        {
            Font font = new Font("Microsoft Sans Serif", 9, FontStyle.Bold);

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != null)
                {
                    g.DrawEllipse(Pens.Black, arr[i].x, arr[i].y, 23, 23);
                    g.DrawString(arr[i].val.ToString(), font, Brushes.Black, arr[i].x + 4, arr[i].y + 3);
                }
            }
        }
        
        private void DrawCompare(Element x1, Element x2)
        {
            Font font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);
            g.DrawEllipse(Pens.Aqua, x1.x, x1.y, 23, 23);
            g.FillEllipse(Brushes.Red, x1.x, x1.y, 23, 23);
            g.DrawString(x1.val.ToString(), font, Brushes.Black, x1.x + 4, x1.y + 3);

            g.DrawEllipse(Pens.Aqua, x2.x, x2.y, 23, 23);
            g.FillEllipse(Brushes.Red, x2.x, x2.y, 23, 23);
            g.DrawString(x2.val.ToString(), font, Brushes.Black, x2.x + 4, x2.y + 3);
        }

    }

    class Element
    {
        public int x,
                   y,
                   val;
    }
}
