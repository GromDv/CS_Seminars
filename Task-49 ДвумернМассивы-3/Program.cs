//Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты. 

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
int[,] FindSquare(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i+=2)
    {
        for (int j = 0; j < array.GetLength(1); j+=2)
        {
            //if (i % 2 == 0 && j % 2 == 0)
                array[i, j] *= array[i, j];
        }
    }
    return array;
}

int[,] mtr = CreateMatrixRndInt(3, 5, -10, 10);
PrintMatrix(mtr);
mtr = FindSquare(mtr);
PrintMatrix(mtr);