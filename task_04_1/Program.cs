/* Напишите программу, которая принимает на вход три числа и 
выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

int[] array = new int[3];

int length = array.Length;
int index = 0;

while (index < length)
{
    array[index] = new Random().Next(1, 100);
    Console.WriteLine(array[index]);
    index++;
}

int max = 0;
for(int i = 0; array[i] > max; i++)
{
    max = array[i];
}

Console.WriteLine($"max = {max}");
