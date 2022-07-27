//Вид 3 - Ничего не принимают что то возвращают 
int Method3 ()
{
    return DateTime.Now.Year;
}
int Year = Method3();
Console.WriteLine(Year);