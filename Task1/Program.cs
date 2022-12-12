
Console.Clear();
Console.WriteLine("Введите первое число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число число: ");
int m = Convert.ToInt32(Console.ReadLine());
if (n % m ==0)
    Console.WriteLine("Кратно");
else
    Console.WriteLine($"Не Кратно, остаток {n % m} ");


