using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsPlains
{
    public class Plain : Vehicle
    {
        protected const int plainWidth = 100;
        protected const int plainHeight = 60;
        public Plain(int maxSpeed, float weight, Color mainColor)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
        }
        public Plain(string info)
        {
            string[] strs = info.Split(';');
            if (strs.Length == 3)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                Weight = Convert.ToInt32(strs[1]);
                MainColor = Color.FromName(strs[2]);
            }
        }
        public override void MoveTransport(Direction direction)
        {
            float step = MaxSpeed * 100 / Weight;
            switch (direction)
            {
                case Direction.Right:
                    if (_startPosX + step < _pictureWidth - plainWidth - 190)
                    {

                        _startPosX += step;
                    }
                    break;
                case Direction.Left:
                    if (_startPosX - step > -10)
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
        public override void DrawPlain(Graphics g)
        {
            Pen pen = new Pen(Color.Black);
            Brush penFill = new SolidBrush(MainColor);
            Brush penBlack = new SolidBrush(Color.Black);
            g.FillRectangle(penFill, _startPosX + 200, _startPosY - 15 + 10, 40, 140);
            g.DrawRectangle(pen, _startPosX, _startPosY + 35, 232 + 60, 55);
            g.FillRectangle(penFill, _startPosX, _startPosY + 35, 232 + 60, 55);
        }

        public override string ToString()
        {
            return MaxSpeed + ";" + Weight + ";" + MainColor.Name;
        }
    }
}
