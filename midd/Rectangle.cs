using System;
namespace midd
{
    public class Rectangle
    {
        private int length;
        private int width;
        public Rectangle()
        {
            length = 1;
            width = 1;
        }
        public Rectangle(int _length, int _width)
        {
            length = _length;
            width = _width; 
        }
        public int GetLength() {
            return length;
        }
        public int SetLength(int _length)
        {
            Console.WriteLine("Enter new length");
            length =_length;
            return 0;
        }
        public int GetWidth() {
            return width;
        }
        public int SetWidth(int _width)
        {
            Console.WriteLine("Enter new width");
            width =_width;
            return 0;
        }
        public int GetPerimeter() {
            return (width+length)*2;
        }
        public int GetArea() {
            return width*length;
        }
        
    }
}
