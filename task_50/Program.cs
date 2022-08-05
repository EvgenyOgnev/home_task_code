/*
Напишите программу, которая на вход принимает позиции 
элемента в двумерном массиве, и возвращает значение этого 
элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/
int m = 0;
int n = 0;
int num = 0;
Console.Write("Задайте размер <m> двумерного массива: ");
int.TryParse(Console.ReadLine(), out m);
Console.Write("Задайте размер <n> двумерного массива: ");
int.TryParse(Console.ReadLine(), out n);
Console.Write("Задайте число для поиска в массиве: ");
int.TryParse(Console.ReadLine(), out num);

void FillArray(int[,] array1)
{
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array1.GetLength(1); j++)
        {
            array1[i, j] = new Random().Next(100);
        }
    }
}
void PrintArray(int[,] array2)
{
    for (int i = 0; i < array2.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            Console.Write(string.Format("{0,2:d} ", array2[i, j]));
        }
        Console.WriteLine();
    }
}

string IndexOf(int[,] array3, int find)
{
    for (int i = 0; i < array3.GetLength(0); i++)
    {
        for (int j = 0; j < array3.GetLength(1); j++)
        {
            if (array3[i, j] == find)
            {
                return ($"array3 [{i}, {j}] = {find}");

            }
        }
    }
    return ($"{find} -> такого числа в массиве нет");
}

int[,] array = new int[m, n];
FillArray(array);
PrintArray(array);
Console.WriteLine();
Console.Write(IndexOf(array, num));
