// Показать двумерный массив размером m×n заполненный вещественными числами
void FillArray(double[,] matr)
{
    for(int i = 0; i < matr.GetLength(0); i++)
    {
        for(int j = 0; j < matr.GetLength(1); j++)
            matr[i,j] = new Random().Next(-100,100);
    Console.WriteLine();
    }
}
void PrintArray(double[,] matr)
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
double[,] matrix = new double [m,n];
FillArray(matrix);
Console.WriteLine("Массив: ");
PrintArray(matrix);