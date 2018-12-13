using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Game;

namespace Lab6
{
    public partial class MainScreen : Form
    {
        Bitmap bitmap;
        Graphics g;
        public MainScreen()
        {
            InitializeComponent();
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {
            bitmap = new Bitmap(this.Width, this.Height);
            g = Graphics.FromImage(bitmap);

            g = Drawing.DrawBackGround(g);

            this.BackgroundImage = bitmap;
        }
    }
}
