/*
Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/
int m = 0;
int amount = 0;
Console.Write("Сколько хотите ввести чисел: ");
int.TryParse(Console.ReadLine(), out m);
int[] array = new int[m];
Console.Write("введите число:\n");
for (int i = 0; i < array.Length; i++)
{
    Console.Write(" ");
    int.TryParse(Console.ReadLine(), out array[i]);
}
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0) amount = amount + 1;
}
Console.Write($"Чисел больше 0 -->> {amount}");

