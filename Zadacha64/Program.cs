/*Задача 64: Задайте значение N. Напишите программу, 
которая выведет все натуральные числа в промежутке от N до 1. 
Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/
int n = ReadInt("Введите число N: ");

void NumbersFromNto1(int n)
{
    if (n == 1)
    {
        Console.Write($"{n} ");
        return;
    }
    Console.Write($"{n}, ");
    NumbersFromNto1(n - 1);
}

NumbersFromNto1(n);

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}