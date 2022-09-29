// Задача 64: Задайте значение N. Напишите программу, которая выведет 
// все чётные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "4, 2"
// N = 8 -> "8, 6, 4, 2"

Console.Clear();

Console.Write("Pls enter number > 1: ");
int num = int.Parse(Console.ReadLine());

void NaturalNumber(int num)
{
    if (num < 0) Console.Write($"{num} -> not belongs to N");
    if (num == 0) return;
    if (num % 2 == 0) Console.Write("{0,2},", num);
    NaturalNumber(num - 1);
}
Console.Write($"N = {num} ->");
NaturalNumber(num);
