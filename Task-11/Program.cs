// Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого
// числа.

int DelSecondDig(int par)
{
    int lastDig = par % 10; // Запоминаем младшую цифру
    int res = par / 10;     // Уббираем младший разряд и получаем двузначное
    res -= res % 10;        // Обнуляем младшую цифру двузначного числа
    res += lastDig;         // Восстанавливаем запомненную младшую цифру

    return res;
}

int num = new Random().Next(100, 1000);
Console.WriteLine($"Случайное число: {num}");

int newNum = DelSecondDig(num);

Console.WriteLine($"Новое число: {newNum}");