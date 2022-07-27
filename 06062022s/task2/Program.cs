// Показать натуральные числа от 1 до N, N задано
Console.Clear();
Console.WriteLine("N = ");
int number = int.Parse(Console.ReadLine());
void PrintNumbersRecursion(int n)
{
    if (n < 1)return;
    {
        PrintNumbersRecursion(n - 1);
        Console.Write(n + " ");
    }
}
PrintNumbersRecursion(number);
