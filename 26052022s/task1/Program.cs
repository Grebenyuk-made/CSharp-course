// Показать двумерный массив размером m×n заполненный целыми числами
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
int n = int.Parse(Console.ReadLine()??"0");
int m = int.Parse(Console.ReadLine()??"0");
int[,] matrix = new int [m,n];
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);
