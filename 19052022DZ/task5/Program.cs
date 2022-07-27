//Найти произведение пар чисел в одномерном массиве. 
//Парой считаем первый и последний элемент, второй и предпоследний и т.д.
int[] CreateArray(int size, int minimum, int maximum)
{
int[] array = new int[size];
Random random = new Random();
for(int i = 0; i< size; i++)
array[i] = random.Next(minimum,maximum);
return array;
}
int[] mass = CreateArray(10,1,100);
Console.Write("Массив: ");
Console.WriteLine("[{0}]" , string.Join(",", mass));
Console.WriteLine(mass[0] * mass[9]);
Console.WriteLine(mass[1] * mass[8]);
Console.WriteLine(mass[2] * mass[7]);
Console.WriteLine(mass[3] * mass[6]);
Console.WriteLine(mass[4] * mass[5]);

