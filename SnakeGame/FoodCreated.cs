using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    internal class FoodCreated
    {
        int x, y;
        char sym;

        Random random = new Random();

        public FoodCreated(int x, int y, char sym)
        {
            this.x = x;
            this.y = y;
            this.sym = sym;
        }

        public Point CreateFood()
        {
            int _x = random.Next(2, x - 2);
            int _y = random.Next(2, y - 2);
            return new Point(_x, _y, sym);
        }
    }
}
