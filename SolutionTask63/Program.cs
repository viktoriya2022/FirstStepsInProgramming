// ===================================================================================================
// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// ===================================================================================================
Console.Clear();

//метод считывает N 
int ReadData()
{
    Console.WriteLine ("Задайте число: ");
    return int.Parse(Console.ReadLine());
}

int NaturalNumberPrinter(int num)
   {
    if (num == 2) return 1; 
    else
    {
        num--;
        //Console.WriteLine(num);
        //метод вызывает сам себя
        Console.Write(NaturalNumberPrinter(num) + " ");
    }
    return num;
   }
int num = ReadData();
NaturalNumberPrinter(num+2);