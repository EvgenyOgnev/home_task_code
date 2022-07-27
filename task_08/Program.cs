/* Напишите программу, которая на вход принимает число (N), 
а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8
*/

int N = 0;

Console.Write("Введите число: ");
N = int.Parse(Console.ReadLine()!);

for(int i=1; i <= N; i+=1)
{   
    if(i % 2 == 0)
    {
    Console.Write($"{i} ");
    } 
}
 Console.WriteLine();

