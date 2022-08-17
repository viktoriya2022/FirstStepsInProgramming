// ======================================================================================
// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, ==
// и возвращает значение этого элемента или же указание, что такого элемента нет.      ==
// ======================================================================================

Console.Clear();

int countRow;
int countColumn;

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
void PrintTwoDimArray(int[,] inputArray)
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
        //Console.Write("\n");
        Console.WriteLine();
        i++;
    }
}

// //Метод поиска элемента в массиве (НЕ РАБОТАЕТ)

// bool SearchElement(int[,] inputArray)
// {
//     int[,] outArray = new int[inputArray.GetLength(0), inputArray.GetLength(1)];
//     bool result = false;
//     int i = 0; int j = 0;

//     Console.WriteLine("Задайте искомый элемент: ");
//     int elem = int.Parse(Console.ReadLine());

//     while (i < inputArray.GetLength(0))
//     {
//         j = 0;
//         while (j < inputArray.GetLength(1))
//         {
//             if (outArray[i, j] == elem)
//             {
//                 result = true;
//                 break;
//             }
//             j++;
//         }
//         i++;
//     }
//     return result;
// }


//Метод поиска элемента в массиве по номеру строки и столбца

void SearchElementByIndex(int[,] inputArray)
{
    Console.WriteLine("Задайте номер строки искомого элемента: ");
    int inputCountRow = int.Parse(Console.ReadLine());

    Console.WriteLine("Задайте номер столбца искомого элемента: ");
    int inputCountColumn = int.Parse(Console.ReadLine());


    if (inputCountRow > countRow ^ inputCountColumn > countColumn)
    {
        Console.WriteLine("Такого элемента нет. ");
    }
    else
    {
        Console.WriteLine("Искомый элемент: "+inputArray[inputCountRow, inputCountColumn]);
    }
}



//Метод печати результата поиска

// void PrintResult(bool result)
// {
//     if (result == true)
//     {
//         Console.WriteLine("Элемент найден.");
//     }
//     else
//     {
//         Console.WriteLine("Элемент не найден.");
//     }
// }


Reading();
int[,] twoDimArray = FillTwoDimArray(countRow,countColumn);
PrintTwoDimArray(twoDimArray);
//bool result = SearchElement(twoDimArray);
//PrintResult();
//SearchNumberOfElement(twoDimArray);
SearchElementByIndex(twoDimArray);




