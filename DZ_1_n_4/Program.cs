﻿/*Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8
*/

Console.WriteLine("Введите число");
string numberStr = Console.ReadLine();
int a = Convert.ToInt32(numberStr);
for (int i = 1; i<=a; i++)
{
    int c=i % 2;
    if (c == 0)
    {
      Console.Write(i + ",");  
    }
}