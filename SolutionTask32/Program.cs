// Напишите программу замены элементов массива: положительные элементы на отрицательные, и наоборот.

Console.Clear();

//Метод возвращает массив, заполненный случайными числами 
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

//Метод инвертирует элементы массива
int[] CalculateTask(int[] inputArray)
{
    int[] outputArray = new int[12];
    int i = 0;
    while (i < 12)
    {
        outputArray[i] = inputArray[i] * (-1);
        i++;
    }
    return outputArray;
}

//Метод инверсии через оператор
int[] InvertArrayTilda(int[] inputArray)
{
//буферная переменная
    int i = 0;
    //Пробегаем все элементы массива
    while (i < inputArray.Length)
    {
        //Инвертируем элемент
        inputArray[i] = (~inputArray[i]) + 1;
        //Увеличиваем инкремент
        i++;
    }
    //Выводим массив
    return inputArray;
}

int[] bufferArray = FillingArray();
PrintIntArray(bufferArray);
int[] resultArray = CalculateTask(bufferArray);
PrintIntArray(resultArray);
resultArray=InvertArrayTilda(bufferArray);
PrintIntArray(resultArray);