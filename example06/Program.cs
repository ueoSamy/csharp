// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

const int COEFFICIENT = 0;
const int CONSTANT = 1;
const int X_CORD = 0;
const int Y_CORD = 1;
const int LINE1 = 1;
const int LINE2 = 2;

double[] InputLineData(int numberOfLine)
{
    double[] lineData = new double[2];
    Console.WriteLine($"Введите коеффициент для {numberOfLine}");
    lineData[COEFFICIENT] = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine($"Введите константу для {numberOfLine}");
    lineData[CONSTANT] = Convert.ToDouble(Console.ReadLine());
    return lineData;
}

double[] lineData1 = InputLineData(LINE1);
double[] lineData2 = InputLineData(LINE2);

bool ValidateLines(double[] lineData1, double[] lineData2)
{
    if (lineData1[COEFFICIENT] == lineData2[COEFFICIENT])
    {
        if (lineData1[CONSTANT] == lineData2[CONSTANT])
        {
            Console.WriteLine("Прямые совпадают");
            return false;
        }
        else
        {
            Console.WriteLine("Прямые параллельны");
            return false;
        }
    }

    return true;
}

double[] FindCoords(double[] lineData1, double[] lineData2)
{
    double[] coords = new double[2];
    coords[X_CORD] = (lineData1[CONSTANT] - lineData2[CONSTANT]) / (lineData2[COEFFICIENT] - lineData1[COEFFICIENT]);
    coords[Y_CORD] = lineData1[CONSTANT] * coords[X_CORD] + lineData1[CONSTANT];
    return coords;
}

if (ValidateLines(lineData1, lineData2))
{
    double[] coord = FindCoords(lineData1, lineData2);
    Console.Write($"Точка пересечения уравнений y={lineData1[COEFFICIENT]} * x + {lineData1[CONSTANT]} и " +
                  $"y = {lineData2[COEFFICIENT]} * x + {lineData2[CONSTANT]}");
    Console.WriteLine($"имеет координаты ({coord[X_CORD]}, {coord[Y_CORD]})");
}

// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//
// 0, 7, 8, -2, -2 -> 2
//
// 1, -7, 567, 89, 223-> 3
Console.WriteLine("Введите числа через пробел: ");
int[] myArray = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();

int CountZero(int[] array)
{
    int count = 0;
    foreach (int elem in array)
    {
        if (elem > 0)
        {
            count++;
        }
    }

    return count;
}

Console.WriteLine($"Количество чисел больше нулья: {CountZero(myArray)}");