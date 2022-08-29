// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 1, 7 -> такого элемента в массиве нет



Console.WriteLine("Введите два натуральных числа, координаты");
int x = Convert.ToInt32(Console.ReadLine()) - 1;
int y = Convert.ToInt32(Console.ReadLine()) - 1;


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
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 3}, ");
            else Console.Write($"{matrix[i, j], 3}");
        }
        Console.WriteLine("]");
    }
}

void FindElement(int[,] matrix)
{

    if (x <= matrix.GetLength(0) && y <= matrix.GetLength(1)) Console.WriteLine(matrix[x, y]);
    else Console.WriteLine("Такого элемента нет");
    return;
}


int[,] arr = CreateArrayRnd(3, 4, -9, 9);
PrintArray(arr);
FindElement(arr);




