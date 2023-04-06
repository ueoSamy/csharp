// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу,
// которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

using System.Threading.Channels;

int[] array = new int[] { 9, 15, 37, 44, 12, 20 };

int EvenNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
            count++;
    }

    return count;
}

Console.WriteLine($"Заданный массив: [{string.Join(", ", array)}]");
int result = EvenNumbers(array);
Console.WriteLine($"Количество четных чисел в массиве = {result}");

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов,
// стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
int[] user_array = new int[7];

void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 100);
    }
}

InputArray(user_array);
Console.WriteLine($"Полученный массив: [{string.Join(", ", array)}]");

int EvenNumbersOnOddIdx(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 == 1)
            Console.WriteLine($"{array[i]}");
        result += array[i];
    }

    return result;
}

Console.WriteLine($"Сумма элементов,стоящих на нечётных позициях = {EvenNumbersOnOddIdx(array)}");


#region Задача 38

void PrintArray(int[] array)
{
    Console.WriteLine($"[{string.Join(", ", array)}]");
}

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
int[] arrayMaxMini = new int[10];
InputArray(arrayMaxMini);
PrintArray(arrayMaxMini);

int MinElem(int[] array)
{
    int minNum = array[0];
    foreach (int element in array)
    {
        if (element < minNum)
            minNum = element;
    }

    return minNum;
}

int MaxElem(int[] array)
{
    int maxNum = array[0];
    foreach (int element in array)
    {
        if (element > maxNum)
            maxNum = element;
    }

    return maxNum;
}

Console.WriteLine($"Разницу между максимальным и минимальным элементов массива = " +
                  $"{MaxElem(arrayMaxMini) - MinElem(arrayMaxMini)}");
#endregion