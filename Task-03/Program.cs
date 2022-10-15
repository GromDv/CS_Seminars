Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int count = 0, border = 0;

if (num >= 0)
{
    count = -num;
    border = num;
}
else
{
    count = num;
    border = -num;
}

while (count <= border)
{
    if (count == border)
    {
        Console.WriteLine($" {count}");
        count++;
    }
    else
    {
        Console.Write($" {count},");
        count++;
    }
}
