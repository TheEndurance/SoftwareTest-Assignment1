using System;

namespace RJAssignment1
{
    public class Rectangle
    {
        private int _length;
        private int _width;

        public Rectangle()
        {
            _length = 1;
            _width = 1;
        }

        public Rectangle(int length,int width)
        {
            _length = length;
            _width = width;
        }
       
        public int GetLength()
        {
            return _length;
        }

        public int SetLength(int length)
        {
            _length = length;
            return 1;
        }

        public int GetWidth()
        {
            return _width;
        }

        public int SetWidth(int width)
        {
            _width = width;
            return 1;
        }

        public int GetPerimeter()
        {
            return (_width * 2) + (_length * 2);
        }

        public int GetArea()
        {
            return _width * _length;
        }

    }
}
