void printAnswer(int number)
{
    if (number == 1) Console.WriteLine("Допустимо: x>0, y>0");
    if (number == 2) Console.WriteLine("Допустимо: x<0, y>0");
    if (number == 3) Console.WriteLine("Допустимо: x<0, y<0");
    if (number == 4) Console.WriteLine("Допустимо: x>0, y<0");

}

//считает строчку с консоли
string? inputLine = Console.ReadLine();

//проверит строчку (не пустая?)
if (inputLine != null)
{
    //превратит строчку в вещественное число
    int inputNumber = int.Parse(inputLine);
    //передаст число в метод (наверх)
    printAnswer(inputNumber);
}


