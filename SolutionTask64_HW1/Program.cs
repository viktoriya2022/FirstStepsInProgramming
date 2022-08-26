// ==========================================================================================================
//  Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// ==========================================================================================================

 Console.Clear();

int numberM = ReadData("Задайте нижнюю границу числового поля: ");
int numberN = ReadData("Задайте верхнюю границу числового поля: ");

if (numberM < numberN) NaturalNumberPrinter(numberM, numberN);
else NaturalNumberPrinter(numberN, numberM);

//метод считывает с кoнсоли
int ReadData(string line)
{
    Console.WriteLine(line);
    return int.Parse(Console.ReadLine());
}
void NaturalNumberPrinter(int m, int n)
{
    if (m - 1 == n) return; //stop
    Console.Write(m + " ");
    NaturalNumberPrinter(m + 1, n);
}

