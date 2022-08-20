// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
//=============================================

Console.Clear();

//Объявляем переменные. одновременно вызываем метод считывания данных с использованием строковой переменной
double k1 = ReadCoord("Введите значение k1: ");
double k2 = ReadCoord("Введите значение k2: ");
double b1 = ReadCoord("Введите значение b1: ");
double b2 = ReadCoord("Введите значение b2: ");
double x;
double y;

//Read();
Calculate();
PrintResult();

// //Метод для считывания введенных координат:
// void Read()
// {
//     //Выводим на консоль сообщение для пользователя
//     Console.WriteLine("Введите значение b1: ");
//     //Распарсиваем введенную переменную в новую
//     b1 = double.Parse(Console.ReadLine());

//     Console.WriteLine("Введите значение k1: ");
//     k1 = double.Parse(Console.ReadLine());

//     Console.WriteLine("Введите значение b2: ");
//     b2 = double.Parse(Console.ReadLine());

//     Console.WriteLine("Введите значение k2: ");
//     k2 = double.Parse(Console.ReadLine());

// }

// метод для считывания введенных пользователем данных с консоли
// метод получает координаты от пользователя
//возвращает введенные значения в нужном формате
double ReadCoord(string line)
{
    Console.Write(line);
    double buf = double.Parse(Console.ReadLine());

    return buf;
}

//Метод расчета координат точки пересечения двух прямых:
void Calculate()
{
    x = ((b2 - b1) / (k1 - k2));
    y = k2 * ((b2 - b1) / (k1 - k2)) + b2;
}

//Метод печати результатов расчета:
void PrintResult()
{
    Console.WriteLine("Координаты точки пересечения: (" + x + "; " + y + ")");
}