// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.Clear();
Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine());
int k = (int)Math.Log10(n)-2;
Console.WriteLine(k < 0 ? "Только 2 знака" : (n % (int)Math.Pow(10, k + 1) / (int)Math.Pow(10, k)).ToString());
Console.ReadLine();

