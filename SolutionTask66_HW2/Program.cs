﻿// ==============================================================================================================
// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// ==============================================================================================================

Console.Clear();

int sum = 0;
int m = ReadData("Введите число M: ");
int n = ReadData("Введите число N: ");

if (m < n) Sum(m, n);
else Sum(n, m);

Console.WriteLine("Сумма натуральных чисел в промежутке между заданными числами равна " + sum);

// метод считывает данные с консоли
int ReadData(string line)
{
    Console.WriteLine(line);
    return int.Parse(Console.ReadLine());
}

// метод вычисления суммы (рекурсия)
int Sum(int num1, int num2)
{
    if (num1-1 == num2) return num1;
    sum += num1;
    Sum(num1+1, num2);
    return sum;
}
