// Задайте массив. Напишите программу, котрая определит, присутсвует ли заданное число в массиве.

Console.Clear();

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

//Метод решения задачи 33 наивный
bool CalculateTask(int[] inputArray, int searchNumber) // bool: либо да ли нет (всего один байт)
{
    bool resultSearch=false;
    int i = 0;
    while (i < 12)
    {
        if(inputArray[i]==searchNumber)
        {
            resultSearch=true;
            break;
        }        
       
        i++;
    }
    return resultSearch;
}

int[] bufferArray=FillingArray();
PrintIntArray(bufferArray);
Console.WriteLine("Введите число для поиска: ");
int searchNumber=int.Parse(Console.ReadLine());
//int[] resultArray = CalculateTask(bufferArray);

Console.WriteLine(CalculateTask(bufferArray,searchNumber));
