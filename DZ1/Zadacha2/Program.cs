﻿// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.Clear();
Console.WriteLine("Введите первое число: ");

int a = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите второе число: ");

int b = Convert.ToInt32(Console.ReadLine());

 if (a > b)
{
    Console.WriteLine("Первое число " + a + " больше чем второе " + b);
}
if (a == b)
{
    Console.WriteLine("Первое число " + a + " Равно второму " + b);
}
else
{
    Console.WriteLine("Второе число " + b + " больше чем первое " + a);
}



