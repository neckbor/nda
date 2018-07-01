using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nTree1
{
    class Node
    {
        public int value;
        public Node right;
        public Node left;
        public bool check;
        public Brush brush;
    }
    class nTree
    {
        private Node _root;
        private Random rnd = new Random();

        public void BuildTree(int depth)    //для второй задачи
        {
            _root = new Node();
            _root.value = rnd.Next(50);

            _root.left = BuildRandomSubTree(depth, 0.8);
            _root.right = BuildRandomSubTree(depth, 0.8);
        }

        private Node BuildRandomSubTree(int depth, double pssblt)
        {
            if (depth <= 0)
                return null;

            if (rnd.NextDouble() > pssblt)
                return null;

            Node p = new Node();
            p.value = rnd.Next(50);

            p.check = false;

            p.right = BuildRandomSubTree(depth - 1, pssblt);
            p.left = BuildRandomSubTree(depth - 1, pssblt);

            return p;
        }

        public bool IsSameNodes()
        {
            return IsSame(_root);
        }


        private int CountSame(Node p, int val)
        {
            if (p == null)
                return 0;

            int left = CountSame(p.left, val),
                right = CountSame(p.right, val);

            if (p.value == val)
            {
                return left + right + 1;
            }
            else
                return left + right;
        }

        private bool IsSame(Node p)
        {
            if (p == null)
                return false;

            int val = p.value;

            int count = CountSame(_root, val);

            if (count > 1)
            {
                p.brush = new SolidBrush(Color.FromArgb(rnd.Next(150) + 50, rnd.Next(150) + 50, rnd.Next(150) + 50));

                return true;
            }

            return IsSame(p.left) || IsSame(p.right);
        }

        public void BuildRandomTree(int depth)
        {
            _root = BuildSubTree(depth);
            _root.value = 0;
        }

        private Node BuildSubTree(int depth)
        {
            if (depth <= 0)
                return null;

            Node p = new Node();

            p.check = false;
            p.left = BuildSubTree(depth - 1);
            p.right = BuildSubTree(depth - 1);

            if (p.left != null)
                p.left.value = -1;
            if (p.right != null)
                p.right.value = 1;

            return p;
        }

        public Graphics DrawTree(Graphics g, int bordL, int bordR, int x0, int y0, int dy)
        {
            Font font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
            DrawSubTree(g, font, _root, x0, y0, dy, bordL, bordR);
            return g;
        }
        private void DrawSubTree(Graphics g, Font font, Node p, int x, int y, int dy, int bordL, int bordR)
        {
            StringFormat format = new StringFormat();

            if (p == null || p.check == true)
                return;
            if (p.right != null)
                g.DrawLine(Pens.Black, x, y, (bordR + x) / 2, y + dy); //веточка для правого узла
            if (p.left != null)
                g.DrawLine(Pens.Black, x, y, (bordL + x) / 2, y + dy);  //веточка для левого узла

            g.DrawEllipse(Pens.Black, (bordL + bordR) / 2 -  13, y, 25, 25);  // сам узел
            if (p.brush == null)
                g.FillEllipse(Brushes.Black, (bordL + bordR) / 2 - 13, y, 25, 25);
            else
                g.FillEllipse(p.brush, (bordL + bordR) / 2 - 13, y, 25, 25);
            g.DrawString(p.value.ToString(), font, Brushes.WhiteSmoke, x - 9, y + 6); // значение узла
            p.check = true;
            DrawSubTree(g, font, p.right, (bordR + x) / 2, y + dy, dy + 5, bordR, x); //рисование правого поддерева
            DrawSubTree(g, font, p.left, (bordL + x) / 2, y + dy, dy + 5, x, bordL); //рисование левого поддерева
        }

        private void FindZeroWay(Node p, List<int> waylist, List<List<int>> allWays, int sum)
        {
            if (p == null)
                return;

            waylist.Add(p.value);
            sum += p.value;

            FindZeroWay(p.left, waylist, allWays, sum);
            FindZeroWay(p.right, waylist, allWays, sum);

            if (p.left == null && p.right == null && sum == 0)
            {
                List<int> buffer = new List<int>();
                for (int i = 0; i < waylist.Count; i++)
                    buffer.Add(waylist[i]);
                allWays.Add(buffer);
            }
            waylist.RemoveAt(waylist.Count - 1);
        }

        public List<List<int>> GetZeroWay()
        {
            List<int> OneWay = new List<int>();
            List<List<int>> Lway = new List<List<int>>();
            FindZeroWay(_root, OneWay, Lway, 0);
            return Lway;
        }
    }

}
