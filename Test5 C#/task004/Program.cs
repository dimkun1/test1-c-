
// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] CreateArrayRndInt(int size, int min, int max)
{
    double[] array = new double[size];
    Random rand = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = rand.Next(min, max + 1) + rand.NextDouble();
    }
    return array;

}



// double[] array = new double[3];
// Random rand = new Random();
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = 5 - rand.Next(11) + rand.NextDouble();
//     Console.Write($"{array[i]:f2}, ");
// }




void PrintArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]:f2}, ");
        else Console.Write($"{array[i]:f2}");
    }
    Console.Write("]");
    Console.WriteLine();
}

double GetRaznicaMaxMin(double[] array)
{
    double max = array[0];
    double min = array[0];

    for (int i = 0; i < array.Length; i++) 
    {
        if (array[i] > max) max = array[i];
        else if(array[i] < min) min = array[i];
    }
    
    return max - min;

}

double[] arr = CreateArrayRndInt(4, -100, 100);
PrintArray(arr);
double raz = GetRaznicaMaxMin(arr);
Console.WriteLine($"Разница чисел max min = {raz:f2}");


// int[] random = CreateArrayRndInt(5, 0, 200);
// int Count(int[]random)
// {
//     int count = 0;
//     for (int i = 0; i < random.Length; i++)
//     {
//         if(random[i] >= 10 && random[i] <= 99)
//         count++;
//     }
//     return count;
// }

// Console.WriteLine(Count(random));



