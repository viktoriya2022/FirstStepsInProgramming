System.Random numberSintezator = new Random();
//int number = numberSintezator.Next(10, 100);

//метод решения задачи вариант 1
void variant1(System.Random numberSintezator)
{
    //Вариант 1
    int number=numberSintezator.Next(10,100);
    Console.WriteLine(number);
    //определяем первую цифру
    int firstNumber = number / 10;
    //определяем вторую цифру
    int secondNumber = number % 10;

    if (firstNumber > secondNumber)
    {
        Console.WriteLine(firstNumber);
    }
    else
    {
        Console.WriteLine(secondNumber);
    }
}

//метод решения задачи вариант 2
void variant2()

{
    //вариант2
    int numberKir = new Random().Next(10, 100);

    Console.Write("The random number is:");
    Console.WriteLine(numberKir);

    string stringNum = numberKir.ToString();

    Console.WriteLine("The biggest digit is:");
    if (stringNum[0] > stringNum[1])
    {
        Console.WriteLine(stringNum[0]);
    }
    else
    {
        Console.WriteLine(stringNum[1]);
    }
}

//метод решения задачи вариант 3
void variant3(System.Random numberSintezator)
{
    //вариант3
    //объявляем переменную, int, в строку, в массив   
    char[] digits = numberSintezator.Next(10, 100).ToString().ToCharArray();
    Console.WriteLine(digits);

    int firstNumber = ((int)digits[0]) - 48;
    int secondNumber = ((int)digits[1]) - 48;

    int resultNumber = firstNumber > secondNumber ? resultNumber = firstNumber : resultNumber = secondNumber;

    Console.WriteLine(resultNumber);
}



variant1(numberSintezator);
variant2();
variant3(numberSintezator);