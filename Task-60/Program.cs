// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


// Метод распечатывает трехмерный массив построчно с указанием индексов
void PrintArray3x(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write($"[{i}, {j}, {k}] = {matrix[i, j, k],2};  ");
            }
        }
        Console.WriteLine();
    }
}
// Метод создает трехмерный массив и заполняет его не повторяющимися случайными числами
int[,,] FillArray3xRndInt(int rows, int columns, int depth, int[] NoRndArray)
{
    int[,,] matrix = new int[rows, columns, depth];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i, j, k] = GetNorepeatRnd(NoRndArray);
            }
        }
    }
    return matrix;
}
// Метод берет из входного (неповторяющегося) массива псевдослучайный элемент и заменяет его на -1 
int GetNorepeatRnd(int[] array)
{
    int res = -1;
    int index = 0;
    int count = 0;
    Random rnd = new Random();
    while (res == -1 || count > 100000)   // если элемент равен -1, то берем другой
    {
        index = rnd.Next(0, 100);
        res = array[index];
        count++;                         // защита от зацикливания
    }
    array[index] = -1;
    return res;
}
// Метод создает неслучайный не повторяющийся массив размерности size
int[] CreateNorepeatArray(int size)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = i;
    }
    return arr;
}

int[] notRndArr = CreateNorepeatArray(100);

int[,,] array3x = FillArray3xRndInt(3, 3, 3, notRndArr);
PrintArray3x(array3x);