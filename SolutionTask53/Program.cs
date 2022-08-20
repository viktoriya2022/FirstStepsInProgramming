// ============================================================================================================
//Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строчку массива  == 
// ============================================================================================================

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

//Метод меняет местами первую и последнюю строчки массива 
//принимает двумерный массив
//возвращает модифицированный входной массив
int[,] RotateRowFirstLast(int[,] inputArray)
{
    int bufferElement = 0;
    int i = 0; int j = 0;
    // 1 2 3 4      9 8 7 6 
    // 3 6 5 9      3 6 5 9  buf(1)
    // 9 8 7 6      1 2 3 4

    while (j < inputArray.GetLength(1)) //пока номер столбца(j) меньше чем запрошенная нами длина массива по столбцу (1)
    { 
        //блок ротации элементов в столбце
        bufferElement = inputArray[0, j]; //Положили 1 в буфер
        inputArray[0, j] = inputArray[inputArray.GetLength(0) - 1, j]; //Положили 9 в 1
        inputArray[inputArray.GetLength(0) - 1, j] = bufferElement;
        j++;
    }
    return inputArray; //так как мы меняли весь массив, его и выдаем на выход
}


//собираем программу

int[,] twoDimArray = FillTwoDimArray(3, 4);//заполнили массив
PrintTwoDimArray(twoDimArray);//напечатали исходный заполненный массив

Console.WriteLine();//пустая строка на консоль
PrintTwoDimArray(RotateRowFirstLast(twoDimArray));//передали методу печати метод по ротации строк >> сразу вывели на печать модиф. массив

