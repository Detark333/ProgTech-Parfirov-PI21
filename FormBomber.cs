using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsPlains
{
    public partial class FormBomber : Form
    {
        private Bomber plain;
        public FormBomber()
        {
            InitializeComponent();
        }
        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxPlainGo.Width, pictureBoxPlainGo.Height);
            Graphics gr = Graphics.FromImage(bmp);
            plain.DrawPlain(gr);
            pictureBoxPlainGo.Image = bmp;
        }
        private void ButtonCreateBomber_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            plain = new Bomber(rnd.Next(100, 300), rnd.Next(100, 300), rnd.Next(1, 3), Color.Black,
            Color.Red, true, true, true, rnd.Next(1000, 2000));
            plain.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBoxPlainGo.Width,
            pictureBoxPlainGo.Height);
            Draw();
        }
        private void buttonMove_Click(object sender, EventArgs e)
        {
            string name = (sender as Button).Name;
            switch (name)
            {
                case "buttonUp":
                    plain.MoveTransport(Direction.Up);
                    break;
                case "buttonDown":
                    plain.MoveTransport(Direction.Down);
                    break;
                case "buttonLeft":
                    plain.MoveTransport(Direction.Left);
                    break;
                case "buttonRight":
                    plain.MoveTransport(Direction.Right);
                    break;
            }
            Draw();
        }       
    }
}
