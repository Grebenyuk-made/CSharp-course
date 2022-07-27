// for - так же цикл как и while
// пример -- 1
string Method4 (int count, string text)
{
    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}
string res = Method4(10, asdf);

//пример цикла в цикле 
for(int i = 2; i <= 10; i++)
{
    for(int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} * {j} = {i * j}");
    }
}