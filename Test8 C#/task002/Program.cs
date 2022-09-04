// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


int[,] CreateArrayRnd(int row, int col, int min, int max)
{
    int[,] matrix = new int[row, col];
    Random rand = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)       // строки row
    {
        for(int j = 0; j < matrix.GetLength(1); j++)        // столбцы col
        {
            matrix[i, j] = rand.Next(min, max);
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
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 1}, ");
            else Console.Write($"{matrix[i, j], 1}");

        }
        Console.WriteLine("]");
    }
}








void ProizvedArr(int[,] arr, int[,] arr2, int[,] arr3)
{
    for (int i = 0; i < arr3.GetLength(0); i++)
    {
        for (int j = 0; j < arr3.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < arr.GetLength(1); k++)
            {
                sum += arr[i,k] * arr2[k,j];  
            }
            arr3[i,j] = sum;
        }
    }

}


int[,] arr = CreateArrayRnd(2, 2, 1, 9);
int[,] arr2 = CreateArrayRnd(2, 2, 1, 9);
int[,] arr3 = new int[2,2];
ProizvedArr(arr, arr2, arr3);
PrintArray(arr);
Console.WriteLine();
PrintArray(arr2);
Console.WriteLine();
PrintArray(arr3);