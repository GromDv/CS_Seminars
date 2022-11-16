//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

Console.Write("Введите число А: ");
int numA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите натуральное число B: ");
int numB = Convert.ToInt32(Console.ReadLine());

if(numB > 0)
{
    Console.WriteLine($"Число {numA} в степени {numB} рано {ToDegree(numA,numB)}");
}
else
{
    Console.WriteLine($"Число {numB} не является натуральным!");
}

// Метод возводит число par1 в степень par2
int ToDegree(int par1, int par2)
{
    int result = 1;
    
    for(int i = 0; i < par2; i++)
        result *= par1;

    return result;
}