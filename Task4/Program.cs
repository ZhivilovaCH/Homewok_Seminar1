// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Clear();
Console.WriteLine("Введите число А: ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число B: ");
int b = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число С: ");
int c = int.Parse(Console.ReadLine()!);
int max = a;

if (b > max)
{
    max = b;
}

if (c > max)
{
    max = c;
}

Console.WriteLine($"max-> {max}");

