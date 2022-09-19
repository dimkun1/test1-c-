// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 
// 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не 
// рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

void PrintArray(string[] world)
{
    Console.Write("[");
    for (int i = 0; i < world.GetLength(0); i++)
    {

        
        if (i < world.GetLength(0) - 1) Console.Write($"{world[i]}, ");
        else Console.Write($"{world[i]}");
    }

        Console.WriteLine("]");
        Console.WriteLine();
}



string[] world = { "Tom", "Sam", "Bob", "Tamara", "Vika" };


PrintArray(world);



string[] copyworld = new string[world.GetLength(0)];

for (int i = 0; i < world.GetLength(0); i++)
{
    copyworld[i] = world[i];
}
    

PrintArray(copyworld);

