/*Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями
 y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/

Console.Clear();
double DataInput(string message)
{
    Console.Write(message + ": ");
    double result = double.Parse(Console.ReadLine());
    return result;
}

double[] CrossPointCoordinates(double k1, double b1, double k2, double b2)
{
    double[] coordinates = {(b1 - b2) / (k2 - k1), (b1 * k2 - b2 * k1) / (k2 - k1)};
    return coordinates;
}

void PrintArray(double[] arr)
{
    Console.WriteLine($"[{String.Join(", ", arr)}]");
}

double k1 = DataInput("Введите k1");
double b1 = DataInput("Введите b1");
double k2 = DataInput("Введите k2");
double b2 = DataInput("Введите b2");

if (k1 == k2)
{
    if (b1 == b2) Console.WriteLine("Данные линии совпадают");
    else Console.WriteLine("Данные линии параллельны");
}
else PrintArray(CrossPointCoordinates(k1, b1, k2, b2));
