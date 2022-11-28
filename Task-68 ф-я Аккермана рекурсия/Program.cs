// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// Метод возвращает значение функции Аккермана
int AkkermanFunc(int m, int n)
{
    if (m < 0 || n < 0) return 0;
    if (m == 0)
    {
        return n + 1;
    }
    if(n == 0)
    {
        return AkkermanFunc(m - 1, 1);
    }
    return AkkermanFunc(m - 1, AkkermanFunc(m, n - 1));
}

Console.Write("Введите число M: ");
int numM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

Console.Write("Введите число N: ");
int numN = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

Console.WriteLine($"Значение ф.Аккермана = {AkkermanFunc(numM, numN)}");
