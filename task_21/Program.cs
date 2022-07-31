/*
Напишите программу, которая принимает на вход координаты двух точек и
находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

Console.Write("Введите координату х точки А: ");
int x1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите координату y точки А: ");
int y1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите координату z точки А: ");
int z1 = int.Parse(Console.ReadLine()!);

Console.Write("Введите координату х точки B: ");
int x2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите координату y точки B: ");
int y2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите координату z точки B: ");
int z2 = int.Parse(Console.ReadLine()!);

int ab = (x2-x1)*(x2-x1) + (y2 - y1)*(y2 - y1) + (z2 - z1)*(z2 - z1);

Console.WriteLine("Расстояние между А и В = " + MathF.Sqrt(ab));







//  Console.WriteLine("Hello, World!");
 /*
 
 Console.Write("Введите число N: ");
int size = int.Parse(Console.ReadLine()!);
int[] array = new int[size];
Console.Write($"кубы чисел от 1 до {size} ->> ");
for(int i = 0; i < size; i++)
{
    int j = i + 1;
    array[i] = j*j*j;
    Console.Write(array[i] + ", ");
}

Console.Write($"кубы чисел от 1 до {size} ->> ");
for(int i = 0; i < size; i++)
{
    int j = i + 1;
    array[i] = j*j*j;
    Console.Write(array[i] + ", ");
}
*/


//int[] b = new int[3];
/*
int[] a = new int[3];
int[] b = new int[3];
Console.Write("Введите координату х точки А: ");
a[0] = int.Parse(Console.ReadLine()!);
Console.Write("Введите координату y точки А: ");
a[1] = int.Parse(Console.ReadLine()!);
Console.Write("Введите координату z точки А: ");
a[2] = int.Parse(Console.ReadLine()!);
//Console.WriteLine();

//int[] b = new int[3];
Console.Write("Введите координату х точки B: ");
b[0] = int.Parse(Console.ReadLine()!);
Console.Write("Введите координату y точки B: ");
b[1] = int.Parse(Console.ReadLine()!);
Console.Write("Введите координату z точки B: ");
b[2] = int.Parse(Console.ReadLine()!);

//int[] a = new int[3];
//int[] b = new int[3];

void PrintArray(int[] col)
{
    Console.Write("koordinat ( ");
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        //Console.Write("sd" + col[position] + " ");
        Console.Write(col[position] + " ");
        position++;
    }
    Console.Write(")");
}

PrintArray(a);
Console.WriteLine();
PrintArray(b);

*/

//Console.WriteLine(a[3]);
//Console.WriteLine(b[3]);

/*
void FillArray(int[] collection)
{
    int Length = collection.Length;
    int index = 0;
    while (index < Length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }

}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        //Console.Write("sd" + col[position] + " ");
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
            break;            // прервать
        }
        index++;
    }
    return position;
}

int[] array = new int[15];

FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 9);
Console.WriteLine(pos);
*/

