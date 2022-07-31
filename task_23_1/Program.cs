
/* Задача 23_1
Напишите программу, которая принимает на вход число (N) 
и выдаёт таблицу кубов чисел от 1^3 до  n^3<=N.
30 -> 1, 8, 27
125 -> 1, 8, 27, 64, 125
*/

Console.Write("Введите число N: ");
int num = int.Parse(Console.ReadLine()!);

Console.Write($"{num} ->> ");

for(int j = 1; Math.Pow(j, 3) <= num; j++)
{
    if(j != (int)Math.Cbrt(num))
    {
       Console.Write($"{Math.Pow(j, 3)}, "); 
    }
    else Console.Write(Math.Pow(j, 3));
}







