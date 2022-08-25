
// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)



// double[] TochkaPeresecheniya(double b1, double k1, double b2, double k2)
// {
//     double[] array = new double[2];
//     array[0] = (b2 - b1) / (k1 - k2);
//     array[1] = k1 * array[0] + b1;
//     return array;
// }

// double[] tochka = TochkaPeresecheniya(2, 5, 4, 9);
// Console.WriteLine(tochka);


double[] TochkaPeresecheniya(double b1, double k1, double b2, double k2)
{
    double[] array = new double[2];
    array[0] = (b2 - b1) / (k1 - k2);
    array[1] = k1 * array[0] + b1;
    return array;
}


void PrintArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.Write("]");
    Console.WriteLine();
}


double[] tochka = TochkaPeresecheniya(2, 5, 4, 9);
PrintArray(tochka);







