﻿/* Напишите программу, которая на вход принимает число и выдаёт, 
является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет
*/

int num = 0;

Console.Write("Введите число: ");
num = int.Parse(Console.ReadLine()!);

if(num == 0)
{
    Console.WriteLine($"{num} - является <<наиболее чётным>> числом из всех чисел");
}
else
{
    if(num % 2 == 0)
    {
        Console.Write($"{num} - является чётным числом");
    }
    else
    {
        Console.Write($"{num} - является нечётным числом");
    }   
}

