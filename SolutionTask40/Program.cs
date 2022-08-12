// Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник со сторонами такой длины.
//==================================================
// Console.Clear();

// int sideA = 0;
// int sideB = 0;
// int sideC = 0;

// ReadSides();
// bool res=TestTriangle(sideA, sideB, sideC);
// PrintAnswer(res);

// void ReadSides()
// {
//     Console.Write("Введите число 1: ");
//     sideA = int.Parse(Console.ReadLine() ?? "");
//     Console.Write("Введите число 2: ");
//     sideB = int.Parse(Console.ReadLine() ?? "");
//     Console.Write("Введите число 3: ");
//     sideC = int.Parse(Console.ReadLine() ?? "");
// }

// bool TestTriangle(int num1, int num2, int num3)
// {
//     bool answer = ((num1 + num2 > num3)
//     && (num2 + num3 > num1)
//     && (num1 + num3 > num2)) ? true : false;
//     //perem = (условие)?значение 1: значение 2;
//     return answer;
// }

// void PrintAnswer(bool answer)
// {
//     if (answer)
//     {
//         Console.WriteLine("Из этих отрезков можно составить треугольник");
//     }
//     else
//     {
//         Console.WriteLine("Из этих отрезков нельзя составить треугольник");
//     }
// }




//проверка существования треугольника (вариант Никиты-без методов)
bool CheckTriangle(int[] numbers)
{
    if ((numbers[0] + numbers[1] > numbers[2]) 
    & (numbers[2] + numbers[0] > numbers[1]) 
    & (numbers[1] + numbers[2] > numbers[0]))
        return true;
    else
        return false;
}

Console.Clear();

Console.WriteLine("Введите три числа в формате Ч1 Ч2 Ч3");
try
{
    string[] stringNumbers = Console.ReadLine().Split(" ");
    int[] numbers = new int[3];
    for (int i = 0; i < stringNumbers.Length; i++)
        numbers[i] = int.Parse(stringNumbers[i]);

    if (CheckTriangle(numbers))
        Console.WriteLine("Треугольник существует!");
    else
        Console.WriteLine("Треугольника не существует!");
}
catch
{
    Console.WriteLine("Некорректный формат ввода");
}