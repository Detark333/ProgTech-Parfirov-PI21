using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsPlains
{
    public class Bomber 
    {
        protected const int plainWidth = 100;
        protected const int plainHeight = 60;
        protected float _startPosX;
        protected float _startPosY;
        protected int _pictureWidth;
        protected int _pictureHeight;
        public int MaxSpeed { protected set; get; }
        public float Weight { protected set; get; }
        public Color MainColor { protected set; get; }
        public int NumberBombs { private set; get; }
        public int NumberGuns { private set; get; }
        public Color DopColor { private set; get; }
        public bool Bombs { private set; get; }
        public bool BackF { private set; get; }
        public bool Tail { private set; get; }
        public void MoveTransport(Direction direction)
        {
            float step = MaxSpeed * 100 / Weight;
            switch (direction)
            {
                case Direction.Right:
                    if (_startPosX + step < _pictureWidth - plainWidth - 180)
                    {
                        _startPosX += step;
                    }
                    break;
                case Direction.Left:
                    if (_startPosX - step > -30)
                    {
                        _startPosX -= step;
                    }
                    break;
                case Direction.Up:
                    if (_startPosY - step > 10)
                    {
                        _startPosY -= step;
                    }
                    break;
                case Direction.Down:
                    if (_startPosY + step < _pictureHeight - plainHeight - 80)
                    {
                        _startPosY += step;
                    }
                    break;
            }
        }       
        public void SetPosition(int x, int y, int width, int height)
        {
            _startPosX = x;
            _startPosY = y;
            _pictureWidth = width;
            _pictureHeight = height;
        }
        public Bomber(int numberBombs,int maxSpeed, int numberGuns, Color mainColor, Color dopColor, bool bombs, bool backF, bool tail, float weight) 
        {
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
        public void DrawPlain(Graphics g)
        {
            Pen pen = new Pen(Color.Black);
            Brush penFill = new SolidBrush(MainColor);
            Brush penBlack = new SolidBrush(DopColor);  
            g.FillRectangle(penFill, _startPosX + 200, _startPosY - 15 + 10, 40, 140);
            g.DrawRectangle(pen, _startPosX, _startPosY + 35, 232 + 60, 55);
            g.FillRectangle(penFill, _startPosX, _startPosY + 35, 232 + 60, 55);
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
    }
}
