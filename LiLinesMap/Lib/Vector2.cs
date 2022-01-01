using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace LiLinesMap.Lib
{
    public struct Vector2
    {
        public int X
        {
            get; set;
        }
        public int Y
        {
            get; set;
        }
        public Vector2(int x, int y)
        {
            X = x;
            Y = y;           
        }
        public Point ToPoint()
        {
            return new Point(X, Y);
        }
        public override string ToString()
        {
            return $"{X}:{Y}";
        }
    }
}
