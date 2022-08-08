// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

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
        outArray[i] = numberSintezator.Next(0, 10);
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

//Метод подсчета суммы элементов, стоящих на нечётных позициях
int CalculateTask(int[] inputArray)
{
    //Буферные переменные
    int sum = 0;
    int i = 1;
    //Проходим по всей длине массива
    while (i < inputArray.Length)
    {
        sum += inputArray[i];
        i += 2;
    }
    Console.WriteLine();
    return sum;
}

int[] bufferArray = FillingArray();
PrintIntArray(bufferArray);
Console.WriteLine("Сумма элементов на нечетных позициях: " + CalculateTask(bufferArray));
