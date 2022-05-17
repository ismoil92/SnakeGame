using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    internal class VerticalLine:Figure
    {
        public VerticalLine(int yUp, int yDown, int x, char sym)
        {
            points = new List<Point>();
            for(int i=yUp; i<=yDown; i++)
            {
                Point point = new Point(x, i, sym);
                points.Add(point);
            }
        }
    }
}
