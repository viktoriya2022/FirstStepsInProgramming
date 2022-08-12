// Напишите программу, которая перевернет одномерный массив (последний элемент будет первым, а первый-на последнем месте и т.д.)
//==================================
Console.Clear();

//Метод возвращает массив, заполненный случайными числами (от -1000 до 1000)
int[] FillingArray(int arrayLength) //задаем параметры массива(arrayLength),чтобы не вносить изменения каждый раз. Метод стал универсальным, регулируемым снаружи.
{
    //Выходной массив
    int[] outArray = new int[arrayLength];
    //Буферная переменная
    int i = 0;
    //Создаем экземпляр класса рандомайзер
    System.Random numberSintezator = new System.Random();
    //Цикл заполнения массива
    while (i < arrayLength)
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

//Метод с созданием нового массива
int[] ReverseNewArray(int[] array)
{
    //вводим переменную длины массива
    int length = array.Length;
    //создаем новый массив с той же длиной, что и входной
    int[] newArray = new int[length];

    for (int i = 0; i < length; i++)
    {
        newArray[length - 1 - i] = array[i];
        //i=0 length-1-i=12
        //i=1 length-1-i=11
    }
    return newArray;
}

//Метод Swap
int[] ReverseSwapArray(int[] array)//взяли массив
{
    int length = array.Length;//вводим длину маасива
    int buf;//вводим буферную переменную

    for (int i = 0; i < length / 2; i++)
    {
        //i=1
        buf = array[i];
        array[i] = array[length - 1 - i];
        array[length - i - 1] = buf;
    }
    return array;
}

int[] testArray = FillingArray(13); //создаем массив, заполняем его (вызываем метод запполнения), передаем параметр, напр, 13
PrintIntArray(testArray);//печатаем новый массив
int[] reversedArray = ReverseNewArray(testArray); //создаем новый массив, заполняем его развернутым массивом(вызываем метод разворачивания)
PrintIntArray(reversedArray);//печатаем развернутый массив
PrintIntArray(ReverseSwapArray(testArray));//печатаем развернутый Swap-ом массив
PrintIntArray(testArray);