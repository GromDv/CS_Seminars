// Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли первое число
// кратным второму. Если число 1 не кратно числу 2, то
// программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.Write("Введите делитель: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите делимое: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int ost = num2 % num1;

if (ost == 0) Console.WriteLine($"Число {num2} кратно числу {num1}");
else Console.WriteLine($"Число {num2} не кратно числу {num1} , остаток = {ost}");


