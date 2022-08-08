// Задайте массив из 12 элементов, заполненный случайными числами из
// промежутка [-9,9]. Найдите сумму отицательных и положительных элементов массива. 

Console.Clear();

//Вводим переменные:
int positiveSum = 0;
int negativeSum = 0;

//Метод возвращает массив, заполненный случайными числами от -9 до 9.
int[] FillingArray()
{
    //Выходной массив
    int[] outArray = new int[12];
    //Буферная переменная
    int i = 0;
    //Создаем экземпляр класса рандомайзер
    System.Random numberSintezator = new System.Random();
    //Цикл заполнения массива
    while (i < 12)
    {
        //Получаем новое значение
        outArray[i] = numberSintezator.Next(-9, 10);
        //Увеличиваем инкремент
        i++;

    }
    //Возвращаем значение
    return outArray;
}

//Метод подсчета положительных и отрицательных значений
void CalculateTask(int[] outArray)
{
    int i = 0;
    while (i < 12)
    {
        if (outArray[i] > 0)
        {
            //positiveSum++;
            positiveSum += outArray[i];
        }
        else
        {
            //negativeSum++;
            negativeSum += outArray[i];
        }
        i++;
    }
}

//Метод Вывода результата на консоль
void PrintResult()
{
    Console.WriteLine(positiveSum);
    Console.WriteLine(negativeSum);
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

//Метод решения 31 задачи наивный
void VariantNaive()
{
    int[] bufferArray = FillingArray();
    PrintIntArray(bufferArray);
    CalculateTask(bufferArray);

    //CalculateTask(bufferArray());
    PrintResult();
}

VariantNaive();

//Метод решения задачи 31 простой

void VariantSimple()
{
    //Создаем экземпляр класса рандомайзер
    System.Random numberSintezator = new System.Random();

    //Буферные переменные
    int i = 0;
    int buf = 0;

    //Цикл заполнения массива 
    while (i < 12)
    {
        //Получаем новое значение
        buf = numberSintezator.Next(-9, 10);
        //Выводим массив на печать
        Console.Write(buf+" " );
        
        //Накапливаем результат
        if (buf > 0)
        {
            //элемент положительный
            positiveSum += buf;
        }
        else
        {
            //элемент отрицательный
            negativeSum += buf;
        }
        //Увеличиваем инкремент
        i++;
    }
    Console.WriteLine();
    //Выводим результаты на консоль
    Console.WriteLine(positiveSum);
    Console.WriteLine(negativeSum);
}

 VariantSimple();

// //Kirill Novikov: 
// System.Random numberSintezator = new Random();

// int[] array = getArray(12);
// Console.WriteLine("Сумма положительных элементов: " + calcPositive(array, true));
// Console.WriteLine("Сумма отрицательных элементов: " + calcPositive(array, false));

// int[] getArray(int num)
// {
//     int[] array = new int[num];
//     int i = 0;
//     Console.Write("Сгенерирован массив: ");
//     while (i < array.Length - 1)
//     {
//         array[i] = numberSintezator.Next(-9, 10);
//         Console.Write(array[i] + " "); // для проверки
//         i++;
//     }
//     Console.WriteLine();
//     return array;
// }

// int calcPositive(int[] array, bool isPositive)
// {
//     int i = 0;
//     int sum = 0;
//     while (i < array.Length - 1)
//     {

//         if (isPositive && array[i] > 0)
//         {
//             sum += array[i];
//         }
//         else if (!isPositive && array[i] < 0)
//         {
//             sum += array[i];
//         }
//         i++;
//     }
//     return sum;
// }