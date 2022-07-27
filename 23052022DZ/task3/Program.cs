// Написать программу копирования массива
int[] CreateArray(int size, int minimum, int maximum)
{
    int[] array = new int[size];
    Random random = new Random();
    for (int i = 0; i < size; i++)
        array[i] = random.Next(minimum, maximum);
    return array;
}
int[] mass1 = CreateArray(10, 1, 100);
Console.WriteLine("Первый массив: ");
Console.WriteLine("[{0}]", string.Join(",", mass1));
int[] mass2 = new int[10];
Console.WriteLine("Второй нулевой массив: ");
Console.WriteLine("[{0}]", string.Join(",", mass2));
Array.Copy(mass1, mass2 = new int[mass1.Length], mass1.Length);
Console.WriteLine("Второй заполненый массив: ");
Console.WriteLine("[{0}]", string.Join(",", mass2));