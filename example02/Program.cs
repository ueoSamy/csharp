#region ЗАДАЧА-10
// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1
Console.WriteLine("Введите 3х значное число: ");
int number = new Random().Next(100, 1000);
Console.WriteLine($"Веденное число: {number}");
number = (number / 10) % 10;
Console.WriteLine($"Второе число: {number}");

int my_func(int x) {
    result = (x / 10) % 10;
    return result;
}

int number = new Random().Next(100, 1000);
my_func(number);
#endregion

#region ЗАДАЧА-13
// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
Console.WriteLine("Введите трех значное число: ");
number = new Random().Next(10, 1000);
Console.WriteLine($"Введенное число: {number}");
if (number / 100 > 0)
    Console.WriteLine($"{number % 10}");
else
    Console.WriteLine($"{number} - третьей цифры нет");

int my_func2(int y) {
    if (x / 100 > 0)
        Console.WriteLine($"{x % 10}");
    else
        Console.WriteLine($"{x} - третьей цифры нет");
}

Console.WriteLine(my_func2(number));
#endregion

#region ЗАДАЧА-15
// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
number = new Random().Next(1, 8);
if (number <= 5)
    Console.WriteLine($"{number} - не выходной");
else
    Console.WriteLine($"{number} - выходной");

void my_func_3(int num) {
    if (num <= 5)
        Console.WriteLine($"{num} - не выходной");
    else
        Console.WriteLine($"{num} - выходной");  
}

my_func_3(number);

#endregion