

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

Console.Write("Ведите число: ");
int x = Convert.ToInt32(Console.ReadLine());
int summa = 0;

while(x > 0)
{
    int a = x % 10;
    summa = summa + a;
    x = x / 10;
}
Console.WriteLine(summa);

