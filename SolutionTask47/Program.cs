// ========================================================================================
// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами. ===
// ========================================================================================

Console.Clear();

int countRow;
int countColumn;

Reading();
double[,] twoDimArray = FillTwoDimArray(countRow, countColumn);
PrintTwoDimArray(twoDimArray);

// Метод для считывания данных с консоли

void Reading()
{
    //Выводим сообщение для пользователя    
    Console.WriteLine("Задайте количество строк массива: ");
    //Считываем введенныые данные с консоли
    countRow = int.Parse(Console.ReadLine());

    Console.WriteLine("Задайте количество столбцов массива: ");
    countColumn = int.Parse(Console.ReadLine());
}

//Метод для заполнения двумерного массива вещественными числами

double[,] FillTwoDimArray(int countRow, int countColumn)
{
    //Вводим рандомайзер
    System.Random numberSyntezator = new System.Random();
    int i = 0;
    int j = 0;

    double[,] outArray = new double[countRow, countColumn];
    while (i < countRow)
    {
        j = 0;
        while (j < countColumn)
        {
            outArray[i, j] = Math.Round(numberSyntezator.NextDouble() * 10, 4);
            j++;
        }
        i++;
    }
    //Возвращаем значение
    return outArray;
}

//Метод для печати двумерного массива
void PrintTwoDimArray(double[,] inputArray)
{
    int i = 0;
    int j = 0;
    while (i < inputArray.GetLength(0))
    {
        j = 0;
        while (j < inputArray.GetLength(1))
        {
            Console.Write(inputArray[i, j] + "\t");
            j++;
        }
        Console.WriteLine();
        i++;
    }
}



