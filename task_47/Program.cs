/*
Задайте двумерный массив размером m×n, 
заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/
int m = 0;
int n = 0;
Console.Write("Задайте размер <m> двумерного массива:");
int.TryParse(Console.ReadLine(), out m);
Console.Write("Задайте размер <n> двумерного массива:");
int.TryParse(Console.ReadLine(), out n);

void FillArray(double[,] collection)
{
    for (int i = 0; i < collection.GetLength(0); i++)
    {
        for (int j = 0; j < collection.GetLength(1); j++)
        {
            double a = new Random().Next(-99, 100);
            collection[i, j] = a / 10;
        }
    }
}
void PrintArray(double[,] col)
{
    for (int i = 0; i < col.GetLength(0); i++)
    {
        for (int j = 0; j < col.GetLength(1); j++)
        {
            Console.Write(string.Format("{0,4:f1} ", col[i, j]));
        }
        Console.WriteLine();
    }
}
double[,] array = new double[m, n];
FillArray(array);
PrintArray(array);
