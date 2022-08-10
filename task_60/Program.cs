// Сформируйте трёхмерный массив из неповторяющихся 
// двузначных чисел. Напишите программу, которая
// будет построчно выводить массив, добавляя индексы 
// каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int x = 2;
int y = 2;
int z = 2;
void FillArray(int[,,] collection)
{
    for (int i = 0; i < collection.GetLength(0); i++)
        for (int j = 0; j < collection.GetLength(1); j++)
            for (int q = 0; q < collection.GetLength(2); q++)
                collection[i, j, q] = new Random().Next(10, 100);
}
void PrintArray(int[,,] col)
{
    for (int i = 0; i < col.GetLength(0); i++)
    {
        for (int j = 0; j < col.GetLength(1); j++)
        {
            for (int q = 0; q < col.GetLength(2); q++)
            {
                Console.Write(string.Format("{0,2:d}({1:d},{2:d},{3:d}) ",
                col[i, j, q], i, j, q));
            }
        }
        Console.WriteLine();
    }
}
int[,,] array = new int[x, y, z];
FillArray(array);
PrintArray(array);
