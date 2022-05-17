using SnakeGame;

Console.SetWindowSize(80, 25);

Wall wall = new Wall(80, 25, '+');

wall.Draw();


Point point = new Point(4, 5, '*');
Snake snake = new Snake(point, 4, Direction.RIGHT);
snake.Draw();

FoodCreated food = new FoodCreated(80, 25, '$');
Point createdFood = food.CreateFood(); 
createdFood.Draw();

while(true)
{
    if(wall.IsHit(snake) || snake.IsTail())
    {
        break;
    }
    if(snake.EatFood(createdFood))
    {
        createdFood = food.CreateFood();
        createdFood.Draw();
    }
    if(Console.KeyAvailable)
    {
        ConsoleKeyInfo key = Console.ReadKey();
        snake.Handle(key.Key);
    }
    snake.Move();
    Thread.Sleep(100);
}
WriteGameOver();

static void WriteGameOver()
{
    int xoffset = 25, yoffset = 8;
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.SetCursorPosition(xoffset, yoffset++);
    WriteText("=================", xoffset+1, yoffset++);
    WriteText("    Игра окончена", xoffset++, yoffset++);
}

static void WriteText(string text, int xoffset, int yoffset)
{
    Console.SetCursorPosition(xoffset, yoffset);
    Console.WriteLine(text);
}