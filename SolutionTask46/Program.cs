// ==================================================================================
// Задайте двумерный массив размером m x n, заполненный целыми случайными числами. ==
// ==================================================================================

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

//Метод для печати ДВУМЕРНОГО массива
void PrintTwoDimArray(int[,] inputArray)
{
    int i = 0;
    int j = 0;

    while (i < inputArray.GetLength(0))
    {
        j = 0;
        while (j < inputArray.GetLength(1))

        {
            Console.Write(inputArray[i, j] + " ");
            j++;
        }
        //Console.Write("\n");
        Console.WriteLine();
        i++;
    }
}

ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Black,ConsoleColor.Blue,ConsoleColor.Cyan,ConsoleColor.DarkBlue,
                                        ConsoleColor.DarkCyan,ConsoleColor.DarkGray,ConsoleColor.DarkGreen,
                                        ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,ConsoleColor.DarkYellow, 
                                        ConsoleColor.Gray,ConsoleColor.Green,ConsoleColor.Magenta,ConsoleColor.Red,
                                        ConsoleColor.White,ConsoleColor.Yellow };

void PrintColorTwoDimArray(int[,] inputArray)
{
    int i = 0; int j = 0;

    Console.ForegroundColor = ConsoleColor.Blue;
    while (i < inputArray.GetLength(0))
    {
        j = 0;
        while (j < inputArray.GetLength(1))

        {
            Console.ForegroundColor=col[new System.Random().Next(0,16)];
            Console.Write(inputArray[i, j] + " ");
            j++;
            Console.ResetColor();
        }
        //Console.Write("\n");
        Console.WriteLine();
        i++;
    }
    Console.ResetColor();
}

int[,] twoDimArray = FillTwoDimArray(5, 8);
PrintTwoDimArray(twoDimArray);
PrintColorTwoDimArray(twoDimArray);
