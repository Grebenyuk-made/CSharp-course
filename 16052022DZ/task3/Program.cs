//Найти сумму чисел от 1 до А
Console.Clear();
Console.Write("Укажите число для получения суммы от 1 - : ");
int n = Convert.ToInt32(Console.ReadLine());
int result = 0;
for(int i = 0; i <= n; i++) result = result + i;    
Console.WriteLine($"Сумма чисел {n} = {result}.");