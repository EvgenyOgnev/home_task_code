/*
Напишите программу, которая принимает на вход число (N) 
и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

Console.Write("Введите число N: ");
int size = int.Parse(Console.ReadLine()!);
int[] array = new int[size];
Console.Write($"кубы чисел от 1 до {size} ->> ");
for(int i = 0; i < size; i++)
{
    int j = i + 1;
    array[i] = j*j*j;
    Console.Write(array[i] + ", ");
}

