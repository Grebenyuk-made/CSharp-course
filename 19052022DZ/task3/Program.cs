// Задать массив, заполнить случайными положительными трёхзначными числами. 
//Показать количество нечетных\четных чисел.
int[] CreateArray(int size, int minimum, int maximum)
{
    int[] array = new int[size];
    Random random = new Random();
    for(int i = 0; i< size; i++)
        array[i] = random.Next(minimum,maximum);
    return array;
}
int[] mass = CreateArray(10,99,1000);
Console.WriteLine("[{0}]", string.Join(", ", mass));
int result  = mass.Count(n => n % 2 == 0);
Console.WriteLine($"Количество чётных чисел: {result}");
Console.WriteLine($"Количество нечетных чисел: " + (mass.Length - result));

