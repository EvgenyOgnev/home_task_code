/*
Напишите программу, которая принимает на вход три числа и 
выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

int a = new Random().Next(0, 100);
Console.WriteLine(a);
int b = new Random().Next(0, 100);
Console.WriteLine(b);
int c = new Random().Next(0, 100);
Console.WriteLine(c);

int max = a;

if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;

Console.WriteLine($"max = {max}");

/*if(b > max)
{
    Console.WriteLine($"max = {a}");
}
else
{
    Console.WriteLine($"max = {b}");
}


int[] array = new int[3];



int length = 3;
int index = 0;
while (index < length)
{
    array [index] = new Random().Next(1, 100);
    index++;
}
return Console.WriteLine(array[index]);

//Console.WriteLine();
int length = array.Length;
int index = 0;
 while (index < length)
{
    Console.WriteLine(array[index]);
    index++;
}
return;


/*void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;
    while (index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break;            // прерви
        }
        index++;
    }
    return position;
}

int[] array = new int[7];

FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 9);
Console.WriteLine(pos);
*/