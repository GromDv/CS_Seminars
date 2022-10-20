// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 5 ->
// 1 | 1
// 2 | 8
// 3 | 27
// 4 | 64
// 5 | 125

// Метод принимает параметр mnum и выводит таблицу кубов чисел от 1 до mnum
void ThirdDegreeTablPrint(int param)
{
    int count = 1;
    while (param >= count)
    {
        Console.WriteLine($"{count,4} -> {Math.Pow(count, 3), 4}");
        count++;
    }
}

Console.Write("Введите натуральное число N: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num > 0)
{
    ThirdDegreeTablPrint(num);
}
else
{
    Console.WriteLine("Введите натуральное число!");
}
