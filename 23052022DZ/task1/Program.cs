// Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы
Console.Clear();
Console.WriteLine("Введите первые координаты: ");
double b1 = Convert.ToInt32(Console.ReadLine());
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите вторые координаты: ");
double b2 = Convert.ToInt32(Console.ReadLine());
double k2 = Convert.ToInt32(Console.ReadLine());
double x = (b2-b1)/(k1-k2);
Console.WriteLine($" X = {x}.");
double y = k1 * (b2-b1) / (k1-k2) + b1;
Console.WriteLine($" Y = {y}.");
Console.WriteLine($"Точка пересечения = ( {x} , {y} ) .");

