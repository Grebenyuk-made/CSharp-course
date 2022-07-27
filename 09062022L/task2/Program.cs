//Написать программу возведения числа А в целую стень B
int Degree (int number1, int number2)
{
    if(number2 == 1) return 1;
    if(number2 <= 1) return number1;
    return number1 * Pow(number1, number2-1);

}
Console.WriteLine("Which number?");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Which degree?");
int number2 = int.Parse(Console.ReadLine());
Console.Write($"Result = {Degree(number1, number2)}");
