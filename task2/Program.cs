﻿// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

double Prompt(string message)                   // Ввод значений
{
    Console.Write(message);
    double num = double.Parse(Console.ReadLine());
    return num;
}

double x1 = Prompt("Введите координату X1: ");
double y1 = Prompt("Введите координату Y1: ");
double z1 = Prompt("Введите координату Z1: ");

double x2 = Prompt("Введите координату X2: ");
double y2 = Prompt("Введите координату Y2: ");
double z2 = Prompt("Введите координату Z2: ");

double GetLength(double x1, double y1, double z1, double x2, double y2, double z2)       // нахождение длинны отрезка
{
    double length = Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 -y2)*(y1 - y2) + (z1 -z2)*(z1 - z2));
    return length;
}

Console.WriteLine($"A ({x1},{y1},{z1}); B ({x2},{y2},{z2}) -> {GetLength(x1,y1,z1,x2,y2,z2)}");
