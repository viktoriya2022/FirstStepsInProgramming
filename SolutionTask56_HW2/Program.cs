// =======================================================================================================================
// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// =======================================================================================================================

Console.Clear();

//Метод для заполнения двумерного массива
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
            outArray[i, j] = numberSyntezator.Next(0, 10);
            j++;
        }
        i++;
    }
    //Возвращаем значение
    return outArray;
}

//Метод для печати двумерного массива
void PrintTwoDimArray(int[,] inputArray)
{
    int i = 0;
    int j = 0;
    while (i < inputArray.GetLength(0))
    {
        j = 0;
        while (j < inputArray.GetLength(1))
        {
            Console.Write(inputArray[i, j] + "   ");
            j++;
        }
        Console.Write("\n");
        i++;
    }
}

//Метод поиска в двумерном массиве строки с наименьшей суммой элементов
int FindMinRow(int[,] inputArray)
{
    int i = 0; int j = 0;
    int sum = 0;
    int min = int.MaxValue;
    int ind = 0;
    while (i < inputArray.GetLength(0))
    {
        j = 0;
        sum = 0;
        while (j < inputArray.GetLength(1))
        {
            sum += inputArray[i, j];
            j++;
        }

        if (sum < min)
        {
            min = sum;
            ind = i;
        }
        i++;
    }
    return ind;
}

int[,] TwoDimArray = FillTwoDimArray(5, 2);
PrintTwoDimArray(TwoDimArray);
Console.Write("\n");
Console.WriteLine("Индекс строки с наименьшей суммой элементов: " + (FindMinRow(TwoDimArray)));
Console.Write("\n");