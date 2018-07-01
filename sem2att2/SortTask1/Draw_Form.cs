using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortTask1
{
    public partial class Draw_Form : Form
    {
        Color color = Draw_Form.DefaultBackColor;
        Graphics g;

        public Draw_Form()
        {
            InitializeComponent();
        }

        private void Draw_Form_Load(object sender, EventArgs e)
        {
            g = pictureBox.CreateGraphics();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {


                Draw drawSorts = new Draw(g, color);

                if (radioButton_Nature.Checked)
                    drawSorts.NatureMerge();
                else
                    if (radioButton_Simple.Checked)
                        drawSorts.SimpleMerge();
                    else
                        throw new Exception("Выберите сортировку");
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.ToString(), "Error");
            }
        }
    }
}
