//"Объявляем" переменные вне метода. Теперь они глобальные (доступные)
int digit1;
int digit2;
int digit4;
int digit5;
int number;
    
//Метод разложения введенного числа на цифры
void numberToDigits()
{
    //Раскладываем число на цифры
    digit1 = number / 10000;
    digit2 = (number / 1000) % 10;
    digit4 = (number / 10) % 10;
    digit5 = digit1 % 10;
}
//Метод проверки на "паллиндромность"
void numberCheck()
{
  if (digit1 == digit5 && digit2 == digit4)
    {
        Console.WriteLine("This is a pallindrome");
    }
    else
    {
        Console.WriteLine("This is not a pallindrome");
    }  
}

//Выводим на консоль сообщение для пользователя
Console.WriteLine("Enter a five-digit number");
//Распарсиваем переменную 
number = int.Parse(Console.ReadLine());

if (number != null)
{
    //Вызываем методы
    numberToDigits();
    numberCheck();
}