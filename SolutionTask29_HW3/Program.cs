// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

//Очищаем консоль:
Console.Clear();

//Выводим сообщения для пользователя:
Console.WriteLine("Задайте нижний предел рандомного поля:");
string inputLineNumberLow = Console.ReadLine() ?? ""; //Вместо проверки на null
int inputNumberLow = int.Parse(inputLineNumberLow);

Console.WriteLine("Задайте верхний предел рандомного поля:");
string inputLineNumberUp = Console.ReadLine() ?? ""; //Вместо проверки на null
int inputNumberUp = int.Parse(inputLineNumberUp);

// Подключаем рандомайзер:
System.Random numberSintezator=new Random(); 

 //ВВодим метод "набора" массива случайных чисел в рамках заданого интервала:
void RandomArray() 
{
    int i=0;             //Вводим переменную
    Console.Write("["); //Пропечатываем первую скобку
    while(i<8-1)        //-1, чтобы избавиться от лишней запятой в конце массива
    {
        Console.Write(numberSintezator.Next(inputNumberLow,inputNumberUp)+",");
        i++;
    }
    Console.Write(numberSintezator.Next(inputNumberLow,inputNumberUp)); //Добиваем последний элемент массива без запятой
    Console.Write("]");                         //Добавляем вторую скобку
}

//Вызываем метод:
RandomArray();  