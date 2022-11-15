// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// метод возвращает целочисленный массив, полученный из входной строки par(string), полагая разделителем слов par2
int[] ConvertStrToIntArray(string par, char par2)
{
    int countWords = 0;
    for (int i = 0; i < par.Length; i++)
        if (par[i] == par2) countWords++;               // посчитаем количество разделителей
    countWords++;                                       // добавим 1 для последнего слова

    int[] result = new int[countWords];                 // создаем целочисленный массив по вычисленному количеству слов
    int countWord = 0;
    string word = "";                                   // заготовка для формирования слова
    for (int i = 0; i < par.Length; i++)
    {
        if (par[i] == par2 || i == par.Length - 1)      // если достигнут очередной разделитель, то...
        {
            if (i == par.Length - 1)                    // если это последний символ во входной строке, то..
                word += par[i];                         // добавляем его в слово

            result[countWord] = Convert.ToInt32(word);  // получаем число из слова и пишем в массив
            countWord++;                                // увеличиваем счетчик слов
            word = "";                                  // обнуляем заготовку для нового слова
        }
        else                                            // если это просто очередной символ, то
            word += par[i];                             // добавляем его в заготовку
    }
    return result;
}
// метод возвращает число положительных чисел во входящем массиве
int CountPositiveNums(int[] par)
{
    int res = 0;
    for (int i = 0; i < par.Length; i++)                                             
        if (par[i] > 0) res++;
    return res;
}
// метод формирует строку ответа в зависимости от полученного par
string MakeReportStr(int par)
{
    string res = "";
    if (par == 11 || par == 12 || par == 13)
        res = "положительных чисел!";
    else if (par % 10 == 1)
        res = "число!";
    else if (par % 10 == 2 || par % 10 == 3 || par % 10 == 4)
        res = "положительных числа!";
    else
        res = "положительных чисел!";
    return res;
}

Console.Write("Введите несколько чисел, разделяя пробелами: ");
string? inputStr = Console.ReadLine();                                                  // ? - учитываем возможность введения пустой строки
Console.WriteLine();

if (inputStr != null)                                                                   // а было ли хоть что-то введено, не пустая ли срока?
{
    int[] inputs = ConvertStrToIntArray(inputStr, ' ');                                 // конвертируем входную строку в числовой массив
    int numPositives = CountPositiveNums(inputs);                                       // считаем количество положительныч чисел в массиве
    
    Console.WriteLine($"Введено {numPositives} {MakeReportStr(numPositives)}");
}
else
    Console.Write("Числа не были введены!");

/*
Console.Write("Укажите сколько чисел будет введено: ");
int numberAll = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[] inputs = new int[numberAll];
int numPositives = 0;
for (int i = 0; i < numberAll; i++)
{
    Console.Write($"Введите {i}-е число: ");
    inputs[i] = Convert.ToInt32(Console.ReadLine());
    if (inputs[i] > 0) numPositives++;
}

if (numPositives == 11 || numPositives == 12 || numPositives == 13)
        Console.WriteLine($"Введено {numPositives} положительных чисел!");
else if (numPositives % 10 == 1)
    Console.WriteLine($"Введено {numPositives} число!");
else if (numPositives % 10 == 2 || numPositives % 10 == 3 || numPositives % 10 == 4)
    Console.WriteLine($"Введено {numPositives} положительных числа!");
else
    Console.WriteLine($"Введено {numPositives} положительных чисел!");
*/