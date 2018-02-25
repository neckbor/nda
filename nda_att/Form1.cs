using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nda_att
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void runBtn_Click(object sender, EventArgs e)
        {
            SameElementsDelete mas = new SameElementsDelete(inputText.Text);

            mas.SameItemsDetect();

            resultText.Text = mas.PrintData();
        }
    }
}
