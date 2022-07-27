﻿//В двумерном массиве показать позицию числа, заданного пользователем или указать, что такого элемента нет
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
void FindNumber (int[,] matr, int find)
{
    int check = 0;
    for(int i = 0; i < matr.GetLength(0); i++)
    {
        for(int j = 0; j < matr.GetLength(1); j++)
        {
            if(matr[i,j] == find)
            {
                Console.WriteLine($"{find} {i+1} {j+1}");
                check = 1;
            }
        }
    }
if(check == 0) Console.Writeline($"{find}");
}
Console.Clear();
Console.WriteLine("number n,m:");
int n = int.Parse(Console.ReadLine()??"0");
int m = int.Parse(Console.ReadLine()??"0");
Console.WriteLine("find number:");
int x = int.Parse(Console.ReadLine()??"0");
int[,] matrix = new int [m,n];

//В двумерном массиве показать позицию числа, заданного пользователем или указать, что такого элемента нет

void FillArray(int[,] array)
{
    Random rnd           = new Random();
    int    rowsLength    = array.GetLength(0);
    int    columnsLength = array.GetLength(1);
    for (int i = 0; i < rowsLength; i++)
    {
        for (int j = 0; j < columnsLength; j++)
        {
            array[i,j] = rnd.Next(0,2);
        }       
    }
}
//--------------------------------------------------------------------------------------------+
void SearchElement(int[,] array, int number)
{
    int    rowsLength    = array.GetLength(0);
    int    columnsLength = array.GetLength(1);
    bool   found         = false;
    for (int i = 0; i < rowsLength; i++)
    {
        for (int j = 0; j < columnsLength; j++)
        {
            if(array[i,j] == number)
            {
             Console.WriteLine($"Элемент {number} находится на позиции [{i},{j}]");
             found = true;
            }
        }       
    }
    if(!found) Console.WriteLine($"Элемент {number} не найден в массиве!");
}
//--------------------------------------------------------------------------------------------+
void PrintArray(int[,] array)
{
    int    rowsLength    = array.GetLength(0);
    int    columnsLength = array.GetLength(1);
    for (int i = 0; i < rowsLength; i++)
    {
        for (int j = 0; j < columnsLength; j++)
        {
            Console.Write(array[i,j] + " ");
        } 
        Console.WriteLine();      
    }

}
//--------------------------------------------------------------------------------------------+
Console.Clear();
Console.Write("Введите количество строк в массиве: ");
int rows = int.Parse(Console.ReadLine()?? "");
Console.Write("Введите количество столбцов в массиве: ");
int columns = int.Parse(Console.ReadLine()?? "");
Console.Write("Введите число для поиска в массиве: ");
int number = int.Parse(Console.ReadLine()?? "");

int[,] array = new int[rows,columns];

FillArray(array);
PrintArray(array);
SearchElement(array,number);