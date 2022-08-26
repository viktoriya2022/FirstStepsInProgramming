// ==========================================================================================================
// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// ==========================================================================================================

Console.Clear();

int numberN = ReadData("Введите первое неотрицательное число: ");
int numberM = ReadData("Введите второе неотрицательное число: ");

Console.WriteLine(AckermannFunc(numberN, numberM));

// метод считывает данные с консоли
int ReadData(string line)
{
    Console.WriteLine(line);
    return int.Parse(Console.ReadLine());
}

// функция Аккермана

int AckermannFunc(int n, int m)
{
    if (n == 0)
        return m + 1;
    else
    if ((n != 0) && (m == 0))
        return AckermannFunc(n - 1, 1);
    else
        return AckermannFunc(n - 1, AckermannFunc(n, m - 1));
}
