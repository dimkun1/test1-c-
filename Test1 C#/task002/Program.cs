// Console.Write("Введите целове число: ");
// int a = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите целове число: ");
// int b = Convert.ToInt32(Console.ReadLine());

// if (a * a == b) 
// {
//     Console.WriteLine("Да");
// }
// else
// {   
//     Console.WriteLine("Нет");
// }


// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22


Console.Write("Введите целове число: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите целове число: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите целове число: ");
int с = Convert.ToInt32(Console.ReadLine());

int max = a;

if (b > max) 
{
    max = b;
}
if (с > max) 
{
    max = с;
}
else
{   
    max = a; 
}

Console.WriteLine($"max = {max}");


