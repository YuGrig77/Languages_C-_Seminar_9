// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();

int m = InputNumber("Pls enter M: ");
int n = InputNumber("Pls enter N: ");
Console.WriteLine($"M = {m}; N = {n} -> {CountSumNaturalElements(m, n)}");

int InputNumber(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}

int CountSumNaturalElements(int m, int n)
{
    if (m == n) return n;
    return n + CountSumNaturalElements(m, n - 1);
}