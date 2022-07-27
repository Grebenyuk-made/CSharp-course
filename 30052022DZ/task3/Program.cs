//Написать программу, которая в двумерном массиве заменяет строки на столбцы или сообщить,
//что это невозможно (в случае, если матрица не квадратная).
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
int n1 = int.Parse(Console.ReadLine()??"0");
int m1 = int.Parse(Console.ReadLine()??"0");
int[,] mass1 = new int [m1,n1];
FillArray(mass1);
PrintArray(mass1);
Console.WriteLine("Меняем столбцы со строками?");
Console.WriteLine("1)Да. 2)Нет.");
int x = int.Parse(Console.ReadLine());
if(x == 1)
{
    if(n1 > 0 || m1 > 0)
    {
        int n2 = m1;
        int m2 = n1;
        int[,] mass2 = new int [m2,n2];
        FillArray(mass2);
        PrintArray(mass2);
    }
}
if(x == 2)
{
    PrintArray(mass1);
}
if(n1 == 0 || m1 == 0)
{
    Console.WriteLine("массив не двумерный");
}
if(x > 2 || x <= 0)
{
    Console.WriteLine("некорректный выбор");
}