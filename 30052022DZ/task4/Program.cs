//В прямоугольной матрице найти строку с наименьшей суммой элементов.
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
Console.Clear();
Console.WriteLine("Введите количество строк и столцов:");
int n = int.Parse(Console.ReadLine() ?? "0"); //строки
int k = int.Parse(Console.ReadLine() ?? "0"); //столбцы 
int[,] mass = new int[n, k];
FillArray(mass);
Console.WriteLine("Полученый массив:");
PrintArray(mass);
for (int i = 0; i < mass.GetLength(0); i++)
{
    {
        int sum = 0;
        for (int j = 0; j < mass.GetLength(1); j++) 
        {
            sum += mass[i, j];
        }
        Console.WriteLine("Сумма строки = ");
        Console.WriteLine(sum + " ");
    }
}