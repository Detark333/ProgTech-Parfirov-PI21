using NLog;
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
        FormPlainConfig form;
        MultiLevelHangar hangar;
        private const int countLevel = 5;
        private Logger logger;
        public FormHangar()
        {
            InitializeComponent();
            logger = LogManager.GetCurrentClassLogger();
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
                    try
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
                        logger.Info("Изъят самолет " + plain.ToString() + " с места " + maskedTextBoxPlace.Text);
                        Draw();
                    }
                    catch (HangarNotFoundException ex)
                    {
                        MessageBox.Show(ex.Message, "Не найдено", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Bitmap bmp = new Bitmap(pictureBoxTakePlain.Width, pictureBoxTakePlain.Height);
                        pictureBoxTakePlain.Image = bmp;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Неизвестная ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void listBoxLevels_SelectedIndexChanged(object sender, EventArgs e)
        {
            Draw();
        }

        private void ButtonOpenForm_Click(object sender, EventArgs e)
        {
            form = new FormPlainConfig();
            form.AddEvent(AddPlain);
            form.Show();
        }
        private void AddPlain(ITransport plain)
        {
            if (plain != null && listBoxLevels.SelectedIndex > -1)
            {
                try
                {
                    int place = hangar[listBoxLevels.SelectedIndex] + plain;
                    logger.Info("Добавлен самолет " + plain.ToString() + " на место " + place);                    Draw();
                }
                catch (HangarOverflowException ex)
                {
                    MessageBox.Show(ex.Message, "Переполнение", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Неизвестная ошибка",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try {
                    hangar.SaveData(saveFileDialog.FileName);
                    MessageBox.Show("Сохранение прошло успешно", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    logger.Info("Сохранено в файл " + saveFileDialog.FileName);
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Не сохранилось", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LoadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    hangar.LoadData(openFileDialog.FileName);
                    MessageBox.Show("Загрузили", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    logger.Info("Загружено из файла " + openFileDialog.FileName);
                }
                catch (HangarOccupiedPlaceException ex)
                {
                    MessageBox.Show(ex.Message, "Занятое место", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Неизвестная ошибка при сохранении", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Draw();
            }
        }
    }
}
