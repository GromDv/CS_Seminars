//Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д. 

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
int CalcSummDiagonal(int[,] array)
{
    int sum = 0;
    int diag = 0;

    if (array.GetLength(0) > array.GetLength(1))
        diag = array.GetLength(1);
    else
        diag = array.GetLength(0);

    for (int i = 0; i < diag; i++)
    {
        sum += array[i, i];
    }
    return sum;
}

int[,] mtr = CreateMatrixRndInt(3, 5, -10, 10);
PrintMatrix(mtr);
int sum = CalcSummDiagonal(mtr);
Console.WriteLine($"Сумма элементов на главной диагонали = {sum}");