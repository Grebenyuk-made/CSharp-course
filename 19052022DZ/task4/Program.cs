// В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]
int[] CreateArray(int size, int minimum, int maximum)
{
    int[] array = new int[size];
    Random random = new Random();
    for(int i = 0; i< size; i++)
        array[i] = random.Next(minimum,maximum);
    return array;
}
int[] mass = CreateArray(123,1,1000);
Console.WriteLine("Массив: ");
Console.WriteLine("[{0}]" , string.Join(",", mass));
int result = 0;
for (int i = 0; i < 123; i++)
    if (i < 99 || i > 10 )
        result = result + mass[i];
Console.WriteLine($"Количество Элементов из отрезка = {result}.");