// Показать таблицу квадратов чисел от 1 до N
Console.Clear();
Console.Write("Укажите диапозон таблицы квадратов чисел от 1 - : ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine($"Таблица квадратов числа от 1 - {n}.");
Console.WriteLine("Число" + "\t" + "Квадрат");
for(int i = 1; i <= n; i++)
    Console.WriteLine(i + "\t" + i*i);
