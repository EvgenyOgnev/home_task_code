/*
Задайте массив заполненный случайными положительными 
трёхзначными числами. Напишите программу, которая покажет 
количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/
void FillArray(int[] collection)
{
    int Length = collection.Length;
    int index = 0;
    Console.Write($"[");
    while (index < Length)
    {
        collection[index] = new Random().Next(100, 1000);
        if(index < (Length - 1))
        {
            Console.Write(collection[index] + ", ");    
        }
        else Console.Write(collection[index] + "]");
        index++;
    }
}
void EvenNumber(int[] col)
{
    int sum = 0;
    for(int position = 0; position < col.Length; position++)
    {
        if((col[position] % 2) == 0)
        {
            sum++;
        }
    }
    Console.WriteLine($"количество чётных чисел в массиве -> {sum}");
}
int[] array = new int[10];
FillArray(array);
Console.WriteLine();
EvenNumber(array);
