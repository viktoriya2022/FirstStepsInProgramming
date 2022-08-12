// Напишите программу, которая будет преобразовывать десятичное число в двоичное
//================================

Console.Clear();
Console.WriteLine(Convert.ToString(int.Parse(Console.ReadLine()), 2));

int number = int.Parse(Console.ReadLine());
string outline = (Convert.ToString(number, 2));// метод преобразует число (number) в систему, указанную во втором аргументе(2,8,16).

//вариант Кирилла (длинный)
Console.Write("Введите десятичное число: ");
int decemalNumber = ReadDecemalNumber();
PrintAnswer(BinaryConverter(decemalNumber));


int ReadDecemalNumber()
{
    return int.Parse(Console.ReadLine() ?? "");
}

string BinaryConverter(int num)
{
    string bin = "";
    while (num > 0)
    {
        if (num % 2 == 1)
        {
            bin = "1" + bin;
        }
        else
        {
            bin = "0" + bin;
        }
        num /= 2;
    }
    return bin;
}

void PrintAnswer(string answer)
{
    Console.WriteLine("Введенное число в двоичном виде: " + answer);
}