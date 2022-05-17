using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    internal class Wall:Figure
    {
        List<Figure> walls;

        public Wall(int x, int y, char sym)
        {
            walls = new List<Figure>();
            HorizontalLine horizontalLine1 = new HorizontalLine(0, x - 2, 0, sym);
            HorizontalLine horizontalLine2 = new HorizontalLine(0, x - 2, y - 1, sym);
            VerticalLine verticalLine1 = new VerticalLine(0, y-1, 0, sym);
            VerticalLine verticalLine2 = new VerticalLine(0, y - 1, x - 2, sym);

            walls.Add(horizontalLine1);
            walls.Add(horizontalLine2);
            walls.Add(verticalLine1);
            walls.Add(verticalLine2);
        }


        public bool IsHit(Figure figure)
        {
            foreach (var wall in walls)
            {
                if (wall.IsHit(figure))
                    return true;
            }
            return false;
        }

        public void Draw()
        {
            foreach (var wall in walls)
                wall.Draw();
        }
    }
}
