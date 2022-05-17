using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    internal class HorizontalLine:Figure
    {
        public HorizontalLine(int xleft, int xright, int y, char sym)
        {
            points = new List<Point>();
            for(int i = xleft; i <= xright; i++)
            {
                Point p = new Point(i, y, sym);
                points.Add(p);
            }
        }
    }
}
