//Задать массив из 8 элементов и вывести их на экран
//Задать массив из 8 элементов и вывести их на экран
// Console.WriteLine("test");
// void FillArray(int[] collection) // any name
// {
//     int length = collection.Length;
//     int index = 0;
//     while(index < length)
//     {
//         collection[index] = Convert.ToInt32(Console.ReadLine());
//         index++;
//     }
// }

// int[] array = new int[8];
// FillArray(array);
// int index = 0;
// int size = array.Length;
// while(index < size)
// {
// Console.Write(array[index]);
// index++;
// }
Console.WriteLine("Задать массив из 8 элементов и вывести их на экран");
Console.Write("Введите размер массива: ");
int arrSize =  int.Parse(Console.ReadLine() ?? "0");

int[] array = new int[arrSize];

for (int i=0; i<arrSize; i++)
    array[i] =  new Random().Next(0,100);

int count = 1;

foreach (int k in array)
{
    Console.WriteLine($"{count} элемент массива - {k}");
    count++;
}
