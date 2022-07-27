// Найти сумму цифр числа
Console.Clear();
int SumOfDigits(int number)
{
    Console.WriteLine($"{number} ({number%10}).");
    if (number < 1) return number;
    else return number%10 + SumOfDigits(number / 10);
}
Console.WriteLine("N = ");
int number = int.Parse(Console.ReadLine());
Console.WriteLine($"Summa = {SumOfDigits(number)}." );

// второе решение 
uint SumDigits(uint n) => n<10 ? n : n%10 + SumDigits(n/10);
Console.Write("Enter your number: ");
uint n = uint.Parse(Console.ReadLine() ?? "0");
Console.WriteLine($"Sum of digits {SumDigits(n)}");

