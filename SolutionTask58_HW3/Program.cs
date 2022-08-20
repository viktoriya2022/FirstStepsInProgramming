// =========================================================================================
// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// =========================================================================================

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

//Метод перемножения матриц
int[,] Multiplication(int[,] a, int[,] b)
{
    //проверяем возможность умножения матриц
    if (a.GetLength(1) != b.GetLength(0)||a.GetLength(0) != b.GetLength(1)) throw new Exception("Данные матрицы нельзя перемножить.");
    
    int[,] r = new int[a.GetLength(0), b.GetLength(1)];
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < b.GetLength(1); j++)
        {
            for (int k = 0; k < b.GetLength(0); k++)
            {
                r[i, j] += a[i, k] * b[k, j];
            }
        }
    }
    return r;
}


int[,] AMatrix = FillTwoDimArray(3, 4);
PrintTwoDimArray(AMatrix);
Console.Write("\n");
int[,] BMatrix = FillTwoDimArray(4, 2);
PrintTwoDimArray(BMatrix);
Console.Write("\n");
int[,] CMatrix = Multiplication(AMatrix, BMatrix);
PrintTwoDimArray(CMatrix);




