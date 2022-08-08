// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.

Console.Clear();

//Метод возвращает массив, заполненный случайными вещественными числами (в данном случае 10)
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
        outArray[i] = numberSintezator.Next(-100, 100);
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
    Console.WriteLine(inputArray[i] + ".");
}

//Метод расчета разницы между максимальным и минимальным элементами массива
int CalculateTask(int[] inputArray)
{
    //Буферные переменные
    int dif = 0;
    int i = 0;
    int max = int.MinValue;
    int min = int.MaxValue;
    //Проходим по всей длине массива
    while (i < inputArray.Length)
    {
        if (inputArray[i] > max)
        {
            max = inputArray[i];
        }
        if (inputArray[i] < min)
        {
            min = inputArray[i];
        }
        i ++;
    }
    dif = max - min;
    return dif;
}

int[] bufferArray = FillingArray();
PrintIntArray(bufferArray);
Console.WriteLine("Разница между максимальным и минимальным элементами массива: " + CalculateTask(bufferArray));
