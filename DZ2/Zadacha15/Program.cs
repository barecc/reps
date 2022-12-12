// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Clear();
Console.WriteLine("Введите день недели: ");
int n = int.Parse(Console.ReadLine());

while (n < 1 || n > 7)
{
 Console.WriteLine("Вы ошиблись!\nВведите день недели: ");
    int m = int.Parse(Console.ReadLine());
}

if (n < 6)
    Console.WriteLine("Будний день");
else
    Console.WriteLine("Выходной");