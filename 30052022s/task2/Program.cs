// Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.
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
            Console.Write($"{matr[i, j]} ");
    Console.WriteLine();
    }
}
double MeanAriphm(int[,] matr, int column)
{
    double sum = 0;
    for(int i = 0; i < matr.GetLength(0); i++)
        sum = sum + matr[i, column];
    return sum / matr.GetLength(0); 
}
Console.Clear();
Console.WriteLine("Введите количество строк и столцов:");
int n = int.Parse(Console.ReadLine() ?? "0");
int k = int.Parse(Console.ReadLine() ?? "0");
int[,] matrix = new int[n, k];
FillArray(matrix);
Console.WriteLine("Полученый массив:");
PrintArray(matrix);
for(int j = 0; j <k; j++)
    Console.WriteLine($"Среднее арифметическое Столбца {j + 1} = {MeanAriphm(matrix, j)}");