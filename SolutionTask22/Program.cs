// //Считываем переменную
// string? inputLineN = Console.ReadLine();

// if (inputLineN != null) // цикл проверки
// {
//     int numberN = int.Parse(inputLineN);
//     //объявляем переменные, lineN и lineNN пустые строки
//     string lineN = "";
//     string lineNN = string.Empty;
//     int s = 1;
//     while (s <= numberN)
//     {
//         lineN = lineN + s + " ";
//         lineNN = lineNN + (s * s).ToString() + " ";
//         s++;
//     }

// Console.WriteLine(lineN);
// Console.WriteLine(lineNN);
// }

//Вариант Кирилла Новикова
//используется динамический массив
List<int> listGen(int number)
{
    List<int> numbers = new List<int>();
    for (int i = 1; i <= number; i++)
    {
        numbers.Add(i);
    }
    return numbers;
}
//Считываем число 
string? inputLine = Console.ReadLine();

if (inputLine != null)
{
    //Преобразуем в вещественный вид
    int inputNumber = int.Parse(inputLine);
    List<int> nums = listGen(inputNumber);
    foreach (var i in nums)
    {
        Console.Write(i);
        Console.Write(" ");
    }
    Console.WriteLine();
    foreach (var i in nums)
    {
        Console.Write(Math.Pow(i, 2));
        Console.Write(" ");
    }
}