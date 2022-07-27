// В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом
Console.Clear();
Console.WriteLine("");
int[] array = {12, 14, 5, 2, 6, 10};
int max = array[0];
int min = array[0];
foreach( int n in array)
{
    if(n > max)
    {
        max = n;
    }
    if(n < min)
    {
        min = n;
    }
}
Console.WriteLine($"макс из массива = {max}.");
Console.WriteLine($"минимум из массива = {min}.");
Console.WriteLine($"Разница из макс и минимума = {max-min}");

//второе решение
// В массиве вещественных чисел найдите разницу между максимальным и минимальным элементом

double[] arr = new double[10];
for (int i = 0; i < arr.Length; i++)
{
  arr[i] = new Random().NextDouble()*10;
  Console.WriteLine($"{arr[i]} ");  
}
double max = arr[0];
double min = arr[0];

for (int i = 1; i < arr.Length; i++)
{
  if(arr[i] < min) min = arr[i];
  if(arr[i] > max) max = arr[i];
}
Console.WriteLine($"max = {max}");
Console.WriteLine($"min = {min}");

Console.WriteLine($"Разница = {max-min}");
// третий вариант 
// В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом
Console.Clear();
float [] arr = {3.5f, 4.2f,355,4,5555};
float max = arr[1];
float min = arr[0];
for(int i = 0; i < arr.Length; i++)
{
    if(arr[i] > max)
    {
        max = arr[i];
    }
    if(arr[i]< min)
    {
        min = arr[i];
    }
}
Console.WriteLine(max-min);
