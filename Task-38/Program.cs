// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] array = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = Math.Round(rnd.NextDouble() * (max - min) + min, 1);
    }
    return array;
}

void PrintArrayDbl(double[] arrParam)
{
    Console.Write("[");
    for (int i = 0; i < arrParam.Length; i++)
    {
        if (i < arrParam.Length - 1) Console.Write("{0:#0.0}; ", arrParam[i]);
        else Console.WriteLine("{0:#0.0}]", arrParam[i]);
    }
}
// метод возвращает массив из максимального, минимального элементов входного массива и разницы между ними
double[] GetMaxMinDiff(double[] arrParam)
{
    double[] result = new double[3];
    double max = arrParam[0];
    double min = arrParam[0];
    for (int i = 0; i < arrParam.Length; i++)
    {
        if (arrParam[i] < min)
            min = arrParam[i];
        if (arrParam[i] > max)
            max = arrParam[i];
    }
    result[0] = min;
    result[1] = max;
    result[2] = max - min;
    return result;
}

double[] arr = CreateArrayRndDouble(5, 1, 99);      // получаем массив размером 4 элемента в интервале [1,99]
PrintArrayDbl(arr);                                 // контрольный вывод массива

double[] res = GetMaxMinDiff(arr);

Console.WriteLine("Максимальное значение = {0:#0.0}", res[1]);
Console.WriteLine("Минимальное значение = {0: #0.0}", res[0]);
Console.WriteLine("Разница между макс и мин значениями элементов массива = {0: #0.0}", res[2]);