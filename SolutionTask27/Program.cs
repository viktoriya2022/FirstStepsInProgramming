//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

//Очищаем консоль:
Console.Clear();

//Выводим сообщение для пользователя:
Console.Write("Введите число: ");

string inputLineNumber = Console.ReadLine() ?? ""; //Вместо проверки на null
int inputNumber = int.Parse(inputLineNumber);
int result = 0;

//Вводим метод расчета суммы цифр в числе:
void SumDigOfNumber()
{
while (inputNumber > 10)
{
    result = result + inputNumber % 10;
    inputNumber = inputNumber / 10;
}
result=result+inputNumber;
}

//Вызываем метод расчета:
SumDigOfNumber();

//Выводим результат на консоль:
Console.WriteLine("Сумма цифр числа "+inputLineNumber+" равна "+result+".");
