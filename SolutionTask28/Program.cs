// Напишите программу, которая принимает на вход число N и выдает произведение чисел от 1 до N.

Console.Write("Введите число: ");
string? inputLine = Console.ReadLine();
int inputNum = int.Parse(inputLine);

Console.WriteLine(sumNums(inputNum));

int sumNums(int num)
{
    int sum = 1;
    for (int i = 1; i <= inputNum; i++)
    {
        //sum *= i;
        sum = sum * i;
    }
    return sum;
}