/*
Задайте двумерный массив из целых чисел. Найдите 
среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

int m = 0;
int n = 0;
Console.Write("Задайте размер <m> двумерного массива:");
int.TryParse(Console.ReadLine(), out m);
Console.Write("Задайте размер <n> двумерного массива:");
int.TryParse(Console.ReadLine(), out n);

void FillArray(int[,] array1)
{
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array1.GetLength(1); j++)
        {
            array1[i, j] = new Random().Next(10);
        }
    }
}
void PrintArray(int[,] array2)
{
    for (int i = 0; i < array2.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            Console.Write(string.Format("{0,4:d} ", array2[i, j]));
        }
        Console.WriteLine();
    }
}

void FillArrayAverage(int[,] array3)
{
    float[] arrayAverage = new float[array3.GetLength(1)];
    for (int j = 0; j < array3.GetLength(1); j++)
    {
        float sum = 0;
        float average = 1;
        for (int i = 0; i < array3.GetLength(0); i++)
        {
            sum = sum + array3[i, j];
            average = sum / (i + 1);
        }
        arrayAverage[j] = average;
        Console.Write(string.Format("{0,4:f1} ", arrayAverage[j]));
    }
}
int[,] array = new int[m, n];
FillArray(array);
PrintArray(array);
Console.WriteLine();
FillArrayAverage(array);
