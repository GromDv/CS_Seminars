string Quarter(int num)
{
    if(num == 1) return "x > 0, y > 0"; 
    if(num == 2) return "x < 0, y > 0"; 
    if(num == 3) return "x < 0, y < 0"; 
    if(num == 4) return "x > 0, y < 0"; 
    return "Введен неверный номер четверти!";
}

Console.Write("Введите номер четверти:");
int quarter = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Quarter(quarter));
