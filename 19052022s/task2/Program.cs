//Определить, присутствует ли в заданном массиве, некоторое число
Console.Clear();
Console.WriteLine("Определить, присутствует ли в заданном массиве, некоторое число");
Console.Write("Введите размер массива: ");
int arrSize =  int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите заданное число: ");
int Number =  int.Parse(Console.ReadLine() ?? "0");

int[] array = new int[arrSize];
bool has = true;

Console.WriteLine("Массив: ");
for (int i=0; i<arrSize; i++)
{
    array[i] =  new Random().Next(1,10);
    Console.Write($"{array[i]} ");
}

Console.WriteLine("");

foreach (int k in array)
    if (k == Number)
         has = false;

if (has)
    Console.WriteLine($"Число {Number} НЕ присутствует в массиве");
else
    Console.WriteLine($"Число {Number} присутствует в массиве");

