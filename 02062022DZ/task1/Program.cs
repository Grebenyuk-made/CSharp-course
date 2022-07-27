// Найти произведение двух матриц
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
int n1 = int.Parse(Console.ReadLine() ?? "0"); 
int m1 = int.Parse(Console.ReadLine() ?? "0");  
int[,] mass1 = new int[n1, m1];
FillArray(mass1);
Console.WriteLine("Полученый массив:");
PrintArray(mass1);
Console.WriteLine("Введите количество строк и столцов во втором массиве:");
int n2 = int.Parse(Console.ReadLine() ?? "0"); 
int m2 = int.Parse(Console.ReadLine() ?? "0");  
int[,] mass2 = new int[n2, m2];
FillArray(mass2);
Console.WriteLine("Полученый массив:");
PrintArray(mass2);
if(n1 == n2 || m1 == m2)
{
    Console.WriteLine("Результат:");
    for (int i = 0; i < mass2.GetLength(0); i++)
    {
        for (int j = 0; j < mass2.GetLength(1); j++)
        {
            Console.Write(" {0,2} ", mass1[i, j] * mass2[i, j]);
        }
    Console.WriteLine();
    }
}
else
    Console.WriteLine("Из-за разных размеров массивов умножение невозможно!");
