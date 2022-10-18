// Напишите программу, которая принимает на
// вход число и проверяет, кратно ли оно
// одновременно 7 и 23.

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num % 7 == 0 && num % 23 == 0) Console.WriteLine($"Число {num} кратно числам 7 и 23");
else Console.WriteLine($"Число {num} НЕ кратно числам 7 и 23 одновременно");