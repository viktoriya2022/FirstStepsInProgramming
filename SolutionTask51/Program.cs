// =====================================================================================================================
// Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0)(1,1)и т.д). ==
// =====================================================================================================================

Console.Clear();

//Метод для заполнения ДВУМЕРНОГО массива
int[,] FillTwoDimArray(int countRow, int countColumn)

{
    System.Random numberSyntezator = new System.Random();
    int i = 0;
    int j = 0;
    int[,] outArray = new int[countRow, countColumn];
    while (i < countRow)
    {
        j = 0;
        while (j < countColumn)

        {
            outArray[i, j] = numberSyntezator.Next(0, 101);
            j++;
        }
        i++;
    }
    //Возвращаем значение
    return outArray;
}

//Метод решения задачи
int CalcDiagTwoDimArr(int[,] inputArray) 
{
    int outSumDiagonal = 0;
    int i = 0; int j = 0;


    while (i < inputArray.GetLength(0))
    {
        outSumDiagonal += inputArray[i, i];
        i++;
    }
    return outSumDiagonal;
}

ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Black,ConsoleColor.Blue,ConsoleColor.Cyan,ConsoleColor.DarkBlue,
                                        ConsoleColor.DarkCyan,ConsoleColor.DarkGray,ConsoleColor.DarkGreen,
                                        ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,ConsoleColor.DarkYellow,
                                        ConsoleColor.Gray,ConsoleColor.Green,ConsoleColor.Magenta,ConsoleColor.Red,
                                        ConsoleColor.White,ConsoleColor.Yellow };

//Метод для печати ДВУМЕРНОГО (цветного) массива
void PrintColorTwoDimArray(int[,] inputArray)
{
    int i = 0; int j = 0;

    Console.ForegroundColor = ConsoleColor.Blue;
    while (i < inputArray.GetLength(0))
    {
        j = 0;
        while (j < inputArray.GetLength(1))

        {
            Console.ForegroundColor = col[new System.Random().Next(0, 16)];
            Console.Write(inputArray[i, j] + "\t");
            j++;
            Console.ResetColor();
        }
        //Console.Write("\n");
        Console.WriteLine();
        i++;
    }
    Console.ResetColor();
}



int[,] twoDimArray = FillTwoDimArray(3, 3);//заполнили массив
PrintColorTwoDimArray(twoDimArray);//напечатали заполненный
int sum=CalcDiagTwoDimArr(twoDimArray);
Console.WriteLine(sum);

