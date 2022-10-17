// Напишите программу, которая выводит случайное число от 10 до 99 и показывает наибольшую цифру в нем

int MaxDigit(int par)
{
    int dig1 = par / 10;
    int dig2 = par % 10;

    if (dig1 > dig2) return dig1;
    else return dig2;
}

int num = new Random().Next(10, 100);
Console.WriteLine($"число: {num}");

int dig1 = num / 10;
int dig2 = num % 10;

if (dig1 > dig2) Console.WriteLine($"1. Наибольшая цифра = {dig1}");
else Console.WriteLine($"1. Наибольшая цифра числа {num} = {dig2}");

Console.WriteLine($"2. Наибольшая цифра числа {num} = {Math.Max(dig1, dig2)}");

int max = dig1 > dig2 ? dig1 : dig2;
Console.WriteLine($"3. Наибольшая цифра числа {num} = {max}");

Console.WriteLine($"4. Наибольшая цифра числа {num} = {MaxDigit(num)}");