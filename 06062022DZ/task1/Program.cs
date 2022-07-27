// Показать натуральные числа от M до N, N и M заданы
void PrintNumber(int n, int m)
{
    Console.Write("{0} ",  n);
    if (n == m) return;
    if (m > n)
        PrintNumber(n+1,m);
    else 
       PrintNumber(n-1,m);
}
Console.WriteLine("N = ");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("M = ");
int number2 = int.Parse(Console.ReadLine());
PrintNumber(number1, number2);
