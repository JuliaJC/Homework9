/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму 
натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

int m = ReadInt("Введите число M: ");
int n = ReadInt("Введите число N: ");

int SumFromMtoN(int max, int min)
{
    if (min == max) return min;
    int sum = min + SumFromMtoN(max, min + 1);
    return sum;
}

int max; int min;
if (m >= n) { min = n; max = m; }
else { min = m; max = n; }
System.Console.WriteLine("Сумма натуральных элементов в промежутке : " + SumFromMtoN(max, min));

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}