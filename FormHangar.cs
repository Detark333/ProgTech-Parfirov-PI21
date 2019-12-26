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
        MultiLevelHangar hangar;
        private const int countLevel = 5;
        public FormHangar()
        {
            InitializeComponent();
            hangar = new MultiLevelHangar(countLevel, pictureBoxHangar.Width, pictureBoxHangar.Height);
            for (int i = 0; i < countLevel; i++)
            {
                listBoxLevels.Items.Add("Уровень " + (i + 1));
            }
            listBoxLevels.SelectedIndex = 0;
            Draw();
        }

        private void Draw()
        {
            if (listBoxLevels.SelectedIndex > -1)
            {
                Bitmap bmp = new Bitmap(pictureBoxHangar.Width, pictureBoxHangar.Height);
                Graphics gr = Graphics.FromImage(bmp);
                hangar[listBoxLevels.SelectedIndex].Draw(gr);
                pictureBoxHangar.Image = bmp;
            }
        }

        private void ButtonParkThePlain_Click(object sender, EventArgs e)
        {
            if (listBoxLevels.SelectedIndex > -1)
            {
                ColorDialog dialog = new ColorDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    var plain = new Plain(100, 1000, dialog.Color);
                    int place = hangar[listBoxLevels.SelectedIndex] + plain;
                    if (place == -1)
                    {
                        MessageBox.Show("Нет свободных мест", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    Draw();
                }
            }
        }

        private void ButtonParkTheBomber_Click(object sender, EventArgs e)
        {
            if (listBoxLevels.SelectedIndex > -1)
            {
                ColorDialog dialog = new ColorDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    ColorDialog dialogDop = new ColorDialog();
                    if (dialogDop.ShowDialog() == DialogResult.OK)
                    {
                        var bomber = new Bomber(1, 100, 1, dialog.Color, dialogDop.Color, true, true, true, 1000);
                        int place = hangar[listBoxLevels.SelectedIndex] + bomber;
                        if (place == -1)
                        {
                            MessageBox.Show("Нет свободных мест", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        Draw();
                    }
                }            }
        }

        private void ButtonTake_Click(object sender, EventArgs e)
        {
            if (listBoxLevels.SelectedIndex > -1)
            {
                if (maskedTextBoxPlace.Text != "")
                {
                    var plain = hangar[listBoxLevels.SelectedIndex] - Convert.ToInt32(maskedTextBoxPlace.Text);
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
        private void listBoxLevels_SelectedIndexChanged(object sender, EventArgs e)
        {
            Draw();
        }
    }
}
