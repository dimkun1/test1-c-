// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3


Console.Write("Введите несколько чисел через пробел: ");
int[] array = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int count = 0;
 
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
    {
        count++;
    }
}
 
Console.WriteLine($"Вы ввели числа > 0: {count}");


// int[] CreateArrayRndInt(int size, int min, int max)
// {
//     int[] array = new int[size];
//     Random rand = new Random();

//     for (int i = 0; i < size; i++)
//     {
//         array[i] = rand.Next(min, max + 1);
//     }
//     return array;

// }

// void PrintArray(int[] array)
// {
//     Console.Write("[");
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (i < array.Length - 1) Console.Write($"{array[i]}, ");
//         else Console.Write($"{array[i]}");
//     }
//     Console.Write("]");
//     Console.WriteLine();
// }

// int Perevorotazza(int[] array)
// {
//     int temp = 0;
//     int j = array.Length - 1;

//     for (int i = 0; i < array.Length; i++) 
//     {
//         if (i > j) max = array[i];
//         else if(array[i] < min) min = array[i];
//     }
    
//     return max - min;

// }

// int[] arr = CreateArrayRndInt(4, -100, 100);
// PrintArray(arr);
// // int raz = GetRaznicaMaxMin(arr);
// // Console.WriteLine($"Разница чисел max min = {raz:f2}");


