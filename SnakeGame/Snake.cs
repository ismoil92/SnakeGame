using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    internal class Snake:Figure
    {
        Direction direction;
        public Snake(Point tail, int length, Direction _direction)
        {
            direction = _direction;
            points = new List<Point>();
            for(int i = 0; i < length; i++)
            {
                Point p = new Point(tail);
                p.Move(i, direction);
                points.Add(p);
            }
        }


        public void Move()
        {
            Point tail = points.First();
            points.Remove(tail);
            Point head = GetNextPoint();


            head.Draw();
            tail.Clear();
        }

        public Point GetNextPoint()
        {
            Point head = points.Last();
            Point nextPoint =new Point(head);
            nextPoint.Move(1, direction);
            points.Add(nextPoint);
            return nextPoint;
        }

        public void Handle(ConsoleKey key)
        {
            if (key == ConsoleKey.LeftArrow)
              direction =  Direction.LEFT;
            else if(key == ConsoleKey.RightArrow)
                direction = Direction.RIGHT;
            else if(key == ConsoleKey.UpArrow)
                direction = Direction.UP;
            else if(key == ConsoleKey.DownArrow)
                direction = Direction.DOWN;
        }

        public bool EatFood(Point food)
        {
            Point head = points.Last();
            if(head.IsHit(food))
            {
                food.sym = head.sym;
                points.Add(food);
                return true;
            }
            return false;
        }

        public bool IsTail()
        {
            Point tail = points.Last();
            for (int i = 0; i < points.Count-2; i++)
            {
                if (tail.IsHit(points[i]))
                    return true;
            }
            return false;

        }
    }
}
