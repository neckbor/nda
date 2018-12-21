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
        //Bitmap bitmap;
        //Graphics g;

        //public delegate void EventHandlerGraphics();
        //public event void 

        public event Action<Graphics> FieldHasChanged;

        Game _game;


        public MainScreen()
        {
            InitializeComponent();

            Bitmap bitmap = new Bitmap(this.Width, this.Height);

            Graphics g = Graphics.FromImage(bitmap);
            g = Drawing.DrawBackGround(g);

            this.BackgroundImage = bitmap;

            gameField.Parent = this;
            gameField.BackColor = Color.Transparent;

            _game = new Game(Properties.Resources.plane1);

            _game.FieldHasChanged += OnFieldHasChanged;
        }

        private void OnFieldHasChanged()
        {
            Action dlgt = Redraw2;

            if (this.InvokeRequired && this.IsHandleCreated)
            {
                //dlgt.Invoke();
                Invoke(dlgt);
            }
            else
                dlgt();
        }

        private void Redraw2()
        {
            Bitmap bitmap = new Bitmap(this.Width, this.Height);
            Graphics g = Graphics.FromImage(bitmap);

            g = _game.UpdateField(g);

            gameField.Image = bitmap;

            g.Dispose();
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {
            _game.Start();
        }

        private void MainScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            _game.FieldHasChanged -= OnFieldHasChanged;

            _game.StopThread();
        }
    }
}
