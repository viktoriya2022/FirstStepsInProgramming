//Метод считьывает точки и возвращает массив с ними
int[,] readPoint()

{
    string inputLine = Console.ReadLine();


    //x=34; y=-30 ->4
    // "возьми" подстроку от 0 до ";". Получаем "х=34"
    string coordXLine = inputLine.Substring(0, inputLine.IndexOf(";"));
    // "возьми" подстроку от "=" до конца. Получаем "34"
    coordXLine = coordXLine.Substring(coordXLine.IndexOf("=") + 1);

    //                  "возьми" подстроку   от             ";" до конца. Получаем "х=-30"
    string coordYLine = inputLine.Substring(inputLine.IndexOf(";") + 1);
    //            "возьми"  подстроку     от            "=" до конца. Получаем "30"
    coordYLine = coordYLine.Substring(coordYLine.IndexOf("=") + 1);

    //Console.WriteLine(coordX+" "+coordY);

    //преобразуем числа в значащие (вещественные)
    int coordX = int.Parse(coordXLine);
    int coordY = int.Parse(coordYLine);

    int[,] arrayOut = new int[1, 2];
    arrayOut[0, 0] = coordX;
    arrayOut[0, 1] = coordY;

    return arrayOut;
}

//Метод печатает номер четверти
void printQuoter(int[,] arrayPoint)
{
    if (arrayPoint[0, 0] > 0 && arrayPoint[0, 1] > 0)
        Console.WriteLine("1 четверть");

    if (arrayPoint[0, 0] < 0 && arrayPoint[0, 1] > 0)
        Console.WriteLine("2 четверть");

    if (arrayPoint[0, 0] < 0 && arrayPoint[0, 1] < 0)
        Console.WriteLine("3 четверть");

    if (arrayPoint[0, 0] > 0 && arrayPoint[0, 1] < 0)
        Console.WriteLine("4 четверть");


}

int[,] arrayPoint = readPoint();
printQuoter(arrayPoint);

//printQuoter(arreyPoint());