// ===================================================================================================================
// Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.==
// ===================================================================================================================

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

//Метод решения задачи
int[,] UpdateTwoDimArray(int[,] inputArray) //ref int[,] прямая ссылка на объект вне метода
{
    int[,] outArray = new int[inputArray.GetLength(0), inputArray.GetLength(1)];
    int i = 0; int j = 0;
    while (i < inputArray.GetLength(0))
    {
        j = 0;
        while (j < inputArray.GetLength(1))

        {
            if (i % 2 == 0 && j % 2 == 0)
            {
                outArray[i, j] = inputArray[i, j] * inputArray[i, j];
            }
            else
            {
                outArray[i, j] = inputArray[i, j];
            }
            j++;

        }

        i++;
    }
    return outArray;
}

//метод только по четным рядам
void UpdateTwoDimArray2(ref int[,] inputArray) //ref int[,] прямая ссылка на объект вне метода
{
    int i = 0; int j = 0;
    while (i < inputArray.GetLength(0))
    {
        j = 0;
        while (j < inputArray.GetLength(1))
        {
            inputArray[i, j] = inputArray[i, j] * inputArray[i, j];
            j += 2;
        }
        i += 2;
    }
}

int[,] twoDimArray = FillTwoDimArray(5, 8);//заполнили массив
PrintColorTwoDimArray(twoDimArray);//напечатали заполненный
//---------------------------------------------------
DateTime d = DateTime.Now;
int[,] bufTwoDimArray = UpdateTwoDimArray(twoDimArray);
Console.WriteLine(DateTime.Now - d);

d = DateTime.Now;
UpdateTwoDimArray2(ref twoDimArray);
Console.WriteLine(DateTime.Now - d);
//---------------------------------------------------
PrintColorTwoDimArray(bufTwoDimArray);//напечатали измененный
PrintColorTwoDimArray(twoDimArray);
//---------------------------------------------------
