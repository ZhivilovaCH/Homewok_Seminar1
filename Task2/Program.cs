// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Clear();
Console.WriteLine("Введите число А: ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число B: ");
int b = int.Parse(Console.ReadLine()!);

if (a > b)
{
    Console.WriteLine("max-> A "+  a);
}
else if (b > a)
{
    Console.WriteLine("max->B " + b);
}
else if (b == a)
{
    Console.WriteLine("значения равны");
}

