Console.WriteLine("Введите первое число");
string numberStr1 = Console.ReadLine();
int a = Convert.ToInt32(numberStr1);
Console.WriteLine("Введите второе число");
string numberStr2 = Console.ReadLine();
int b = Convert.ToInt32(numberStr2);
if (a>b)
{
    Console.WriteLine($"max={a}, min={b}");
}
else
{
    Console.WriteLine($"max={b}, min={a}");
}
