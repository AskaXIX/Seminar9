// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int ReadInt(string text)
{
    System.Console.Write(text);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int SumNumbers(int n, int m)
{
    if (n == m) return n;
    else return SumNumbers(n + 1, m) + n;
}

int n = ReadInt("Input N: ");
int m = ReadInt("Input M: ");

System.Console.WriteLine(SumNumbers(n, m));