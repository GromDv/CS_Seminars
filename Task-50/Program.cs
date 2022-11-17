// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

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
            Console.Write("\t{0} ", array[i, j]);

        Console.WriteLine("]");
    }
    Console.WriteLine();
}
// Конвертируем входную строку в целочисленный массив
int[] ConvertInputStrToIntArray(string input)
{
    string[] indexesWords = input.Split(',');
    int[] result = new int[indexesWords.Length];
    for (int i = 0; i < indexesWords.Length; i++)
    {
        result[i] = Convert.ToInt32(indexesWords[i]);
    }
    return result;
}
// Метод проверяет индексы
bool IsIndexCorrect(int[] index) => index[0] >= 0 && index[0] < 3 && index[1] >= 0 && index[1] < 5;

Console.Write("Введите индексы элемента двумерного массива, разделяя запятыми: ");
string? inputStr = Console.ReadLine();                          // ? - учитываем возможность введения пустой строки
Console.WriteLine();                                            // Пропускаем строку

if (inputStr != null)                                           // если введена не пустая строка, то...
{
    int[] elementIndexes = ConvertInputStrToIntArray(inputStr); // получаем массив введеных индексов 
    int[,] arr = CreateMatrixRndInt(3, 5, 0, 10);
    PrintMatrix(arr);

    if (IsIndexCorrect(elementIndexes))
        Console.WriteLine($"Значение элемента [{elementIndexes[0]}, {elementIndexes[1]}] = {arr[elementIndexes[0], elementIndexes[1]]}");
    else
        Console.WriteLine($"Нет такого элемента: [{elementIndexes[0]}, {elementIndexes[1]}]");
}
else
    Console.Write("Числа не были введены!");
