using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _8._13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DataGridViewUtils.InitGridForArr(mtxGrid, 30, false, true, true, true, true);
        }

        private void runBtn_Click(object sender, EventArgs e)
        {
            try
            {
                //double[,] mtx = new double[mtxGrid.RowCount, mtxGrid.ColumnCount];

                //for (int r = 0; r < mtx.GetLength(0); r++)
                //    for (int c = 0; c < mtx.GetLength(1); c++)
                //        mtx[r, c] = double.Parse(mtxGrid[r, c].ToString());

                Matrix obj = new Matrix(DataGridViewUtils.GridToArray2<double>(mtxGrid));

                if (obj.IsDataSquare())
                {
                    sumMainlbl.Text = obj.GetMainSum();
                    resultDownlbl.Text = obj.GetDownSum();
                }
                else
                    MessageBox.Show("Матрица не является квадратной");
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());
            }

        }
    }
}
