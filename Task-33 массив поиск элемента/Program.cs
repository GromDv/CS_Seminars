// Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да


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


bool FindInArr(int[] arrWhere, int whatToFind)
{
    bool result = false;
    for (int i = 0; i < arrWhere.Length; i++)
    {
        if (arrWhere[i] == whatToFind)
        {
            result = true;
            break;
        }
    }
    return result;
}


int[] array = CreateArrayRndInt(10, 0, 100);
PrintArray(array);

Console.Write("Что будем искать? ");
int elem = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(FindInArr(array, elem) ? "Да, есть такой!" : "Нет такого!");
