using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    internal class Figure
    {
        public List<Point> points;


        public bool IsHit(Figure figure)
        {
            foreach(Point p in points)
            {
                if(figure.IsHit(p))
                    return true;
            }
            return false;
        }

        bool IsHit(Point point)
        {
            foreach(var p in points)
            {
                if (p.IsHit(point))
                return true;
            }
            return false;
        }

        public void Draw()
        {
            foreach (var p in points)
                p.Draw();
        }
    }
}
