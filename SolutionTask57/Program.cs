// ==================================================================================================================
// Составить частотный словарь элементов двумерного массива (Частотный словарь содержит информацию о том, 
// насколько часто встречается элемент входных данных).                                                        
// ==================================================================================================================
// array = [1,2,1,3,2,1,5,2,5,3,5]
// alphabet = [1,2,3,5]
// freqmancy =[3,3,2,3] 
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

//Метод печатает массив
void PrintIntArray(int[] inputArray)
{
    //Буферная переменная
    int i = 0;
    //Пробегаем все элементы массива
    while (i < inputArray.Length - 1)
    {
        //Выводим элемент массива
        Console.Write(inputArray[i] + ", ");
        //Увеличиваем инкремент
        i++;

    }
    Console.WriteLine(inputArray[i]);
}

//Метод составляет частотный словарь 
//принимает двумерный массив
//возвращает массив
int[] FreqmancyCollect(int[,] inputArray, int alphabetLength) //принимает двумерный, на выходе одномерный
{

    int[] resultArray = new int[alphabetLength]; //создаем новый массив, куда будем складывать итог,выделяем память (new)под 100 элементов
    int i = 0; int j = 0;

    while (i < inputArray.GetLength(0)) //пока номер строки(i) меньше чем запрошенная нами длина массива по строке (0)
    {
        j = 0;
        while (j < inputArray.GetLength(1)) //пока номер столбца(j) меньше чем запрошенная нами длина массива по столбцу (1)
        {
            // array = [1,2,1,3,2,1,0,2,0,3,0]
            // alphabet = [0,1,2,3]
            // freqmancy =[3,3,3,2] 

            //собираем частоту появления элементов
            resultArray[inputArray[i, j]]++;
            j++;
        }
        i++;
    }
    return resultArray; //так как мы меняли весь массив, его и выдаем на выход
}


//собираем программу

int[,] twoDimArray = FillTwoDimArray(3, 3);//заполнили массив
PrintTwoDimArray(twoDimArray);//напечатали исходный заполненный массив
Console.WriteLine();//пустая строка на консоль

int[] freqmansy = FreqmancyCollect(twoDimArray,10); //создаем новый массив(freqmansy) и передаем ему массив для сбора частот
                                                    //(в массиве решения) и длину алфавита (10)
PrintIntArray(freqmansy); //печатаем одномерный массив(freqmansy)



