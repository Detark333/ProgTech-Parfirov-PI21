using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsPlains
{
    public class Hangar<T> : IEnumerator<T>, IEnumerable<T>, IComparable<Hangar<T>> where T : class, ITransport
    {
        private Dictionary<int, T> _places;

        private int _maxCount;

        private int PictureWidth { get; set; }
        
        private int PictureHeight { get; set; }

        private const int _placeSizeWidth = 210;
     
        private const int _placeSizeHeight = 80;

        private int _currentIndex;

        public Hangar(int sizes, int pictureWidth, int pictureHeight)
        {
            _maxCount = sizes;
            _places = new Dictionary<int, T>();
            PictureWidth = pictureWidth;
            PictureHeight = pictureHeight;
            _currentIndex = -1;
        }
        public int GetKey
        {
            get
            {
                return _places.Keys.ToList()[_currentIndex];
            }
        }
        public static int operator +(Hangar<T> p, T plain)
        {
            if (p._places.Count == p._maxCount)
            {
                throw new HangarOverflowException();
            }
            if (p._places.ContainsValue(plain))
            {
                throw new HangarAlreadyHaveException();
            }
            for (int i = 0; i < p._maxCount; i++)
            {
                if (p.CheckFreePlace(i))
                {
                    p._places[i] = plain;
                    p._places[i].SetPosition((i / 5 * _placeSizeWidth + 5) * 2, (i % 5 * _placeSizeHeight + 5) * 2, p.PictureWidth, p.PictureHeight);
                    return i;
                }
            }
            return -1;
        }
        

         public static T operator -(Hangar<T> p, int index)
         {
            if (!p.CheckFreePlace(index))
            {
                T plain = p._places[index];
                p._places.Remove(index);
                return plain;
            }
            throw new HangarNotFoundException(index);
        }

        private bool CheckFreePlace(int index)
            {
                return !_places.ContainsKey(index);
        }
        public void Draw(Graphics g)
        {
            DrawMarking(g);
            var keys = _places.Keys.ToList();
            for (int i = 0; i < keys.Count; i++)
            {
                _places[keys[i]].DrawPlain(g);
            }
        }

        private void DrawMarking(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 3);
            g.DrawRectangle(pen, 0, 0, (_maxCount / 5) * _placeSizeWidth, 1000);
            for (int i = 0; i < _maxCount / 5; i++)
            {
                if (i % 2 != 1)
                {
                    for (int j = 0; j < 12; ++j)
                    {
                        if (j % 2 != 1)
                        {
                            g.DrawLine(pen, i * _placeSizeWidth, j * _placeSizeHeight, i * _placeSizeWidth + 300, j * _placeSizeHeight);
                        }
                    }
                    g.DrawLine(pen, i * _placeSizeWidth, 0, i * _placeSizeWidth, 920);
                }
            }
        }

        public T this[int ind]
        {
            get
            {
                if (_places.ContainsKey(ind))
                {
                    return _places[ind];
                }
                throw new HangarNotFoundException(ind);
            }
            set
            {
                if (CheckFreePlace(ind))
                {
                    _places.Add(ind, value);
                    _places[ind].SetPosition(5 + ind / 5 * _placeSizeWidth + 5, ind % 5 * _placeSizeHeight + 15, PictureWidth, PictureHeight);
                }
                else
                {
                    throw new HangarOccupiedPlaceException(ind);
                }
            }
        }        public T Current
        {
            get
            {
                return _places[_places.Keys.ToList()[_currentIndex]];
            }
        }
        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }
        public void Dispose()
        {
            _places.Clear();
        }
        public bool MoveNext()
        {
            if (_currentIndex + 1 >= _places.Count)
            {
                Reset();
                return false;
            }
            _currentIndex++;
            return true;
        }
        public void Reset()
        {
            _currentIndex = -1;
        }
        public IEnumerator<T> GetEnumerator()
        {
            return this;
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        public int CompareTo(Hangar<T> other)
        {
            if (_places.Count > other._places.Count)
            {
                return -1;
            }
            else if (_places.Count < other._places.Count)

            {
                return 1;
            }
            else if (_places.Count > 0)
            {
                var thisKeys = _places.Keys.ToList();
                var otherKeys = other._places.Keys.ToList();
                for (int i = 0; i < _places.Count; ++i)
                {
                    if (_places[thisKeys[i]] is Plain && other._places[thisKeys[i]] is
                   Bomber)
                    {
                        return 1;
                    }
                    if (_places[thisKeys[i]] is Plain && other._places[thisKeys[i]]
                    is Bomber)
                    {
                        return -1;
                    }
                    if (_places[thisKeys[i]] is Plain && other._places[thisKeys[i]] is
                    Plain)
                    {
                        return (_places[thisKeys[i]] is
                      Plain).CompareTo(other._places[thisKeys[i]] is Plain);
                    }
                    if (_places[thisKeys[i]] is Bomber && other._places[thisKeys[i]]
                    is Bomber)
                    {
                        return (_places[thisKeys[i]] is
                       Bomber).CompareTo(other._places[thisKeys[i]] is Bomber);
                    }
                }
            }
            return 0;
        }
    }
}
