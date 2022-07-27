// //Найти расстояние между точками в пространстве 2D/3D
// Part 2 -- 3D
Console.WriteLine("Введите координаты для первой точки(x,y,z): "); 
double pfx = Convert.ToInt32(Console.ReadLine());
double pfy = Convert.ToInt32(Console.ReadLine());
double pfz = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты для второй точки(x,y,z): "); 
double psx = Convert.ToInt32(Console.ReadLine());
double psy = Convert.ToInt32(Console.ReadLine());
double psz = Convert.ToInt32(Console.ReadLine());
//формула по нахождению расстояния ммежду двумя точками √((х А – х В)^2 + (у А – у В)^2+ (z А – z В)^2)
double result = ((pfx - psx)*(pfx - psx)) + ((pfy - psy)*(pfy - psy)) + ((pfz - psz)*(pfz - psz));
double finalresult  = Math.Sqrt(result);
Console.WriteLine($"Расстояние между 1-ой точкой {pfx}.{pfy}.{pfx} и 2-ой точкой {psx}.{psy}.{psz} = {finalresult}.");