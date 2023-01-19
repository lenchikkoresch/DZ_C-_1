Console.WriteLine("Введите трехзначное число");
string numberStr = Console.ReadLine();
int a = Convert.ToInt32(numberStr);
int b = a % 10;
Console.WriteLine(b);
