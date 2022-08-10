/*
Задача 54: Задайте двумерный массив. Напишите программу, 
которая упорядочит по убыванию элементы каждой строки 
двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

int m = 0;
int n = 0;
Console.Write("Задайте размер <m> двумерного массива:");
int.TryParse(Console.ReadLine(), out m);
Console.Write("Задайте размер <n> двумерного массива:");
int.TryParse(Console.ReadLine(), out n);

void FillArray(int[,] collection)
{
    for (int i = 0; i < collection.GetLength(0); i++)
    {
        for (int j = 0; j < collection.GetLength(1); j++)
        {
            collection[i, j] = new Random().Next(100);
        }
    }
}
void PrintArray(int[,] col)
{
    for (int i = 0; i < col.GetLength(0); i++)
    {
        for (int j = 0; j < col.GetLength(1); j++)
        {
            Console.Write(string.Format("{0,2:d2} ", col[i, j]));
        }
        Console.WriteLine();
    }
}

void FillArraySnake(int[,] coll)
{
    for (int i = 0; i < coll.GetLength(0); i++)
    {
        
        
        for (int x = 0; x < coll.GetLength(1); x++)
        {
            int max = coll[i, x];
            int jMax = x;
            for (int j = x; j < coll.GetLength(1) /*- x*/; j++)
            {
                if (coll[i, j] > max)
                {
                    max = coll[i, j];
                    jMax = j;
                }
            }
            if (coll[i, x] != max) 
            {
                int tMax = coll[i, jMax];
                coll[i, jMax] = coll[i, x];
                coll[i, x] = tMax;
            }
        }
    }
}

int[,] array = new int[m, n];
FillArray(array);
PrintArray(array);
Console.WriteLine();
FillArraySnake(array);
PrintArray(array);

