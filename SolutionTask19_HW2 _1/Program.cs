﻿//Вариант Кирилла (решение через СЛОВАРЬ)
//---------------------------------------------------------------------------------------------
//Программа, принимающая на вход пятизначное число и проверяющая, является ли оно палиндромом.
//---------------------------------------------------------------------------------------------

//Метод генерации палиндромов (добавляет 4хзначные палиндромы в переданный словарь)
void paliDictGen(Dictionary<int, string> paliDict)
{
    int key;
    //Генерируем палиндромы в цикле - каждому двузначному дописываем в конце его же зеркальное
    for (int i = 10; i < 100; i++)
    {
        key = i * 100 + (i % 10) * 10 + i / 10;
        paliDict.Add(key, key.ToString());
    }
}

//Считываем данные с консоли
Console.Write("Введите пятизначное число: ");
//Считываем данные с консоли
string? inputLine = Console.ReadLine();
try
{
    // Парсим ввод в int
    int inputNum = int.Parse(inputLine);
    // Удостоверяемся в том, что введенное число пятизначное
    if ((inputNum > 99999) || (inputNum < 10000))
    {
        throw new ArgumentOutOfRangeException("Введенное число не пятизначное.");
    }
    //Создаем новый словарь
    Dictionary<int, string> paliDict = new Dictionary<int, string>();
    //Вызываем метод генерации палиндромов
    paliDictGen(paliDict);
    //Удаляем среднюю цифру
    inputNum = (inputNum / 1000) * 100 + inputNum % 100;
    //Выполняем проверку на палиндром
    if (paliDict.ContainsKey(inputNum))
    {
        Console.WriteLine("Заданное число является палиндромом.");
    }
    else
    {
        Console.WriteLine("Заданное число не является палиндромом.");
    }
}
catch (Exception e)
{
    //Выводим сообщение об ошибке
    Console.WriteLine("Некорректный ввод.");
    Console.WriteLine("Возникло исключение.");
    Console.WriteLine("Ппоробуйте запустить программу ещё раз.");
}