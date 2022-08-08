// Задайте массив, заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

Console.Clear();

//Метод возвращает массив, заполненный случайными положительными трехзначными числами (в данном случае 10)
int[] FillingArray()
{
    //Выходной массив
    int[] outArray = new int[10];
    //Буферная переменная
    int i = 0;
    //Создаем экземпляр класса рандомайзер
    System.Random numberSintezator = new System.Random();
    //Цикл заполнения массива
    while (i < 10)
    {
        //Получаем новое значение
        outArray[i] = numberSintezator.Next(100, 1000);
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
    Console.WriteLine(inputArray[i]+".");
}

//Метод подсчета количества четных чисел
int CalculateTask(int[] inputArray)
{
    //Буферные переменные
    int resultCount = 0;
    int i = 0;
    //Проходим по всей длине массива
    while (i < inputArray.Length)
    {
        if (inputArray[i] % 2 == 0)
        {
            resultCount++;
        }
        i++;
    }
    Console.WriteLine();
    return resultCount;
}

int[] bufferArray = FillingArray();
PrintIntArray(bufferArray);
Console.WriteLine(CalculateTask(bufferArray));

