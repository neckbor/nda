using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _13._1._13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void runBtn_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = System.IO.Path.GetFullPath(Environment.CurrentDirectory + Inp_out.GetDataDirectiry());

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                StringModify text = new StringModify(openFileDialog.FileName);
                text.DeleteSpaces();
                text.WriteFile();
            }
        }
    }
}
