// Найти сумму чисел от 1 до А
Console.WriteLine("Введите число : ");
int n = Convert.ToInt32(Console.ReadLine());
int sum = 0;
for (int i = 0; i <= n; i++ )
{
    sum = sum + i;
}                            
Console.WriteLine($"Сумма чисел {n} = {sum}");