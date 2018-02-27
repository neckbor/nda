using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10._13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void runBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int[] y = Multiplicity.Ybuild(Multiplicity.StrToArray<int>(inputX1.Text), Multiplicity.StrToArray<int>(inputX2.Text), Multiplicity.StrToArray<int>(inputX3.Text));

                outY.Text = Multiplicity.PrintData(y);
                nY1out.Text = Multiplicity.GetnY1(y);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());
            }
        }
    }
}
