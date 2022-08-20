// ===============================================================================================
// Сформируйте трехмерный массив из неповторяющихся двузначных чисел. Напишите программу,  
// которая будет построчно выводить массив, добавляя индексы каждого элемента.
// ===============================================================================================// =========================================================================================


Console.Clear();

//Метод для заполнения трёхмерного массива
int[,,] FillThreeDimArray(int countRow, int countColumn, int countZ)

{
    System.Random numberSyntezator = new System.Random();

    int i = 0; int j = 0; int k = 0; int num = 0;
    //Создаем список
    List<int> numbers = new List<int>();
    //Создаем массив
    int[,,] outArray = new int[countRow, countColumn, countZ];
    while (i < countRow)
    {
        j = 0;
        while (j < countColumn)
        {
            k = 0;
            while (k < countZ)
            {
                num = numberSyntezator.Next(0, 100);
                if (numbers.Contains(num))
                { }
                else
                {
                    outArray[i, j, k] = num;
                }
                k++;
            }
            j++;
        }
        i++;
    }

    //Возвращаем значение
    return outArray;
}

//Метод для печати трехмерного массива
void PrintThreeDimArray(int[,,] inputArray)
{
    int i = 0; int j = 0; int k = 0;

    while (i < inputArray.GetLength(0))
    {
        j = 0;
        while (j < inputArray.GetLength(1))
        {
            k = 0;
            while (k < inputArray.GetLength(2))

            {
                Console.Write($"{inputArray[i, j, k]}({i},{j},{k})" + "\t");
                k++;
            }
            j++;
        }
        Console.Write("\n");
        i++;
    }
}

Console.Write("\n");
int[,,] Array = FillThreeDimArray(3, 3, 3);
PrintThreeDimArray(Array);
Console.Write("\n");





