Console.Clear();
 Console.WriteLine("Введите X: ");
 double x = Convert.ToDouble(Console.ReadLine());
 Console.WriteLine("Введите Y: ");
 double y = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите X1: ");
 double x1 = Convert.ToDouble(Console.ReadLine());
 Console.WriteLine("Введите Y1: ");
 double y1 = Convert.ToDouble(Console.ReadLine());
 double dist = Math.Sqrt(Math.Pow(x - x1, 2) + Math.Pow(y - y1, 2));

 Console.WriteLine(Math.Round(dist, 2));

    