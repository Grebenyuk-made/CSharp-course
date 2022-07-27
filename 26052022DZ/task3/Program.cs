// В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты
void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
            matr[i, j] = new Random().Next(1, 10);
        Console.WriteLine();
    }
}
void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}
Console.WriteLine("number n,m:");
int n = Convert.ToInt32(Console.ReadLine() ?? "0");
int m = Convert.ToInt32(Console.ReadLine() ?? "0");
int[,] mass = new int[m, n];
FillArray(mass);
Console.WriteLine("Массив: ");
PrintArray(mass);
for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
        if (mass[i,j]%2 == 0)
        {
            mass[i,j] = mass[i,j] * 2;
        }
}
Console.WriteLine("Результат умножения:");
PrintArray(mass);