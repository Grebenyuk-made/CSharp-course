// // Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран
Console.Clear();
int[] mass = new int[8];
Random r = new Random();
Console.WriteLine(mass);
for (int x = 0; x < mass.Length; x++)
{
mass[x] = r.Next(0,2);
Console.WriteLine("Значение элемента массива " + x + " = " + mass[x]);
}