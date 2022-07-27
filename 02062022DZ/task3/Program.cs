// Сформировать трехмерный массив не повторяющимися двузначными числами показать его 
// построчно на экран выводя индексы соответствующего элемента
void PrintArray3D(int[,,] mass)
{
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        Console.WriteLine("Page №: " + (i + 1));
        Console.WriteLine();
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            Console.WriteLine("Line №: " + (j + 1));
            Console.WriteLine();
            for (int k = 0; k < mass.GetLength(2); k++)
                {
                Console.Write(mass[i, j, k] + " ");
                }
            Console.WriteLine();
        }
        Console.WriteLine("////////////////////////////");
    }
}
void CreateMass3D(int[,,] mass)
{
    int number = 10;
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            for (int k = 0; k < mass.GetLength(2); k++)
            {
                mass[i, j, k] =  number;
                number += 1;
            }
        }
    }
}
Console.WriteLine("page = ?, line = ?, column = ?");
int page = int.Parse(Console.ReadLine() ?? "0");
int line = int.Parse(Console.ReadLine() ?? "0");
int column = int.Parse(Console.ReadLine() ?? "0");
int[,,] mass = new int[page, line, column];
CreateMass3D(mass);
PrintArray3D(mass);