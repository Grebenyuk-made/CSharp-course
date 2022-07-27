//Показать натуральные числа от N до 1, N задано
Console.WriteLine("N = ");
int number = int.Parse(Console.ReadLine());
void Recursion(int n)
{
    if (n > 0)
    {
        Console.Write("{0} ",  n);
        Recursion(n - 1);
    }
}
Recursion(number);
Console.WriteLine(number);

void PrintNumber(int n)
{
    Console.Write(n + " ");
    n--;
    if(n == 0) return;
    PrintNumber(n);
}

int N = 20;

PrintNumber(N);
