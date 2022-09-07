﻿// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"



Console.Clear();
int a = InputNumbers("Введите число ");
NatNum(a);



int InputNumbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

void NatNum(int a)
{
    if (a != 0)
    {
        NatNum(a - 1);
        Console.Write(a + " ");
    }
}