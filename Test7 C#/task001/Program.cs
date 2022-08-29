// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9



double[,] CreateArrayRnd(int row, int col, int min, int max)
{
    double[,] matrix = new double[row, col];
    Random rand = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)       // строки row
    {
        for(int j = 0; j < matrix.GetLength(1); j++)        // столбцы col
        {
            matrix[i, j] = rand.Next(min, max) + rand.NextDouble();
        }
        
    }
    return matrix;

}





void PrintArray(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j]:f2}, ");
            else Console.Write($"{matrix[i, j]:f2}");
        }
        Console.WriteLine("]");
    }
}



double[,] arr = CreateArrayRnd(3, 4, -9, 9);
PrintArray(arr);
