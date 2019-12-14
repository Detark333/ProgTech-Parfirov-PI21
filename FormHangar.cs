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
    public partial class FormHangar : Form
    {
        Hangar<ITransport> hangar;
        public FormHangar()
        {
            InitializeComponent();
            hangar = new Hangar<ITransport>(20, pictureBoxHangar.Width, pictureBoxHangar.Height);
            Draw();
        }

        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxHangar.Width, pictureBoxHangar.Height);
            Graphics gr = Graphics.FromImage(bmp);
            hangar.Draw(gr);
            pictureBoxHangar.Image = bmp;
        }

        private void ButtonParkThePlain_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var plain = new Plain(100, 1000, dialog.Color);
                int place = hangar + plain;
                Draw();
            }
        }

        private void ButtonParkTheBomber_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ColorDialog dialogDop = new ColorDialog();
                if (dialogDop.ShowDialog() == DialogResult.OK)
                {
                    var bomber = new Bomber(1, 100, 1, dialog.Color, dialogDop.Color, true, true, true, 1000);
                    int place = hangar + bomber;
                    Draw();
                }
            }
        }

        private void ButtonTake_Click(object sender, EventArgs e)
        {
            if (maskedTextBoxPlace.Text != "")
            {
                var plain = hangar - Convert.ToInt32(maskedTextBoxPlace.Text);
                if (plain != null)
                {
                    Bitmap bmp = new Bitmap(pictureBoxTakePlain.Width, pictureBoxTakePlain.Height);
                    Graphics gr = Graphics.FromImage(bmp);
                    plain.SetPosition(5, 5, pictureBoxTakePlain.Width, pictureBoxTakePlain.Height);
                    plain.DrawPlain(gr);
                    pictureBoxTakePlain.Image = bmp;
                }
                else
                {
                    Bitmap bmp = new Bitmap(pictureBoxTakePlain.Width, pictureBoxTakePlain.Height);
                    pictureBoxTakePlain.Image = bmp;
                }
                Draw();
            }
        }
    }
}