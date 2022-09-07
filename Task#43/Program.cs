// Напишите программу, которая найдет точку пересечения двух прямых, заданных уравнениями:

Console.WriteLine("Введите значение k1: ");
double k1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите значение b1: ");
double b1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите значение k2: ");
double k2 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите значение b2: ");
double b2 = double.Parse(Console.ReadLine());

double x = (b1 - b2)/(k2-k1);
double y = k1 * x + b1;

Console.WriteLine($"Координаты точки пересечения двух прямых ({x},{y})");