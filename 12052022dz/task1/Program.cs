// Дано число обозначающее день недели. Выяснить является номер дня недели выходным
Console.WriteLine("Введите номер дня: ");
int day = Convert.ToInt32(Console.ReadLine());
int monday  = 1;
int tuesday = 2;
int wednesday = 3;
int thursday = 4;
int friday = 5;
int saturday = 6;
int sunday = 7;
if (day == monday || day == tuesday || day == wednesday || day == thursday || day == friday)
{
    Console.WriteLine("Сегодня рабочий день, продолжаем работать!");
}
if (day == saturday || day == sunday )
{
    Console.WriteLine("Сегодня можно не работать!");
}
