// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

// Метод выводит массив в одну строку на экран
void PrintArray(int[] param)
{
    Console.Write("[");                                 // открываем скобки
    for (int i = 0; i < param.Length - 1; i++)          
        Console.Write($"{param[i]}, ");                 // выводим каждый элемент через запятую
    Console.WriteLine($"{param[param.Length-1]}]");     // отдельно выводим последний элемент и закрываем скобки
}
// метод принимает массив и возвращает его заполненным случайными числами от 1 до 99
int[] FillArray(int[] param)
{
    Random rnd = new Random();                          
    for (int i = 0; i < param.Length; i++)
        param[i] = rnd.Next(1,99);
    return param;
}

int size = 8;                       // задаем размерность массива
int[] myArray = new int[size];      // создаем массив

PrintArray(FillArray(myArray));     // выводим заполненный массив