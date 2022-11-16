// Найдите произведение пар чисел в одномерном массиве (5 эл).
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

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


int[] MultiplicationNumbers(int[] arrParam)
{
    int size = arrParam.Length / 2;

    if (arrParam.Length % 2 == 1)
        size++;

    int[] newArray = new int[size];

    for (int i = 0; i < arrParam.Length / 2; i++)
        newArray[i] = arrParam[i] * arrParam[arrParam.Length - 1 - i];

    if (arrParam.Length % 2 == 1)
        newArray[newArray.Length - 1] = arrParam[arrParam.Length / 2];

    return newArray;
}


int[] arr = CreateArrayRndInt(5, 1, 9);
PrintArray(arr);

int[] result = MultiplicationNumbers(arr);
PrintArray(result);
