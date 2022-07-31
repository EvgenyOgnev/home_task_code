/*
Напишите цикл, который принимает на вход два 
числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

Console.Write("Введите число: ");
int x = int.Parse(Console.ReadLine()!);
Console.Write("Введите степень: ");
int y = int.Parse(Console.ReadLine()!);
// V1
int mult = 1;
if(y != 0)
{
    for(int i = 1; i <= y; i++)
    {
        mult = mult*x;
    }
}
else mult = 1;
Console.Write($"{x}^{y} = {mult}");

//V2
Console.WriteLine(); 
Console.WriteLine($"{x}^{y} = {Math.Pow(x, y)}");