// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.Clear();
Console.WriteLine("Введите число:");
int m = Convert.ToInt32(Console.ReadLine());

    if (m % 2 == 1)
{
    Console.WriteLine("Число " + m + " является: НЕЧЁТНЫМ");
}
    else
{
    Console.WriteLine("Число " + m + "является: ЧЁТНЫМ");
}
