// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] arrParam)
{
    Console.Write("[");
    for (int i = 0; i < arrParam.Length; i++)
    {
        if (i < arrParam.Length - 1) Console.Write($"{arrParam[i]}, ");
        else Console.WriteLine($"{arrParam[i]}]");
    }
}
// Метод возвращает количество четных элементов во входном массиве
int GetCountEvens(int[] arrParam)
{
    int result = 0;
    for (int i = 0; i < arrParam.Length; i++)
        if (arrParam[i] % 2 == 0)
            result++;

    return result;
}

int[] arr = CreateArrayRndInt(4, 100, 999); // получаем массив размером 4 элемента в интервале [100,999]
PrintArray(arr);                            // контрольный вывод массива

Console.WriteLine($"Четных чисел в этом массиве - {GetCountEvens(arr)}");