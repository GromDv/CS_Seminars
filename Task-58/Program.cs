// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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
// метод возвращает матрицу произведения двух входящих матриц
int[,] MultyplyMatrix(int[,] arr1, int[,] arr2)
{
    int[,] res = new int[arr1.GetLength(1), arr1.GetLength(0)];

    for (int i = 0; i < arr1.GetLength(0); i++)
    {
        for (int j = 0; j < arr1.GetLength(1); j++)
        {
            res[i, j] = MultElem(i, j, arr1, arr2);
        }
    }
    return res;
}
// метод расчитывает элемент[indI,indJ] матрицы произведения входящих матриц
int MultElem(int indI, int indJ, int[,] arr1, int[,] arr2)
{
    int res = 0;

    for (int i = 0; i < arr1.GetLength(0); i++)
    {
        res += arr1[indI, i] * arr2[i, indJ];
    }
    return res;
}
// метод проверяет возможность перемножения матриц (равенство столбцов1 и строк2)
bool MultyplyAbility(int[,] arr1, int[,] arr2) => arr1.GetLength(1) == arr2.GetLength(0);

int[,] mtr1 = CreateMatrixRndInt(2, 2, 0, 3);
PrintMatrix(mtr1);
int[,] mtr2 = CreateMatrixRndInt(2, 2, 0, 3);
PrintMatrix(mtr2);

if (MultyplyAbility(mtr1, mtr2))
{
    Console.WriteLine("Произведение:");
    int[,] mtr3 = MultyplyMatrix(mtr1, mtr2);
    PrintMatrix(mtr3);
}
else
{
    Console.WriteLine("Размерность матриц не позволяет их перемножить!");
}
