// Напишите программу, которая принимает на вход число N и выдает произведение чисел от 1 до N.

// Решение Кирилла (рекурентное)

Console.Write("Введите число: ");
string? inputLine = Console.ReadLine();
int inputNum = int.Parse(inputLine);
int t;

t = Environment.TickCount;
Console.WriteLine(sumNums(inputNum));
Console.WriteLine("Simple time: {0} ms", Environment.TickCount - t);

t = Environment.TickCount;
Console.WriteLine(mulRec(inputNum));
Console.WriteLine("Recurs time: {0} ms", Environment.TickCount - t);

int sumNums(int num)
{
    int sum = 1;
    for (int i = 1; i <= inputNum; i++)
    {
        sum *= i;
    }
    return sum;
}
// рекурсия
int mulRec(int num)
{
    if (num == 1)
    {
        return 1;
    }
    else
    {
        return num * mulRec(num - 1);
    }
}