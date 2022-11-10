// программa, принимает на вход число N и 
// выдаёт произведение чисел от 1 до N.

// 4 -> 24
// 5 -> 120


int ProductOfNumbers(int numProduct)
{
    int multNum = 1;
    for (int i = 1; i <= numProduct; i++)
    {
        multNum = multNum * i;
    }
    return multNum;
}


Console.WriteLine("Введите число: ");
int numNr = Convert.ToInt32(Console.ReadLine());
if (numNr > 0)
{
    int productOfNumbers = ProductOfNumbers(numNr);
    Console.WriteLine($"Произведение чисел от 1 до {numNr} = {productOfNumbers}");
}
else
{
    Console.WriteLine("Вы ввели некорректное число");
}
