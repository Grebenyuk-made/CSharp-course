//Написать программу масштабирования фигуры
//Тут для тех кто далеко улетел, чтобы задавались вершины фигуры списком (одной строкой)например: "(0,0) (2,0) (2,2) (0,2)"
//коэффициент масштабирования k задавался отдельно - 2 или 4 или 0.5
//В результате показать координаты, которые получатся.при k = 2 получаем "(0,0) (4,0) (4,4) (0,4)"
// ↓↓↓ первый вариант ↓↓↓
// Console.WriteLine("Укажите размеры вашего квадрата: ");
// Console.Write("Первая координата ");
// int ax = Convert.ToInt32(Console.ReadLine());
// int ay = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Вторая координата ");
// int bx = Convert.ToInt32(Console.ReadLine());
// int by = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Третья координата ");
// int cx = Convert.ToInt32(Console.ReadLine());
// int cy = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Четвёрая координата ");
// int dx = Convert.ToInt32(Console.ReadLine());
// int dy = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("На сколько будем масштабировать фигуру: ");
// int plusSize = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Координаты ({ax},{ay}), ({bx},{by}), ({cx},{cy}), ({dx},{dy}) будут умножены на {plusSize}");
// Console.WriteLine
//($"Увеличенные координаты ({ax * plusSize},{ay * plusSize}), ({bx * plusSize},{by * plusSize}), ({cx * plusSize},{cy * plusSize}), ({dx * plusSize}{dy * plusSize})");
// ↓↓↓ Второй вариант ↓↓↓
Console.WriteLine("Сколько углов у вашей фигуры: ");
int corners = Convert.ToInt32(Console.ReadLine());
int[] mass = new int[corners*2]; 
Console.WriteLine("Первоночальный вид координат: ");
Console.Write("[{0}]" , string.Join(",", mass));
int i = 0;
Console.WriteLine();
while (i < corners*2)
{
    Console.WriteLine("Введите следующую координату: ");
    mass[i] = int.Parse(Console.ReadLine());
    i++;
}
Console.WriteLine("Изначальные координаты фигуры: ");
for (i = 0; i < corners * 2 ; i = i + 1)
    Console.Write("({0})" , string.Join(",()", mass[i]));
Console.WriteLine();
Console.WriteLine("Во сколько раз масштабируем фигуру: ");
int plusSize1 = Convert.ToInt32(Console.ReadLine());
 Console.WriteLine("Итоговые координаты фигуры: ");
for (i = 0; i < corners * 2 ; i = i + 1)
    Console.Write("({0})" , string.Join(",()", (mass[i] * plusSize1)));
