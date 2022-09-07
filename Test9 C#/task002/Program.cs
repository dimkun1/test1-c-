// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30



Console.Clear();
int m = InputNumbers("Введите число m ");
int n = InputNumbers("Введите число n ");

int result = SummaNM(m, n);
Console.WriteLine($"Сумма чисел от {m} до {n} равна {result}");


int InputNumbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

int SummaNM(int m, int n)
{
    if(n > m)
        return n + SummaNM(m, n - 1);
    return m;
}