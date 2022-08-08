// Задайте одномерный массивиз 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].

Console.Clear();


//Метод возвращает массив, заполненный случайными числами (от -1000 до 1000)
int[] FillingArray()
{
    //Выходной массив
    int[] outArray = new int[123];
    //Буферная переменная
    int i = 0;
    //Создаем экземпляр класса рандомайзер
    System.Random numberSintezator = new System.Random();
    //Цикл заполнения массива
    while (i < 123)
    {
        //Получаем новое значение (произвольные, т.е Next не определен-пустые скобки)
        outArray[i] = numberSintezator.Next(-1000,1000);
        //Увеличиваем инкремент
        i++;

    }
    //Возвращаем значение
    return outArray;
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

//Метод решения задачи 35 наивный
int CalculateTask(int[] inputArray, int douwBorder, int upBorder)
{
    //Буферные переменные
    int resultCount = 0;
    int i = 0;
    //Проходим по всей длине массива
    while (i < inputArray.Length)
    {
        if (inputArray[i] >= douwBorder && inputArray[i] <= upBorder)
        {
            Console.Write(inputArray[i]+" ");
            resultCount++;
        }
        i++;
    }
    Console.WriteLine();
    return resultCount;
}

//Собираем программу

int[] bufferArray=FillingArray();
PrintIntArray(bufferArray);

Console.WriteLine(CalculateTask(bufferArray,10,99));
