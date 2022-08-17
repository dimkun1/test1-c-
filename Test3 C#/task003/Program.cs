﻿
// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 10 == number / 10000 && number / 10 % 10 == number / 1000 % 10) Console.WriteLine($"{number} -> ДА");
else Console.WriteLine($"{number} -> НЕТ");
    