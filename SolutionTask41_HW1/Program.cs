// // ==================================================================================================
// // Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.===
// //===================================================================================================

// Console.Clear();

// Console.Write("Введите количество элементов массива: ");
// int quantity = int.Parse(Console.ReadLine());
// Console.WriteLine("Вводите элементы массива: ");

// //Объявляем новый массив
// int[] array = new int[quantity];

// //Метод заполнения массива с клавиатуры
// int[] FillingArray(int[] array, int quantity)
// {
//     int elementOfArray = 0;
//     while (elementOfArray < quantity)
//     {
//         array[elementOfArray] = int.Parse(Console.ReadLine());
//         elementOfArray++;
//     }
//     return array;
// }

// //Метод печати массива
// void PrintIntArray(int[] inputArray)
// {
//     //Буферная переменная
//     int i = 0;
//     //Пробегаем все элементы массива
//     while (i < inputArray.Length - 1)
//     {
//         //Выводим элемент массива
//         Console.Write(inputArray[i] + ", ");
//         //Увеличиваем инкремент
//         i++;

//     }
//     Console.WriteLine(inputArray[i]);
// }

// //Метод подсчета количества положительных элементов в массиве
// int Calculate(int[] array)
// {
//     int count = 0;
//     int i = 0;
//     while (i < array.Length)
//     {
//         if (array[i] > 0)
//         {
//             count++;
//             i++;
//         }
//         else
//         {
//             i++;
//         }
//     }
//     return count;
// }

// //Метод печати результата подсчета
// void PrintResult(int count)
// {
//     Console.WriteLine("Количество введенных положительных чисел: " + count);
// }

// FillingArray(array, quantity);
// PrintIntArray(array);
// PrintResult(Calculate(array));


//======================================
// Решение Mаксима Дорна (через swift)==
//======================================

Console.Clear();

Console.WriteLine("Введите ожидаемое количество нажатий: ");
int n = Int32.Parse(Console.ReadLine()); // Ввод глобальной переменной n (колиство нажатий)
Console.WriteLine();

int positiveCount = 0; //счетчик введенных положительный значений
int j = 0; // счетчик для заполнения массива (обнуляется после каждого нажатия enter)
char[] result = new char[n]; // обознаяаем массив для записи символов, вводимых пользователем
int intResult = 0; //результат в int для сарвнения вводимых символов с 0
string tempString = string.Empty; //временная строковая переменная

Console.WriteLine("Введите положительные и/или отрицательные числа, разделяя их клавишей 'Enter'");
Console.WriteLine("(знак '-' не учитывается как нажатие): ");

while (n > 0) //цикл, пока количество оствшихся доступных нажатий >0
{
    ConsoleKeyInfo key = Console.ReadKey(true); //организовываем ввод значений через ключ ("true" скрывает любые знаки при вводе, кроме ключей: цир, "-", "enter")
    switch (key.Key) //функция, которая будет зависеть от ключа
    {
        //кейс нажатия клавиши Enter
        case ConsoleKey.Enter:
            Console.WriteLine();

            tempString = new string(result); //временная строковая переменная для принятия массива из default (символы нужны для распознавания "-")
            intResult = int.Parse(tempString.ToString()); //Парсим временную строку в int для сравнения с 0
            if (intResult > 0) positiveCount++; //повышаем инкремент после больше 0
            j = 0; //сбрасываем счетчик индекса массива
            result = new char[n + 1]; // Реинициируем символьный массив, чтобы не учитывались старые значения в новых циклах
            break;
        //дефолтный сценарий: ввод цифр и "-"
        default:

            if (char.IsDigit(key.KeyChar) || key.Key == ConsoleKey.OemMinus) //ключ принимается, если не входе цифра или "-"
            {
                result[j] = key.KeyChar; //записываем распознанный ключ под индексом j
                Console.Write(result[j]); //печатаем результат, так ак ввод не виден из-за true в Console.ReadKey

                if (char.IsDigit(key.KeyChar)) //теперь минус не вычитается из количества нажатий
                {
                    n--; //Декремент счетчика нажатий
                }
                j++; //инкремент индекса создаваемого массива
                if (n == 0) goto case ConsoleKey.Enter; // чтобы подсчитывалось последнее значение больше 0

            }
            break;
    }

}

Console.WriteLine();
Console.WriteLine("Введено чисел больше нуля: "+positiveCount);
Console.WriteLine();