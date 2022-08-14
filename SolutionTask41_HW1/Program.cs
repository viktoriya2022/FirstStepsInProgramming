// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//====================================

Console.Clear();

Console.Write("Введите количество элементов массива: ");
int quantity = int.Parse(Console.ReadLine());
Console.WriteLine("Вводите элементы массива: ");

//Объявляем новый массив
int[] array = new int[quantity];

//Метод заполнения массива с клавиатуры
int[] FillingArray(int[] array, int quantity)
{
    int elementOfArray = 0;
    while (elementOfArray < quantity)
    {
        array[elementOfArray] = int.Parse(Console.ReadLine());
        elementOfArray++;
    }
    return array;
}

//Метод печати массива
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

//Метод подсчета количества положительных элементов в массиве
int Calculate(int[] array)
{
    int count = 0;
    int i = 0;
    while (i < array.Length)
    {
        if (array[i] > 0)
        {
            count++;
            i++;
        }
        else
        {
            i++;
        }
    }
    return count;
}

//Метод печати результата подсчета
void PrintResult(int count)
{
    Console.WriteLine("Количество введенных положительных чисел: " + count);
}

FillingArray(array, quantity);
PrintIntArray(array);
PrintResult(Calculate(array));


