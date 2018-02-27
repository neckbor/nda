using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _9._13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DataGridViewUtils.InitGridForArr(mtxGrid, 30, false, true, true, true, true);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                checkBoxSnake.Checked = false;
                checkBoxZZ.Checked = false;

                Matrix obj = new Matrix(DataGridViewUtils.GridToArray2<double>(mtxGrid));

                checkBoxZZ.Checked = obj.IsSpiral();
                checkBoxSnake.Checked = obj.IsSnake();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());
            }
        }
    }
}
