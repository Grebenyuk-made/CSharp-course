// Подсчитать сумму цифр в числе
Console.Clear();
Console.WriteLine("Введите число :");
int number = Convert.ToInt32(Console.ReadLine());
int result = 0;
for(int i = 0; i <= number; i++) result += number;
Console.WriteLine($"Вы ввели числа {number}:");
Console.WriteLine($"Результат = {result/2}.");