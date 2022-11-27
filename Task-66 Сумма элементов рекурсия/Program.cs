// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// Метод рекурсивно считает сумму натуральных чисел от par1 до par2
int SummNaturalsMtoN(int par1, int par2)
{
    if (par1 > par2) return 0;
    return SummNaturalsMtoN(par1, par2 - 1) + par2;
}

Console.Write("Введите число M: ");
int numM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

Console.Write("Введите число N: ");
int numN = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

if (numM >= numN)
{
    Console.WriteLine($"Сумма натуральных чисел от {numN} до {numM} равна {SummNaturalsMtoN(numN, numM)}.");
}
else
{
    Console.WriteLine($"Сумма натуральных чисел от {numM} до {numN} равна {SummNaturalsMtoN(numM, numN)}.");
}
