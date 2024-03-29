﻿// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double[,] CreateMatrixRndDbl(int rows, int columns, int min, int max)
{
    double[,] array = new double[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = (double)(rnd.Next(min * 10, (max + 1) * 10)) / 10.0;
    return array;
}
void PrintMatrixDbl(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j], 8}");

        Console.WriteLine("]");
    }
}

double[,] mtr = CreateMatrixRndDbl(3, 5, -100, 100);
PrintMatrixDbl(mtr);