// Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом амассиве.

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
        outArray[i] = numberSintezator.Next(-1000, 1000);
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

//Метод решения задачи 37 наивный
//метод возвращает МАССИВ, поэтому [] и объявляем буферную переменную
int[] CalculateTask(int[] inputArray)
{
    int[] resultArray = new int[inputArray.Length / 2 + 1];
    int i = 0;
    while (i < resultArray.Length)
    {
        resultArray[i] = inputArray[i] * inputArray[inputArray.Length - 1 - i];
        i++;
    }
    return resultArray;
}

//Собираем программу

int[] bufferArray = FillingArray();
PrintIntArray(bufferArray);
int[]resultArray=CalculateTask(bufferArray);
PrintIntArray(resultArray);

