// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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
// Метод возвращает сумму элементов, стоящих на нечетных позициях во входном массиве
int GetCountEvens(int[] arrParam)
{
    int result = 0;
    for (int i = 1; i < arrParam.Length; i += 2)
        result += arrParam[i];

    return result;
}

int[] arr = CreateArrayRndInt(4, 1, 9);    // получаем массив размером 4 элемента в интервале [1,99]
PrintArray(arr);                            // контрольный вывод массива

Console.WriteLine($"Сумма чисел, стоящих на нечетных позициях в этом массиве = {GetCountEvens(arr)}");