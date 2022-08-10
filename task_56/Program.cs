/*Задайте прямоугольный двумерный массив. Напишите программу,
которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт 
номер строки с наименьшей суммой элементов: 1 строка
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

void FillArraySum(int[,] array3)
{
    int[] arraySum = new int[array3.GetLength(0)];
    for (int i = 0; i < array3.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array3.GetLength(1); j++)
        {
            sum = sum + array3[i, j];
        }
        arraySum[i] = sum;
        Console.WriteLine(string.Format("{0,4:d}", arraySum[i]));
    }
    int minSum = arraySum[0];
    int iMin = 0;
    for (int i = 1; i < arraySum.Length; i++)
    {
        if (arraySum[i] < minSum)
        {
            minSum = arraySum[i];
            iMin = i;
        }
    }
    Console.WriteLine(string.Format("номер строки с наименьшей суммой элементов: {0,2:d} строка ", iMin));
}
int[,] array = new int[m, n];
FillArray(array);
PrintArray(array);
Console.WriteLine();
FillArraySum(array);
