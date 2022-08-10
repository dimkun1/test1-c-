// Задача 13: Напишите программу, которая выводит третью цифру 
//заданного числа или сообщает, что третьей цифры нет. 
//Решить без использования строк.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());


while (number > 1000) 
{
    number = number / 10;    
}

if (number < 1000 && number > 99) Console.WriteLine(number % 10);
if (number < 100) Console.WriteLine("третьей цифры нет");


