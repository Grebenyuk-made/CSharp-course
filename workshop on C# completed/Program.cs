// int[] array1 = { 1, 2, 3, 12, 31, 4, 44, 5, 324 };

// for (int qwert = 0; qwert < array1.Length; qwert++)
// {
//     if (array1[qwert] % 2 == 0)
//         Console.Write($"{array1[qwert]} ");
// }

// 1 до 10

int GetValue(string text)
{
    int value;
    bool check;
    do
    {
        Console.Write($"{text}: ");
        check = int.TryParse(Console.ReadLine(), out value);
    } while (!check || !(value >= 1 && value <= 10));
    return value;
}


var v = GetValue("Вводите число от 1 до 10");
Console.WriteLine($"10*v {10 * v}");







// // Создание массива исходных чисел
// // Основная задача
// // Печать массива


// int[] CreateArray(int count)
// {
//     return new int[count];
// }

// void FillArray(int[] inputArray)
// {
//     int len = inputArray.Length;

//     for (int i = 0; i < len; i++)
//     {
//         inputArray[i] = new Random().Next(-10, 10);
//     }
// }

// int[] MainExample(int[] inputArray)
// {
//     int count = inputArray.Length;
//     int index = 0;
//     int i = 0;

//     while (i < count)
//     {
//         if (inputArray[i] % 2 == 0)
//         {
//             index += 1;
//         }
//         i += 1;
//     }

//     int[] outputArray = new int[index];
//     count = inputArray.Length;
//     index = 0;
//     i = 0;
//     while (i < count)
//     {
//         if (inputArray[i] % 2 == 0)
//         {
//             outputArray[index] = inputArray[i];
//             index += 1;
//         }
//         i += 1;
//     }

//     // Array.Resize(ref outputArray, index);
//     return outputArray;
// }

// string PrintArray(int[] array)
// {
//     string txt = String.Empty;
//     int len = array.Length;
//     for (int i = 0; i < len; i++)
//     {
//         //Console.WriteLine($"{array[i]}");
//         txt += $"{array[i]} ";
//     }
//     return $"[{txt}]";
// }

// Console.Write($"Количество элементов: ");
// int len = Convert.ToInt32(Console.ReadLine());
// int[] numbers = CreateArray(len);
// FillArray(numbers);
// Console.WriteLine($"numbers: {PrintArray(numbers)}");
// int[] outnumbers = MainExample(numbers);
// Console.WriteLine($"outnumbers: {PrintArray(outnumbers)}");