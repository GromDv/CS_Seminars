<<<<<<< HEAD
﻿//Console.SetBufferSize(80, 25);

Console.Clear();

Walls walls = new Walls(80, 25);
walls.Draw();

// Отрисовка точек			
Point p = new Point(4, 5, '*');
Snake snake = new Snake(p, 4, Direction.RIGHT);
snake.Draw();

FoodCreator foodCreator = new FoodCreator(80, 25, '$');
Point food = foodCreator.CreateFood();
food.Draw();

while (true)
{
    if (walls.IsHit(snake) || snake.IsHitTail())
    {
        break;
    }
    if (snake.Eat(food))
    {
        food = foodCreator.CreateFood();
        food.Draw();
    }
    else
    {
        snake.Move();
    }

    Thread.Sleep(100);
    if (Console.KeyAvailable)
    {
        ConsoleKeyInfo key = Console.ReadKey();
        snake.HandleKey(key.Key);
    }
}
WriteGameOver();
Console.ReadLine();

static void WriteGameOver()
{
    int xOffset = 25;
    int yOffset = 8;
    Console.ForegroundColor = ConsoleColor.Red;
    Console.SetCursorPosition(xOffset, yOffset++);
    WriteText("============================", xOffset, yOffset++);
    yOffset++;
    WriteText("И Г Р А    О К О Н Ч Е Н А", xOffset + 1, yOffset++);
    yOffset++;
    WriteText("============================", xOffset, yOffset++);
}

static void WriteText(String text, int xOffset, int yOffset)
{
    Console.SetCursorPosition(xOffset, yOffset);
    Console.WriteLine(text);
}
=======
﻿int x1 = 1;
int y1 = 3;
char sym1 = '*';

Draw(x1, y1, sym1);

int x2 = 4;
int y2 = 5;
char sym2 = '#';

Draw(x2, y2, sym2);


Console.WriteLine();

static void Draw(int x, int y, char sym)
{
    Console.SetCursorPosition(x, y);
    Console.Write(sym);
}
