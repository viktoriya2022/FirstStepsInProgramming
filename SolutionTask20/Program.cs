//"объявляем" переменные вне метода. Теперь они глобальные (доступные)
int coordXPointA;
int coordYPointA;
int coordXPointB;
int coordYPointB;
double lengthAB;

//метод считывает координаты точек А и В
void readDataOfPoint()


{
    //Выводим на консоль сообщение для пользователя
    Console.WriteLine("Ведите координату Х точки А");
    //Распарсиваем введенную переменную в новую
    coordXPointA = int.Parse(Console.ReadLine());

    Console.WriteLine("Ведите координату Y точки А");
    coordYPointA = int.Parse(Console.ReadLine());

    Console.WriteLine("Ведите координату Х точки B");
    coordXPointB = int.Parse(Console.ReadLine());

    Console.WriteLine("Ведите координату Y точки B");
    coordYPointB = int.Parse(Console.ReadLine());
}

//Вычисляет расстояние между точками А и В
void calculateLengthAB()
{
    //Вычисляем расстояние между координатами
    lengthAB = Math.Sqrt(Math.Pow((coordXPointA - coordXPointB), 2) + Math.Pow((coordYPointA - coordYPointB), 2));
}

//Вызываем метод
readDataOfPoint();
calculateLengthAB();

Console.WriteLine(lengthAB);