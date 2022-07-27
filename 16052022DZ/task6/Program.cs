// Показать кубы чисел, заканчивающихся на четную цифру
Console.Clear();
Console.Write("Укажите диапозон таблицы кубов чисел от 1 - : ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Таблица кубов числа от 1 - {n}."+ "\t" + "Чётные кубы = ");
for(int i = 0; i <= n; i++)
    if(i % 2 != 1)Console.WriteLine(i*i*i);

