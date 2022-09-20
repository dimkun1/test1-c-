
// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых 
// меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте 
// выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []




string[] array001 = { "Tamara", "Sam", "Bob", "№%:", "Tom", "Vi", "-2", "фыапуйцй" };
string[] array002 = new string[array001.Length];

void Arrayltt(string[] array001, string[] array002)
{
    int count = 0;
    for (int i = 0; i < array001.Length; i++)
    {
    if(array001[i].Length <= 3)
        {
        array002[count] = array001[i];
        count++;
        }
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}


Arrayltt(array001, array002);

PrintArray(array001);
PrintArray(array002);


