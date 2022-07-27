//Написать программу, которая обменивает элементы первой строки и последней строки
int[] CreateArray(int size, int minimum, int maximum)
{
int[] array = new int[size];
Random random = new Random();
for(int i = 0; i< size; i++)
array[i] = random.Next(minimum,maximum);
return array;
}
void SwitchElements(int[] mass)
{
    for (int i = 0; i < mass.Length/2; i++)
    {
        int number = mass[0];
        mass[i] = mass[mass.Length - i-1];
        mass[mass.Length - i-1] = number;
        return;
    }
}
Console.WriteLine("Размер массива: ");
int size = int.Parse(Console.ReadLine() ?? "0");
int[] mass = CreateArray(size,1,1000);
Console.WriteLine("Массив: ");
Console.Write("[{0}]" , string.Join(",", mass));
SwitchElements(mass);
Console.WriteLine();
Console.WriteLine("Массив исправленый: ");
Console.Write("[{0}]" , string.Join(",", mass));