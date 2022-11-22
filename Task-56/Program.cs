// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] array = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = rnd.Next(min, max + 1);
    return array;
}
void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write("{0,4} ", array[i, j]);

        Console.WriteLine("]");
    }
    Console.WriteLine();
}
// метод возвращает массив построчных сумм входного двумерного массива
int[] RowElemsSum(int[,] array)
{
    int[] res = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            res[i] += array[i, j];
        }
    }
    return res;
}
// метод возвращает минимальный элемент входного массива и его индекс
int[] MinElem(int[] array)
{
    int[] res = new int[2];
    int min = array[0];
    int index = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (min > array[i])
        {
            min = array[i];
            index = i;
        }
    }
    res[0] = index;
    res[1] = min;
    return res;
}

int[,] mtr = CreateMatrixRndInt(4, 4, 0, 10);
PrintMatrix(mtr);
int[] sumRows = RowElemsSum(mtr);
int[] result = MinElem(sumRows);
Console.WriteLine($"Наименьшая сумма {result[1]} в строке {result[0]}");
