// В двумерном массиве целых чисел. Удалить строку и столбец, на пересечении которых расположен наименьший элемент.
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
int[] FindMinInSquareArray(int[,]mass)
{
    int min = mass[0, 0];
    int[] indX2 = new int[2];
    for(int i = 0; i < mass.GetLength(0); i++)
    {
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            if (mass[i, j] < min)
            {   
                min = mass[i, j];
                indX2[0] = i;
                indX2[1] = j; 
                Console.WriteLine($"(min = {min})");
            }
        }
        
    }
return indX2;
}
int[,] СuttingСolumnsАndLines(int[,]mass,int line, int column)
{
    int[,] newMass = new int[mass.GetLength(0) - 1, mass.GetLength(1) - 1];
    for (int i = 0; i < mass.GetLength(0) - 1; i++)
    {
        for (int j = 0; j < mass.GetLength(1) - 1; j++)
        {
            if (i >= line || j < column)
                newMass[i, j] = mass[i + 1, j];
            if (j >= column || i < line)
                newMass[i, j] = mass[i, j + 1];
            if (i >= line || j >= column)
                newMass[i, j] = mass[i + 1, j + 1];
            else
                newMass[i, j] = mass[i, j];
        }
    }
    return newMass;
}

Console.Clear();
Console.WriteLine("Введите количество строк и столцов:");
int line = int.Parse(Console.ReadLine() ?? "0"); 
int column = int.Parse(Console.ReadLine() ?? "0");  
int[,] mass = new int[line, column];
FillArray(mass);
Console.WriteLine("Полученый массив:");
PrintArray(mass);
Console.WriteLine();
Console.WriteLine($"Номер строки и значение минимума = {FindMinInSquareArray(mass)[0]+1}");
Console.WriteLine($"Номер столбца и значение минимума = {FindMinInSquareArray(mass)[1]+1}");
Console.WriteLine();
PrintArray(СuttingСolumnsАndLines(mass, FindMinInSquareArray(mass)[0], FindMinInSquareArray(mass)[1]));