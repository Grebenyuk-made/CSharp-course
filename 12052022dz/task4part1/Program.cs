//Найти расстояние между точками в пространстве 2D/3D
// Part 1 -- 2D
Console.WriteLine("Введите координаты для первой точки: "); 
double pfx = Convert.ToInt32(Console.ReadLine());
double pfy = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты для второй точки: "); 
double psx = Convert.ToInt32(Console.ReadLine());
double psy = Convert.ToInt32(Console.ReadLine());
//формула по нахождению расстояния ммежду двумя точками √((х А – х В)^2 + (у А – у В)^2)
double result = ((pfx - psx)*(pfx - psx)) + ((pfy - psy)*(pfy - psy));
double finalresult  = Math.Sqrt(result);
Console.WriteLine($"Расстояние между первой точкой {pfx}.{pfy} и второй точкой {psx}.{psy} = {finalresult}.");