// программa, которая
// принимает на вход число (А) и выдаёт сумму чисел
// от 1 до А.

// 7 -> 28
// 4 -> 10
// 8 -> 36


int SumNumbers(int number)
{
    int sum = default;

    for (int i = 1; i <= number; i++)
    {
        sum = sum + i; // sum += 1;
    }
    return sum;
}


Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int sumNumber = SumNumbers(num);

Console.WriteLine($"Сумма чисел от 1 до {num} = {sumNumber}");
