// Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в
// отрезке [10,99].


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


int GetCountElements(int[] arrParam)
{
    int count = 0;
    for (int i = 0; i < arrParam.Length; i++)
    {
        if(arrParam[i] >= 10 && arrParam[i] <= 99) count++;
    }
    return count;
}


int[] arr = CreateArrayRndInt(123, 0, 200);
PrintArray(arr);
int result = GetCountElements(arr);
Console.WriteLine($"Количество элементов массива, из отрезка [10,99] = {result}");

