
// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.



int[,] CreateArrayRnd(int row, int col, int min, int max)
{
    int[,] matrix = new int[row, col];
    Random rand = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)       // строки row
    {
        for (int j = 0; j < matrix.GetLength(1); j++)        // столбцы col
        {
            matrix[i, j] = rand.Next(min, max + 1);
        }

    }
    return matrix;

}





void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {

        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],3}, ");
            else Console.Write($"{matrix[i, j],3}");
        }
        Console.WriteLine("]");
    }
}



void SrednieArifmet(int[,] matrix)
{
    double srednieArif = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            srednieArif += matrix[i, j];
        }
        srednieArif = srednieArif / (matrix.GetLength(0));
        Console.WriteLine($"Cреднее арифметическое элементов столбца {j + 1} = {srednieArif:f1}");
    }
}



int[,] arr = CreateArrayRnd(3, 4, -9, 9);
PrintArray(arr);
Console.WriteLine();
SrednieArifmet(arr);


