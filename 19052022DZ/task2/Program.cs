//Задать массив из 12 элементов, заполненных числами из [-9,9].
//Найти сумму положительных/отрицательных элементов массива.
//Console.Clear();
int[] mass = new int[12];
Random rand = new Random(); 
int sumPlus = 0;
int sumMinus = 0;
for (int i = 0; i < 12; i++)
{
mass[i] = rand.Next(-9, 9);
}
Console.WriteLine("Только отрицательные числа: ");
foreach (var number in mass)
{
    if (number < 0)
    {
    Console.Write(" " + number);
    sumMinus += number;
    } 
}
Console.WriteLine();
Console.WriteLine("Только положительные числа: ");
foreach (var number in mass)
{
    if (number > 0)
    {
    Console.Write(" " + number);
    sumPlus += number;
    }
}
Console.WriteLine();
Console.WriteLine(sumMinus);
Console.WriteLine(sumPlus);  
