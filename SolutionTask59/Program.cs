// ==================================================================================================================
// Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку на столбец,
// на пересечении которых находится наименьший элемент массива.
// ==================================================================================================================

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
            outArray[i, j] = numberSyntezator.Next(0, 101);
            j++;
        }
        i++;
    }
    //Возвращаем значение
    return outArray;
}

//Метод для печати двумерного массива
void PrintTwoDimArray(int[,] inputArray) //Принимаем на печать массив int[,] inputArray
{
    int i = 0;
    int j = 0;
    // проходим по индексам
    while (i < inputArray.GetLength(0))
    {
        j = 0;
        while (j < inputArray.GetLength(1))

        {
            Console.Write(inputArray[i, j] + "\t"); //поэлементно выводим на консоль (через таб))
            j++;
        }
        //Console.Write("\n");
        Console.WriteLine();
        i++;
    }
}


//метод находит минимальные значение в строке и столбце
int[] FindMinElement(int[,] matrix)
{
    int[] array = new int[] { 0, 0, };
    int minElement = int.MaxValue;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < minElement)
            {
                minElement = matrix[i, j];
                array[0] = i;
                array[1] = j;
            }
        }
    }
    return array;
}

//Метод меняет местами первую и последнюю строчки массива 
//принимает двумерный массив
//возвращает модифицированный входной массив
int[,] Update2_DArray(int[,] inputArray, int row, int column)
{
    int[,] outArray = new int[inputArray.GetLength(0) - 1, inputArray.GetLength(1) - 1]; //создаем новый двум массив с размерностью на 1 меньше по столбцам и строкам входящего

    int i = 0; int j = 0; int k = 0; int m = 0;
    while (i < inputArray.GetLength(0)) //пока номер строки(i) меньше чем запрошенная нами длина массива по строке (0)
    {
        j = 0; m = 0;
        while (j < inputArray.GetLength(1)) //пока номер столбца(j) меньше чем запрошенная нами длина массива по столбцу (1)
        {
            if (i != row && j != column)
            {
                outArray[k, m] = inputArray[i, j];
            }
            if (j != column) m++;
            j++;
        }
        if (i != row) k++;
        i++;
    }
    return outArray; //так как мы меняли весь массив, его и выдаем на выход
}


//собираем программу

int[,] twoDimArray = FillTwoDimArray(5, 5);//заполнили массив
PrintTwoDimArray(twoDimArray);//напечатали исходный заполненный массив
Console.WriteLine();//пустая строка на консоль

int[] indexes=FindMinElement(twoDimArray);
Console.WriteLine(indexes[0]+" "+indexes[1]);

int[,] buferTwoDimArray=Update2_DArray(twoDimArray,indexes[0],indexes[1]);
PrintTwoDimArray(buferTwoDimArray);