// ============================================================================================================== 
// Напишите программу, которая на вход принимает два числа А и В и возводит число А в целую степень В (рекурсия).
// ============================================================================================================== 


Console.Clear();

int a = ReadData("Введите число - основание степени: ");
int b = ReadData("Введите число - показатель степени: ");

DateTime d = DateTime.Now;
int res1 = PowNumber(a, b);
Console.WriteLine(DateTime.Now - d);

d = DateTime.Now;
int res2 = MyPow(a, b);
Console.WriteLine(DateTime.Now - d);

d = DateTime.Now;
double res3 = Math.Pow(a, b);
Console.WriteLine(DateTime.Now - d);

Console.WriteLine(res1);
Console.WriteLine(res2);
Console.WriteLine(res3);

//метод считывает данные с консоли
int ReadData(string line)
{
    Console.WriteLine(line);
    return int.Parse(Console.ReadLine());
}

int MyPow(int a, int b)
{
    if (b == 2)
    {
        return a * a;
    }
    if (b == 1)
    {
        return a;
    }
    if (b % 2 == 0)
    {// собственно, рекурсия
        return MyPow(a, b / 2) * MyPow(a, b / 2);
    }
    else
    {
        return MyPow(a, b / 2) * MyPow(a, (b / 2) + 1);
    }
}

int PowNumber(int numberA, int numberB)
{
    if (numberB == 1) return numberA;

    return numberA * PowNumber(numberA, numberB - 1);
}
