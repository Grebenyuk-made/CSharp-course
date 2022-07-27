// Определить количество цифр в числе
Console.WriteLine("Введите число : ");
int n = Convert.ToInt32(Console.ReadLine());
int count = 0;
int tn = n;
while(tn > 0)
{
    tn = tn / 10; 
    count++;
} 
Console.WriteLine($"{n} = {count}");
