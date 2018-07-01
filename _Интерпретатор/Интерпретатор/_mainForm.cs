using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyLibrary;

namespace Интерпретатор
{
    public partial class _mainForm : Form
    {
        private Parser _parser = new Parser();

        public _mainForm()
        {
            InitializeComponent();
        }
        public string RemoveSpaces(string inputString)
        {
            inputString = inputString.Replace("  ", string.Empty);
            inputString = inputString.Trim().Replace(" ", string.Empty);
            return inputString;
        }
        
        private void parseButton_Click(object sender, EventArgs e)
        {
            
            string str = RemoveSpaces(textBox1.Text);
            try
            {
                _parser.Parse(str);
                textBox2.Text = _parser.Compute().ToString();
            }
            catch (Parser.nErrorException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Parser parser = new Parser();
            string str = RemoveSpaces(textBox1.Text);
                parser.Parse(str);
                textBox2.Text = parser.Compute().ToString();
        }
    }
}
