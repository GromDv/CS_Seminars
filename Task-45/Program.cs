

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
        array[i] = rnd.Next(min, max + 1);
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
            Console.Write($"{array[i]},");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}
int[] CopyArray(int[] param)
{
    int[] array = new int[param.Length];
    for (int i = 0; i < param.Length; i++)
        array[i] = param[i];

    return array;
}

int[] arr = CreateArrayRndInt(5, 10, 50);
PrintArray(arr);
int[] arrNew = CopyArray(arr);
PrintArray(arrNew);