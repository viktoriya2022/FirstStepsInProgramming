//  Напишите программу, которая будет создавть копию заданного одномерного массива
//  с помощью поэлементного копирования.
//=============================================

Console.Clear();

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


//тип object позволяет чделать метод универлальным, без необходимости указывать тип данных
object[] CopyArrayStandartTool(params object[] inputArray)
{
    object[] buferArray=new object[inputArray.Length];
    inputArray.CopyTo(buferArray,0);
    return buferArray;
}
int[] testArray=FillingArray();
PrintIntArray(testArray);

//int[] outArray=(int[])CopyArrayStandartTool(testArray);
//PrintIntArray(outArray);

// string[] CopyArrayStandartTool(int[] inputArray)
// {
//     string[] buferArray=new int[nnputArray.Length];
//     inputArray.CopyTo(buferArray,0);
//     return buferArray;
// }

// double[] CopyArrayStandartTool(int[] inputArray)
// {
//     double[] buferArray=new int[nnputArray.Length];
//     inputArray.CopyTo(buferArray,0);
//     return buferArray;
// }