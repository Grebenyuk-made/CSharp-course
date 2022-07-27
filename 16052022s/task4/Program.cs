// Написать программу вычисления произведения чисел от 1 до N
Console.WriteLine("Введите число : ");
int n = Convert.ToInt32(Console.ReadLine());
int mult = 1;
for (int i = 1; i <= n; i++ )
{
    mult *= i;
}                            
Console.WriteLine($"Сумма чисел {n} = {mult}");