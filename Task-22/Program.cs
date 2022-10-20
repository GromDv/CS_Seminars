void TablPrint(int mnum)
{
    int count = 1;
    while (mnum >= count)
    {
        Console.WriteLine($"{count} -> {count * count}");
        count++;
    }
}

Console.Write("Введите число N: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num > 0)
{
    TablPrint(num);
}
else
{
    Console.WriteLine("Введите натуральное число!");
}