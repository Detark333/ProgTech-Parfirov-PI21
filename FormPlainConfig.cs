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
    public partial class FormPlainConfig : Form
    {
        private event plainDelegate eventAddPlain;
        ITransport plain = null;
        public FormPlainConfig()
        {
            InitializeComponent();
        }
        public void AddEvent(plainDelegate ev)
        {
            if (eventAddPlain == null)
            {
                eventAddPlain = new plainDelegate(ev);
            }
            else
            {
                eventAddPlain += ev;
            }
        }
        private void DrawPlainB()
        {
            if (plain != null)
            {
                Bitmap bmp = new Bitmap(pictureBoxThePlain.Width, pictureBoxThePlain.Height);
                Graphics gr = Graphics.FromImage(bmp);
                plain.SetPosition(5, 5, pictureBoxThePlain.Width, pictureBoxThePlain.Height);
                plain.DrawPlain(gr);
                pictureBoxThePlain.Image = bmp;
            }
        }
        private void labelPlain_MouseDown(object sender, MouseEventArgs e)
        {
            labelPlain.DoDragDrop(labelPlain.Text, DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void labelBomber_MouseDown(object sender, MouseEventArgs e)
        {
            labelBomber.DoDragDrop(labelBomber.Text, DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void panelPlain_DragDrop(object sender, DragEventArgs e)
        {
            switch (e.Data.GetData(DataFormats.Text).ToString())
            {
                case "Plain":
                    plain = new Plain(100, 500, Color.White);
                    break;
                case "Bomber":
                    plain = new Bomber(1, 100, 1, Color.White, Color.Black, true, true, true, 1000);
                    break;
            }
            DrawPlainB();
        }

        private void panelPlain_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void labelColor_DragDrop(object sender, DragEventArgs e)
        {
            if (plain != null)
            {
                plain.SetMainColor((Color)e.Data.GetData(typeof(Color)));
                DrawPlainB();
            }
        }

        private void labelColor_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Color)))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void labelDopColor_DragDrop(object sender, DragEventArgs e)
        {
            if (plain != null)
            {
                if (plain is Bomber)
                {
                    (plain as Bomber).SetDopColor((Color)e.Data.GetData(typeof(Color)));
                    DrawPlainB();
                }
            }
        }
        private void PanelColors_MouseDown(object sender, MouseEventArgs e)
        {
            (sender as Control).DoDragDrop((sender as Control).BackColor, DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void ButtonAddThePlain_Click(object sender, EventArgs e)
        {
            eventAddPlain?.Invoke(plain);
            Close();
        }
    }
}
