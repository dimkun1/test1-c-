
// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)




int[,,] CreateArrayRnd(int row, int col, int mat, int min, int max)
{
    int[,,] matrix = new int[row, col, mat];
    int[] temp = new int[matrix.GetLength(0) * matrix.GetLength(1) * matrix.GetLength(2)];
    int number;
    for (int i = 0; i < temp.GetLength(0); i++)
    {
        temp[i] = new Random().Next(min, max);
        number = temp[i];
        if (i >= 1)
        {
            for (int j = 0; j < i; j++)
            {
                while (temp[i] == temp[j])
                {
                    temp[i] = new Random().Next(min, max);
                    j = 0;
                    number = temp[i];
                }
                number = temp[i];
            }
        }
    }
    int count = 0;
    for (int a = 0; a < matrix.GetLength(0); a++)
    {
        for (int b = 0; b < matrix.GetLength(1); b++)
        {
            for (int c = 0; c < matrix.GetLength(2); c++)
            {
                matrix[a, b, c] = temp[count];
                count++;
            }
        }
    }
    return matrix;
}




void PrintArray(int[, ,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {


            Console.Write("[");
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                if (k < matrix.GetLength(2) - 1) Console.Write($"{matrix[i, j, k], 1}, ({i}, {j}, {k}), ");
                else Console.Write($"{matrix[i, j, k], 1}, ({i}, {j}, {k})");

            }
            Console.WriteLine("]");
        }
    }
}


int[, ,] arr = CreateArrayRnd(2, 2, 2, 10, 18);
PrintArray(arr); 