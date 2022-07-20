//Считываем переменную
string? inputLineN = Console.ReadLine();

if (inputLineN != null) // цикл проверки
{
    int numberN = int.Parse(inputLineN);
    //объявляем переменные (lineN и lineNN пустые строки)
    string lineN = "";
    string lineCubeN = string.Empty;
    int s = 1;
    while (s <= numberN)
    {
        lineN = lineN + s + " ";
        lineCubeN = lineCubeN + Math.Pow(s, 3) + " ";
        s++;
    }

    Console.WriteLine(lineN);
    Console.WriteLine(lineCubeN);
}

