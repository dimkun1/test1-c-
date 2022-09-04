
// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2





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



int[,] arr = CreateArrayRnd(4, 4, 0, 9);
PrintArray(arr);
Console.WriteLine("Отсортированный массив: ");
OrderArrayLines(arr);
PrintArray(arr);

void OrderArrayLines(int[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      for (int k = 0; k < matrix.GetLength(1) - 1; k++)
      {
        if (matrix[i, k] < matrix[i, k + 1])
        {
          int temp = matrix[i, k + 1];
          matrix[i, k + 1] = matrix[i, k];
          matrix[i, k] = temp;
        }
      }
    }
  }
}