// Написать программу, упорядочивания по убыванию элементы каждой строки двумерной массива.
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
Console.WriteLine("сколько столбцов = n, строк = m:");
int n = int.Parse(Console.ReadLine()??"0");
int m = int.Parse(Console.ReadLine()??"0");
int[,] mass = new int [m,n]; 
FillArray(mass);
Console.WriteLine();
PrintArray(mass);
for (int i = 0; i < mass.GetLength(0); i++)
{
    int max = 0;
    for (int j = 0; j < mass.GetLength(1); j++) 
    {
        if (max < mass[i,j]) 
        {
            max = mass[i,j];
        }
    }
    Console.WriteLine("max = ");
    Console.WriteLine(max + " ");
}
for (var i = 0; i < mass.GetLength(0); i++)
    for (var j = 0; j < mass.GetLength(1); j++)
    {
    for (var k = 0; k < mass.GetLength(1); k++)
        {
        if (mass[i, j] <= mass[i, k]) continue;
            var temp = mass[i, j];
            mass[i, j] = mass[i, k];
            mass[i, k] = temp;
        }
    }
PrintArray(mass);