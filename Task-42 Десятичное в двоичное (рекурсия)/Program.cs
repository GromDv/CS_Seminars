// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное. 45 -> 101101 3 -> 11 2 -> 10 


Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int ConvertToBin(int num)
{
    if (num != 0)
        return num % 2 + 10 * ConvertToBin(num / 2);
    else
        return 0;
}

Console.WriteLine($"В двоичном будет: 0b{ConvertToBin(number)}");
/*
int RevertNumber(int par)
{
    int result = 0;
    while (par > 9)
    {
        result += par % 10;
        result *= 10;
        par /= 10;
    }
    result += par % 10;
    return result;
}
int ConvertToBin(int num)
{
    int result = 0;
    while (num > 0)
    {
        result += num % 2;
        result *= 10;
        num /= 2;
    }
    return result;
}
*/

