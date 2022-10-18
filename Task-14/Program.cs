// Напишите программу, которая принимает на
// вход число и проверяет, кратно ли оно
// одновременно 7 и 23.

bool CheckDivsn(int par, int div1, int div2)
{
    bool res = default;

    if (par % div1 == 0 && par % div2 == 0)
        res = true;
    else
        res = false;

    return res;
}

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num % 7 == 0 && num % 23 == 0) Console.WriteLine($"1. Число {num} кратно числам 7 и 23");
else Console.WriteLine($"1. Число {num} НЕ кратно числам 7 и 23 одновременно");

if (CheckDivsn(num, 7, 23)) Console.WriteLine($"2. Число {num} кратно числам 7 и 23");
else Console.WriteLine($"2. Число {num} НЕ кратно числам 7 и 23 одновременно");