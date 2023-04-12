// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
Console.Write("Введите размер массив через пробел: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
double[,] myArray = new double[size[0], size[1]];

void FillArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().NextDouble() * 10;
        }
    }
}

void PrintArray(double[,] array)
{
    foreach (double element in array)
    {
        Console.Write($"{element:f2} ");
    }
}
FillArray(myArray);
PrintArray(myArray);


// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
Console.Write("Введите размер массив через пробел: ");
int[] sizeS = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] myArrayS = new int[size[0], size[1]];

void FillArrayS(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 20);
        }
    }
}
void PrintArray1(int[,] array)
{
    foreach (int element in array)
    {
        Console.WriteLine($"{element} ");
    }
}

void PrintArrayS(int[,] array, int row, int col)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == row && j == col)
                Console.Write($"{array[row, col]}");
            else
            {
                Console.WriteLine("Данного элемента не существует");
            }
        }
    }
}
FillArrayS(myArrayS);
PrintArray1(myArrayS);
Console.WriteLine();
PrintArrayS(myArrayS,1, 1);


// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[] sizeOf = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] myArrayOf = new int[sizeOf[0], sizeOf[1]];

void FillArrayOf(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 20);
        }
    }
}

FillArrayOf(myArrayOf);
void PrintArrayOf(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} \t");
        }
        
        Console.WriteLine();
    }
}
PrintArrayOf(myArrayOf);

void GetElement(int[,] array)
{
    double summArr = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            summArr += array[j, i];
        }

        summArr = summArr / array.GetLength(1);
        Console.WriteLine($"Среднее арифметическое элементов на {i + 1} столбце = {summArr:f2}");
        summArr = 0;
    }
}

GetElement(myArrayOf);