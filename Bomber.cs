using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsPlains
{
    public class Bomber : Plain
    {
        public int NumberBombs { private set; get; }
        public int NumberGuns { private set; get; }
        public Color DopColor { private set; get; } 
        public bool Bombs { private set; get; }    
        public bool BackF { private set; get; }
        public bool Tail { private set; get; }
        public Bomber(int numberBombs,int maxSpeed, int numberGuns, Color mainColor, Color dopColor, bool bombs, bool backF, bool tail, float weight) : base(maxSpeed, weight, mainColor)        {
            NumberBombs = numberBombs;
            MaxSpeed = maxSpeed;
            NumberGuns = numberGuns;
            MainColor = mainColor;
            DopColor = dopColor;
            Bombs = bombs;
            BackF = backF;
            Tail = tail;
            Weight = weight;

        }
        public override void DrawPlain(Graphics g)
        {
            Pen pen = new Pen(Color.Black);
            Brush penFill = new SolidBrush(MainColor);
            Brush penBlack = new SolidBrush(DopColor);
            base.DrawPlain(g);
            if (Bombs)
            {
                DrawGuns(g);
            }
            if (BackF)
            {
                DrawBackF(g);
            }

        }
        public void DrawGuns(Graphics g)
        {
            Pen pen = new Pen(Color.Black);
            Brush penFill = new SolidBrush(MainColor);
            Brush penBlack = new SolidBrush(DopColor);
            g.DrawRectangle(pen, _startPosX + 240, _startPosY + 20, 24, 12);
            g.FillRectangle(penBlack, _startPosX + 240, _startPosY + 20, 24, 12);
            g.DrawEllipse(pen, _startPosX + 240, _startPosY + 100, 20, 20);
            g.FillEllipse(penBlack, _startPosX + 240, _startPosY + 100, 20, 20);
        }
        public void DrawBackF(Graphics g)
        {
            Pen pen = new Pen(Color.Black);
            Brush penFill = new SolidBrush(MainColor);
            Brush penBlack = new SolidBrush(DopColor);
            g.DrawRectangle(pen, _startPosX + 100, _startPosY - 15, 50, 160);
            g.FillRectangle(penBlack, _startPosX + 100, _startPosY - 15, 50, 160);
        }
        public void SetDopColor(Color color)
        {
            DopColor = color;
        }
    }
}
