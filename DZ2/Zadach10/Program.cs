// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.


Console.Clear();
Console.WriteLine("Введите первое число: ");
int x = Convert.ToInt32(Console.ReadLine());
int x1 = (x / 10);
int x2 = (x1 % 10);
Console.WriteLine(x2);