// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write("\t{0:d2} ", array[i, j]);

        Console.WriteLine("]");
    }
    Console.WriteLine();
}
// Метод заполняет массив по спирали
void FillSpiralMatrix(int[,] array)
{
    FillElementRec(0, 0, 1, 1, array);
}
// Метод рекурсивно вносит очередное число (counter) по координатам (row,column) в направлении (dir, 0-up,1-right,2-bottom,3-left) во входящую матрицу
void FillElementRec(int row, int column, int dir, int counter, int[,] matrix)
{
    if (matrix[row, column] == 0) matrix[row, column] = counter++;

    if (dir == 1 && column < matrix.GetLength(1) - 1 && matrix[row, column + 1] == 0)
        column++;
    else if (dir == 2 && row < matrix.GetLength(0) - 1 && matrix[row + 1, column] == 0)
        row++;
    else if (dir == 3 && column > 0 && matrix[row, column - 1] == 0)
        column--;
    else if (dir == 0 && row > 0 && matrix[row - 1, column] == 0)
        row--;
    else
    {
        dir++;
        dir %= 4;
        if (dir == 1 && column < matrix.GetLength(1) - 1 && matrix[row, column + 1] == 0)
            column++;
        else if (dir == 2 && row < matrix.GetLength(0) - 1 && matrix[row + 1, column] == 0)
            row++;
        else if (dir == 3 && column > 0 && matrix[row, column - 1] == 0)
            column--;
        else if (dir == 0 && row > 0 && matrix[row - 1, column] == 0)
            row--;
        else return;
    }
    FillElementRec(row, column, dir, counter, matrix);
}

int[,] matrix = new int[5, 4];
PrintMatrix(matrix);
FillSpiralMatrix(matrix);
PrintMatrix(matrix);