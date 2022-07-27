// Найти сумму элементов от M до N, N и M заданы
int SumNumbers(int[] mass, int i = 0)
{
    if(i >= mass.Length)
        return 0; 
    int result = SumNumbers(mass, i + 1);
    return mass[i] + result; 
}
Console.Clear();
Console.WriteLine("Введите диапозон чисел от N до M: ");
int start = int.Parse(Console.ReadLine()?? "0");
int end = int.Parse(Console.ReadLine()?? "0");
int size = 0;
int[] mass = new int[(end-start)+1];
Console.WriteLine($":{mass}");
int count = 0;
for (int i = start; i <= end; i++)
{
    if (count < mass.Length)
    {
        mass[count] = i;
        count++;
    }
    else
        break;
}
for (int i = 0; i < mass.Length; i++)
    Console.Write(mass[i] + " ");
int result = SumNumbers(mass);
Console.WriteLine($"Сумма = {result}");