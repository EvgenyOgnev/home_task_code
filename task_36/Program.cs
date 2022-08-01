/*
Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

void FillPrintArray(int[] collection)
{
    int Length = collection.Length;
    int index = 0;
    Console.Write($"[");
    while (index < Length)
    {
        collection[index] = new Random().Next(1, 100);
        if(index < (Length - 1))
        {
            Console.Write(collection[index] + ", ");    
        }
        else Console.Write(collection[index] + "]");
        index++;
    }
}
void SumOddNumber(int[] col)
{
    int sum = 0;
    for(int position = 1; position < col.Length; position +=2)
    {
            sum = sum + col[position];
    }
    Console.WriteLine($"суммa на нечётных позициях -> {sum}");
}
int[] array = new int[7];
FillPrintArray(array);
Console.WriteLine();
SumOddNumber(array);

