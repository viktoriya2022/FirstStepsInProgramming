//Напишите программу, которая принимает на вход число и выдает количество цифр в числе.

Console.Clear();
Console.Write("Введите число: ");

string inputLineNumber = Console.ReadLine() ?? ""; //Вместо проверки на null
int inputNumber = int.Parse(inputLineNumber);

DateTime timePoint=DateTime.Now;

int VariantChar()
{
    // int numberLength = 0;                          //ввели новую переменную
    // char[] array = inputLineNumber.ToCharArray();  //объявили массив, положили в него символы переменной
    // numberLength = array.Length;                   //измерили длину массива
    // return numberLength;
    return inputLineNumber.ToCharArray().Length;
}

int VariantSimple()
{
    int numberLength = 0;
    int digits = 1;
    while (digits < inputNumber)
    {
        digits = digits * 10;
        numberLength++;
    }
    return numberLength;
}

int VariantLog10()


{
    return (int)Math.Log10(inputNumber)+1; //принудительно преобразовали double в int (отбросит лишние байты)
}

int result = 0;

timePoint=DateTime.Now;
result = VariantChar();
Console.WriteLine(result);
Console.WriteLine(DateTime.Now-timePoint);

timePoint=DateTime.Now;
result = VariantSimple();
Console.WriteLine(result);
Console.WriteLine(DateTime.Now-timePoint);

timePoint=DateTime.Now;
result = VariantLog10();
Console.WriteLine(result);
Console.WriteLine(DateTime.Now-timePoint);
