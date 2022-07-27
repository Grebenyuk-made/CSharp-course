// Создание массива исходных чисел 
// Основная задача 
// Печать массива 

int[] CreateArray(int count)
{
    return new int[count];
}
void FillArray(int[] inputArray)
{
    int len = inputArray.Length;
    var r = new Random();  
    for(int i = 0; i < len; i++)
    {
        inputArray[i]= r.Next(10);
    }
}
int[] MainExample(int[] inputArray)
{
    int count = inputArray.Length;
    int[] outputArray = new int[count];
    int index = 0;
    int i = 0;
    while(i < count)
    {
        if (inputArray[i] % 2 == 0)
        {
            outputArray[index] = inputArray[i];
            index++;
        }
        i++;
    }
    Array.Resize(ref outputArray, index);
    return outputArray;
}
string PrintArray(int[] array)
{
    string txt = string.Empty;
    int len = array.Length;
    for(int i = 0; i < len; i++)
    {
        txt += $"{array[i]} ";
    }
    return $"[{txt}] ";
}
Console.WriteLine(":");
int len = Convert.ToInt32(Console.ReadLine());
int[] numbers = CreateArray(len);
FillArray(numbers);
Console.WriteLine($"numbers: {PrintArray(numbers)}");
int[] outnumbers = MainExample(numbers);
Console.WriteLine($"outnumbers: {PrintArray(outnumbers)}");