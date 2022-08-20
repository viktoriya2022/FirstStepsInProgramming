// ==================================================================================================================
// Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозножно, =
// программа должна вывести сообщение для пользователя                                                              =
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

//Метод меняет местами первую и последнюю строчки массива 
//принимает двумерный массив
//возвращает модифицированный входной массив
int[,] RotateTwoDimArray(int[,] inputArray)
{
    // 1 2 3
    // 4 5 6
    // 7 8 9
    int bufferElement = 0;
    int i = 0; int j = 0;

    while (i < inputArray.GetLength(0)) //пока номер строки(i) меньше чем запрошенная нами длина массива по строке (0)
    {
        j = i;
        while (j < inputArray.GetLength(1)) //пока номер столбца(j) меньше чем запрошенная нами длина массива по столбцу (1)
        {
            //блок ротации элементов в столбце
            bufferElement = inputArray[i, j]; //Положили 2 в буфер
            inputArray[i, j] = inputArray[j, i]; //Положили 4 в 2
            inputArray[j, i] = bufferElement;
            j++;
        }
        i++;
    }
    return inputArray; //так как мы меняли весь массив, его и выдаем на выход
}


//собираем программу

int[,] twoDimArray = FillTwoDimArray(4, 4);//заполнили массив
PrintTwoDimArray(twoDimArray);//напечатали исходный заполненный массив
Console.WriteLine();//пустая строка на консоль

if (twoDimArray.GetLength(0) != twoDimArray.GetLength(1))
{
    Console.WriteLine("Данный массив развернуть нельзя.");
}
else
{
    PrintTwoDimArray(RotateTwoDimArray(twoDimArray));//передали методу печати метод по развороту массива>> сразу вывели на печать модиф. массив
}
