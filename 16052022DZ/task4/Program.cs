// Возведите число А в натуральную степень B используя цикл
Console.WriteLine("Введите число А и В:");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int result = 1;
for(int i = 1; i <= b; i++) 
{
    result *= a;

}
Console.WriteLine($"Вы ввели числа {a} и {b}:");
Console.WriteLine($"Результат = {result}.");