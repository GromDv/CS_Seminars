// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// метод возвращает массив с координатами точки пересечения прямых
double[] CalcCoords(double k1, double k2, double b1, double b2)
{
    double[] res = new double[2];
    res[0] = Math.Round((b2 - b1) / (k1 - k2), 2);
    res[1] = Math.Round(k1 * res[0] + b1, 2);
    return res;
}

Console.Write("Введите К1: ");
double ink1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите В1: ");
double inb1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите К2: ");
double ink2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите В2: ");
double inb2 = Convert.ToInt32(Console.ReadLine());

if (ink1 != ink2)
{
    double[] xyPoint = CalcCoords(ink1, ink2, inb1, inb2);

    Console.WriteLine("Координаты точки пересечения:");
    Console.WriteLine("x = {0}\ny = {1}", xyPoint[0], xyPoint[1]);
}
else
    Console.WriteLine("Прямые параллельны!");