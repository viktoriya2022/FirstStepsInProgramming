Console.WriteLine("Введите трехзначное число");

string? inputLkneOne = Console.ReadLine();

if (inputLkneOne != null)
{
    int inputNumberOne = int.Parse(inputLkneOne);

    int secondNumber = (inputNumberOne % 100) / 10;
    Console.WriteLine(secondNumber);
}