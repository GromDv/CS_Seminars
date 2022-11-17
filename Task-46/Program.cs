//Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами. m = 3, n = 4. 1 4 8 19 5 -2 33 -2 77 3 8 1 

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
}

int[,] mtr = CreateMatrixRndInt(3, 5, -100, 100);
PrintMatrix(mtr);
