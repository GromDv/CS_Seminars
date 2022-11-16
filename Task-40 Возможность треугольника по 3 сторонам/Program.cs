// Напишите программу, которая принимает на вход три // числа и проверяет, может ли существовать треугольник с сторонами // такой длины. // Теорема о неравенстве треугольника: каждая сторона треугольника // меньше суммы двух других сторон. 


Console.WriteLine("Введите длину 1: ");
int len1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите длину 2: ");
int len2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите длину 3: ");
int len3 = Convert.ToInt32(Console.ReadLine());
bool TreangleCheck(int a, int b, int c)
{
    return a < b + c && b < a + c && c < a + b;
}
bool res = TreangleCheck(len1, len2, len3);
Console.WriteLine(res == true ? "Треугольник возможен" : "Треугольник не возможен");
