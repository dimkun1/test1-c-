﻿
// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях (индексах).

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0


int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;

}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]},");
        else Console.Write(array[i]);
    }
    Console.Write("]");
    Console.WriteLine();
}

int[] GetSumPosElemNechet(int[] array)
{
    int sumnechet = 0;

    for (int i = 1; i < array.Length; i = i + 2) sumnechet += array[i];

    return new int[]{sumnechet};

}

int[] arr = CreateArrayRndInt(4, -100, 100);
PrintArray(arr);
int[] sumnechet = GetSumPosElemNechet(arr);
Console.WriteLine($"Сумма чисел на нечетных индексах = {sumnechet[0]}");
