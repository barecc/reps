Console.Clear();

Console.WriteLine("Введите день недели: ");
int n = int.Parse(Console.ReadLine());

while (n < 1 || n > 7)
{
    Console.WriteLine("Вы ошиблись!\nВведите день недели: ");
    int m = int.Parse(Console.ReadLine());
}

if (n == 1)
    Console.WriteLine("Понедельник");

else if (n == 2)
    Console.WriteLine("Вторник");

else if (n == 3)
    Console.WriteLine("Cреда");

else if (n == 4)
    Console.WriteLine("Четверг");

else if (n == 5)
    Console.WriteLine("Пятница");

else if (n == 6)
    Console.WriteLine("Суббота");

else
    Console.WriteLine("Воскресенье");