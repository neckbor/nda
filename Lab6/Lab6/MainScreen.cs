using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GameRes;

namespace Lab6
{
    public partial class MainScreen : Form
    {
        Bitmap bitmap;
        Graphics g;

        Game _game;
        public MainScreen()
        {
            InitializeComponent();

            bitmap = new Bitmap(this.Width, this.Height);

            g = Graphics.FromImage(bitmap);
            g = Drawing.DrawBackGround(g);

            this.BackgroundImage = bitmap;

            gameField.Parent = this;
            gameField.BackColor = Color.Transparent;

            _game = new Game(Properties.Resources.plane1);
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {
            timer.Start();
            _game.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            bitmap = new Bitmap(this.Width, this.Height);
            g = Graphics.FromImage(bitmap);

            g = _game.UpdateField(g);

            gameField.Image = bitmap;
        }

        private void MainScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            _game.StopThread();
        }
    }
}
