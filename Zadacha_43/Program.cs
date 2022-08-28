/*Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных 
уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/

Console.Write("Введите значение b1: ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение k1: ");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение b2: ");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение k2: ");
int k2 = Convert.ToInt32(Console.ReadLine());
// Учитывая, что уравнения прямых y = k1 * x + b1; y = k2 * x + b2; то координаты точки пересечения будут:

int xPoint = (b2-b1)/(k1-k2); // исходя из уравнения k1 * x + b1 = k2 * x + b2;
int yPoint = (b1*k2-b2*k1)/(k2-k1); // исходя из уравнения (y - b1)/k1 = (y - b2)/k2;

Console.Write($"Точка пересечения двух прямых имеет координаты x = {xPoint}, y = {yPoint}");
