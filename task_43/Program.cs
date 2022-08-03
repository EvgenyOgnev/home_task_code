/*
Напишите программу, которая найдёт точку 
пересечения двух прямых, заданных уравнениями 
y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 
задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)
*/
// Введите значение k1 для уравнениями y = k1 * x + b1:

double k1 = 0;
double k2 = 0;
double b1 = 0;
double b2 = 0;
Console.Write("Для уравнениями y = k1 * x + b1, введите значение k1: ");
double.TryParse(Console.ReadLine(), out k1);
Console.Write("Для уравнениями y = k1 * x + b1, введите значение b1: ");
double.TryParse(Console.ReadLine(), out b1);
Console.Write("Для уравнениями y = k2 * x + b2, введите значение k2: ");
double.TryParse(Console.ReadLine(), out k2);
Console.Write("Для уравнениями y = k2 * x + b2, Введите значение b2: ");
double.TryParse(Console.ReadLine(), out b2);
double x = 0;
double y = 0;
if (k1 != k2)
{
    x = (b2 - b1) / (k1 - k2);
    y = k1 * x + b1;
    Console.Write($"Координаты точки пересечения прямых: ({x}; {y})");
}
else Console.Write("Прямые паралельные");