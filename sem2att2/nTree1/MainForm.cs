using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nTree1
{
    public partial class MainForm : Form
    {
        nTree tree = new nTree();
        Graphics g;
        
        public MainForm()
        {
            InitializeComponent();
        }

        private void buildTreeBtn_Click(object sender, EventArgs e)
        {
            try
            {
                g = pictureBox.CreateGraphics();
                g.Clear(MainForm.DefaultBackColor);
                int heigth = pictureBox.Height,
                    width = pictureBox.Width,
                    depth = int.Parse(deepInTb.Text);

                if (!radioBtn.Checked)
                {
                    if (depth % 2 != 1)
                        MessageBox.Show("Выберите способ получения результата", "Error");

                    tree.BuildRandomTree(depth);

                    g = pictureBox.CreateGraphics();
                    g = tree.DrawTree(g, 0, width, width / 2, 0, 10);
                }
                else
                {
                    tree.BuildTree(int.Parse(deepInTb.Text));
                    g = tree.DrawTree(g, 0, width, width / 2, 0, 10);

                    if (tree.IsSameNodes())
                        MessageBox.Show("есть");
                    else
                        MessageBox.Show("нет");

                    g = tree.DrawTree(g, 0, width, width / 2, 0, 10);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void getWayBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (radioButtonFile.Checked == false && radioButtonMsg.Checked == false)
                    MessageBox.Show("Выберите способ получения результата", "Error");

                string str = ListToStr(tree.GetZeroWay());

                if (radioButtonFile.Checked)
                    FileLog.WriteFile(str);
                if (radioButtonMsg.Checked)
                    MessageBox.Show("Нулевые пути:" + Environment.NewLine + str);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());
            }
        }

        private string ListToStr(List<List<int>> ways)
        {
            string result = "";

            for (int i = 0; i < ways.Count; i++)
            {
                for (int j = 0; j < ways[i].Count; j++)
                    result += ways[i][j].ToString() + ' ';
                result += Environment.NewLine;
            }
            return result;
        }
    }
}
