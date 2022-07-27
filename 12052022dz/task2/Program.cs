// По двум заданным числам проверять является ли одно квадратом другого
Console.WriteLine("Введите пару чисел: ");
int n1 = Convert.ToInt32(Console.ReadLine()?? "0");
int n2 = Convert.ToInt32(Console.ReadLine()?? "0");
double sum1 = (double)n1 / n2;
int sum2 = n1 / n2;
if (sum1 == sum2)
{
Console.WriteLine($"Да, число {n1} является квадратом {n2} результат {sum1}");
}
else
{
  Console.WriteLine($"Нет, число {n1} не является квадратом {n2} результат {sum1}");  
}
