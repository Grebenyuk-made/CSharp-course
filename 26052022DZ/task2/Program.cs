// Задать двумерный массив следующим правилом: Aₘₙ = m+n
void FillArray(int[,] matr)
{
    for(int i = 0; i < matr.GetLength(0); i++)
    {
        for(int j = 0; j < matr.GetLength(1); j++)
            matr[i,j] = new Random().Next(1,10);
    Console.WriteLine();
    }
}
void PrintArray(int[,] matr)
{
    for(int i = 0; i < matr.GetLength(0); i++)
    {
        for(int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
    Console.WriteLine();
    }
}
Console.WriteLine("number n,m:");
int n = Convert.ToInt32(Console.ReadLine()??"0");
int m = Convert.ToInt32(Console.ReadLine()??"0");
int [,] mass = new int [m,n];
FillArray(mass);
PrintArray(mass);
int count=1;
for (int i = 0; i < n; i++)
{
    count = 1;
    for (int j = 0; j < m; j++)
    {
        if ((count + i) != 10) mass[i, j] = (count + i) % m;
        else mass[i, j] = (count + i);
        count++;
    }
}
Console.WriteLine("исходный массив:");
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        Console.Write(mass[i, j] + " ");
    }
    Console.WriteLine();
}