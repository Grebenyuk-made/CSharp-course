// Найти сумму чисел одномерного массива стоящих на нечетной позиции
// Console.Clear();
// Console.WriteLine("");
// int[] array = {12, 14, 5, 2, 6, 10};
// int result = 0;
// int length = array.Length;
// for (int i = 0; i < length; i++)
// {
//     if (i % 2 != 0)
//     {
//         result = result + array[i];
//     }
// }
// Console.WriteLine(result);

//^первое решение^
//второе решение
Console.Clear();
Console.WriteLine("");
int[] array = {12, 14, 5, 2, 6, 10};
int result = 0;
int length = array.Length;
for (int i = 0; i < length; i++)
{
    if (i % 2 != 0)
    {
        result = result + array[i];
    }
}
Console.WriteLine(result);
