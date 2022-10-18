// Напишите программу, которая принимает на
// вход два числа и проверяет, является ли одно
// число квадратом другого.

Console.Write("Введите число 1: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число 2: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 * num1 == num2)
    Console.WriteLine($"Число {num2} является квадратом числа {num1}");
else
    Console.WriteLine($"Число {num2} НЕ является квадратом числа {num1}");