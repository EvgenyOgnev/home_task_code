/*
Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/

void FillPrintArray(int[] collection)
{
    int Length = collection.Length;
    int index = 0;
    Console.Write($"[");
    while (index < Length)
    {
        collection[index] = new Random().Next(1, 100);
        if (index < (Length - 1))
        {
            Console.Write(collection[index] + ", ");
        }
        else Console.Write(collection[index] + "]");
        index++;
    }
}
void MaxMinDifference(int[] col)
{
    int max = col[0];
    int min = col[0];
    for (int position = 0; position < col.Length; position++)
    {
        if (col[position] > max) max = col[position];
        else
        {
            if (col[position] < min) min = col[position];
        }
    }
    Console.WriteLine($"разницa между max и min элементами = {max - min}");
}

int[] array = new int[7];
FillPrintArray(array);
Console.WriteLine();
MaxMinDifference(array);
