// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Write("Введите К1: ");
double k1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите В1: ");
double b1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите К2: ");
double k2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите В2: ");
double b2 = Convert.ToInt32(Console.ReadLine());

if (k1 != k2)
{
    double x = Math.Round((b2 - b1) / (k1 - k2), 2);
    double y = Math.Round(k1 * x + b1, 2);

    Console.WriteLine("Координаты точки пересечения:");
    Console.WriteLine("x = {0}\ny = {1}", x, y);
}
else
    Console.WriteLine("Прямые параллельны!");