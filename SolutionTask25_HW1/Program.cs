//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// Очищаем консоль
Console.Clear();

//Обозначаем исходные переменные
int inputFirstNumber;
int inputSecondNumber;
int exponNumberMath;
int exponNumberCalc;

//Вводим метод считывания с консоли:
void Read()
{
    //Выводим на консоль сообщение для пользователя:
    Console.Write("Введите число - основание степени: ");
    //Распарсиваем введенную переменную в новую:
    inputFirstNumber = int.Parse(Console.ReadLine());
    //то же самое для второй переменной-показателя степени:
    Console.Write("Введите число - показатель степени: ");
    inputSecondNumber = int.Parse(Console.ReadLine());
}

//Вводим метод расчета на основании метода math.Pow:
void MathPow()
{

    exponNumberMath = (int)Math.Pow(inputFirstNumber, inputSecondNumber); //принудительно преобразовали double в int (отбросит лишние байты)

}

//Вводим метод расчета на основании последовательного умножения:
int Calculate()
{
    exponNumberCalc = 1;
    int i = 0;
    while (i < inputSecondNumber)
    {
        exponNumberCalc *= inputFirstNumber;
        //exponNumberCalc = inputFirstNumber * exponNumberCalc;
        i++;

    }
    return exponNumberCalc;
}

//Вводим метод вывода результатов на консоль:
void Print()
{
    Console.WriteLine(inputFirstNumber + " ^ " + inputSecondNumber + " = " + exponNumberMath);
    Console.WriteLine(inputFirstNumber + " ^ " + inputSecondNumber + " = " + exponNumberCalc);
}

//Вызываем методы:
Read();
MathPow();
Calculate();
Print();