double OurLength(int mx1, int my1, int mx2, int my2)
{
    return Math.Sqrt((mx2 - mx1) * (mx2 - mx1) + (my2 - my1) * (my2 - my1));
}

Console.WriteLine("Введите координаты точки 1:");
Console.Write("X: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки 2:");
Console.Write("X: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int y2 = Convert.ToInt32(Console.ReadLine());

double d = OurLength(x1, y1, x2, y2);
double res = Math.Round(d, 2, MidpointRounding.ToZero);

Console.WriteLine($"Расстояние между точками равно {res}");