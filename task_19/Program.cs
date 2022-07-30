/*
Напишите программу, которая принимает на вход пятизначное число и 
проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

Console.Write("Введите пятизначное число: ");
string a = Console.ReadLine()!;                            
int i_end = a.Length - 1;

for(int i = 0; i < a.Length/2; i++ )
{
    if(a[i] == a[i_end])
    {
        if(i == a.Length/2 -1)
        {
            Console.WriteLine($"Число <{a}> является палиндромом");
        }
        i_end = i_end - 1;
    }
    else
    {
        Console.WriteLine($"Число <{a}> не является палиндромом");
        break;
    }               
  

}

