//"Объявляем" переменные вне метода. Теперь они глобальные (доступные)
int coordXPointA;
int coordYPointA;
int coordZPointA;
int coordXPointB;
int coordYPointB;
int coordZPointB;
double lengthAB;

//Метод для считывания координат точек А и В
void readDataOfPoint()
{
    //Выводим на консоль сообщение для пользователя
    Console.WriteLine("Введите координату Х точки А");
    //Распарсиваем введенную переменную в новую
    coordXPointA = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите координату Y точки А");
    coordYPointA = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите координату Z точки А");
    coordZPointA = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите координату Х точки B");
    coordXPointB = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите координату Y точки B");
    coordYPointB = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите координату Z точки B");
    coordZPointB = int.Parse(Console.ReadLine());
}

//Метод для вычисления расстояния между точками А и В
void calculateLengthAB()
{
    //Вычисляем расстояние между координатами
    lengthAB = Math.Sqrt(Math.Pow((coordXPointA - coordXPointB), 2) + Math.Pow((coordYPointA - coordYPointB), 2) +Math.Pow((coordZPointA - coordZPointB), 2));
}

//Вызываем метод
readDataOfPoint();
calculateLengthAB();

Console.WriteLine(lengthAB);