using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    internal class Point
    {
        public int x, y;
        public char sym;

        public Point() { }

        public Point(int x, int y, char sym)
        {
            this.x = x;
            this.y = y;
            this.sym = sym;
        }

        public Point(Point point)
        {
            this.x = point.x;
            this.y = point.y;
            this.sym = point.sym;
        }

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }

        public void Clear()
        {
            sym = ' ';
            Draw();
        }


        public void Move(int offset, Direction direction)
        {
            if(direction==Direction.RIGHT)
            {
                x += offset;
            }
            else if(direction==Direction.LEFT)
                x-=offset;
            else if(direction==Direction.UP)
                y-=offset;
            else if(direction == Direction.DOWN)
                y+=offset;
        }

        public bool IsHit(Point point)
        {
           return this.x == point.x && this.y == point.y;
        }
    }
}
