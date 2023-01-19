Console.WriteLine("Введите первое число");
string numberStr1 = Console.ReadLine();
int a = Convert.ToInt32(numberStr1);
Console.WriteLine("Введите второе число");
string numberStr2 = Console.ReadLine();
int b = Convert.ToInt32(numberStr2);
int c = a*a;
if (c == b)
{
    Console.WriteLine("Первое число квадрат второго");
    }
    else
    {
     Console.WriteLine("Первое число не является квадратом второго");
    }