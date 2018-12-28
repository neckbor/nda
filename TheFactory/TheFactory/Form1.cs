using ProgramLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace TheFactory
{
    public partial class Form1 : Form
    {
        Bitmap _bitmap;
        Graphics _g;

        Factory _factory;

        public Form1()
        {
            InitializeComponent();

            _factory = new Factory();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _bitmap = new Bitmap(pictureBox.Width, pictureBox.Height);
            _g = Graphics.FromImage(_bitmap);

            Drawing.DrawingConstr(Properties.Resources.Конвейер1, Properties.Resources.Конвейер2, Properties.Resources.Грузовик_полный, Properties.Resources.Грузовик_пустой,
                Properties.Resources.Работник, Properties.Resources.Полная_куча, Properties.Resources.Половина_кучи, Properties.Resources.Чутка_кучи);
        }

        private void addConveyor_btn_Click(object sender, EventArgs e)
        {
            _factory.AddConveyor();
        }

        private void startFactory_btn_Click(object sender, EventArgs e)
        {
            _factory.Start();
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            _g.Clear(Color.White);
            Drawing.DrawState(_factory, _g);

            pictureBox.Image = _bitmap;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            _factory.Break();
        }
    }
}
