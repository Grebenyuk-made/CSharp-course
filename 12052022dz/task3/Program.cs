// Задать номер четверти, показать диапазоны для возможных координат
Console.WriteLine("Введите номер четверти: ");
int number = Convert.ToInt32(Console.ReadLine()?? "0");
string xplus = ("от 0 до бесконечности по оси X");
string xminus = ("от 0 до -бесконечности по оси X");
string yplus = ("от 0 до бесконечности по оси Y");
string yminus = ("от 0 до -бесконечности по оси Y");
if(number == 1) Console.WriteLine($"Диапазоны возможных координат от {number} = {xplus} и {yplus} .");
if(number == 2) Console.WriteLine($"Диапазоны возможных координат от {number} = {xplus} и {yminus} .");
if(number == 3) Console.WriteLine($"Диапазоны возможных координат от {number} = {xminus} и {yplus} .");
if(number == 4) Console.WriteLine($"Диапазоны возможных координат от {number} = {xplus} и {yplus} .");
else if (number > 4 || number < 0) Console.WriteLine($"Диапазоны возможных координат от {number} = 0 .");
