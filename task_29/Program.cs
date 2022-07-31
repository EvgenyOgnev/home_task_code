/*
Напишите программу, которая задаёт массив из 8 элементов 
и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/
void FillArray(int[] collection)
{
    int Length = collection.Length;
    int index = 0;
    while (index < Length)
    {
        collection[index] = new Random().Next(0, 100);
        index++;
    }
}
void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    Console.Write($"[");
    while (position < count)
    {
        if(position < (count - 1))
        {
            Console.Write(col[position] + ", ");    
        }
        else Console.Write(col[position] + "]");
        position++;
    }
}
int[] array = new int[8];
FillArray(array);
PrintArray(array);
Console.WriteLine();

