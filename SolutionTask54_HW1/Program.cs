// ===========================================================================================================================
// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строчки  двумерного массива.
// ===========================================================================================================================

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
        //Console.Write("\n");
        Console.WriteLine();
        i++;
    }
}

//Метод сортировки массива
int[] BubbleSort(int[] Array)
{
    for (int i = 0; i < Array.Length; i++)
    {
        for (int j = 0; j < Array.Length - 1; j++)
        {
            if (Array[j] > Array[j + 1])
            {
                int temp = Array[j];
                Array[j] = Array[j + 1];
                Array[j + 1] = temp;
            }
        }
    }
    return Array;
}


//Решение
int[,] UpdateMinTwoDimArray(int[,] inputArray)
{   //задаем новый массив
    int[] array = new int[inputArray.GetLength(1)];
    int i = 0; int j = 0;
    //до конца столбцов...
    while (i < inputArray.GetLength(0))
    {
        j = 0;
        //до конца строк...
        while (j < inputArray.GetLength(1))
        {
            //каждому элементу строки нового массива присваеваем
            array[j] = inputArray[i, j];
            j++;
        }

        //применяем метод сортировки
        array = BubbleSort(array);
        j = 0;
        //запускаем новый цикл->собираем уже отсортированный массив обратно
        while (j < inputArray.GetLength(1))
        {
            inputArray[i, j] = array[j];
            j++;
        }
        i++;
    }

    return inputArray;
}




int[,] FilterToMinTwoDimArray = FillTwoDimArray(10, 10);
PrintTwoDimArray(FilterToMinTwoDimArray);
Console.Write("\n");
PrintTwoDimArray(UpdateMinTwoDimArray(FilterToMinTwoDimArray));